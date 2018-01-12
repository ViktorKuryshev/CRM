using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;

using Newtonsoft.Json;
using RestSharp;
using CRM_GTMK.Model.DataModels;
using System.Collections.Generic;

namespace CRM_GTMK.Model.TestApi
{
	public class ApiClient
	{
		private const string accountId = "6b3b9c8f-55e7-486c-975b-21bcfef6ef5c";
		private const string ApiKey = "3_QievMUh2JUpi6ET29bz308qTF";

		public static string ProjectsListUrl { get; private set; } = "https://smartcat.ai/api/integration/v1/project/list";

		public static string Url = "https://smartcat.ai";

		public static string AuthorizationValue { get; set; }

		public ApiClient()
		{
			AuthorizationValue = accountId + ":" + ApiKey;
		}

		public List<RecievedProject> GetCurrentProjects()
		{
			
				var authorizationValueBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(AuthorizationValue));

				var client = new RestClient(Url);
				var request = new RestRequest(get_projects_list, Method.GET);

				request.AddHeader("Authorization", "Basic " + authorizationValueBase64);

				IRestResponse response = client.Execute(request);
				var content = response.Content;


			List<RecievedProject> projects = JsonConvert.DeserializeObject<List<RecievedProject>>(content);
			

			return projects;
		}

		public string GetAssignableExecutives()
		{
			
			var authorizationValueBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(AuthorizationValue));

			var client = new RestClient(Url);
			var request = new RestRequest(get_assignable_executives, Method.GET);

			request.AddHeader("Authorization", "Basic " + authorizationValueBase64);

			IRestResponse response = client.Execute(request);
			var content = response.Content;

			Console.WriteLine("Содержимое ответа от сервера: {0}", content);

			
			return content;
		}

		public string CreateProject(string[] filePaths = null, Project project = null)
		{
			Project newProject = project ?? new Project();

			Console.WriteLine("Имя проекта: {0}", project.Name);


			var authorizationValueBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(AuthorizationValue));

			var client = new RestClient(Url);
			var request = new RestRequest(post_project_create_url, Method.POST);

			request.AddHeader("Authorization", "Basic " + authorizationValueBase64);
			request.AlwaysMultipartFormData = true;

			if (filePaths != null)
			{
				foreach (var filePath in filePaths)
				{
					byte[] bytes = File.ReadAllBytes(filePath);
					request.AddFileBytes("file", bytes, filePath, "application/octetstream");
				}
			}

			var requestString = JsonConvert.SerializeObject(project);

			request.AddParameter("application/json", JsonConvert.SerializeObject(project), "application/json", ParameterType.RequestBody);

			IRestResponse response = client.Execute(request);
			var content = response.Content; // raw content as string
			

			Console.WriteLine("Содержимое ответа от сервера: {0}", content);
			newProject = JsonConvert.DeserializeObject<Project>(content);

			return newProject.Name;
		}

		public string CreateTm(string tmxFilePath = null, bool replaceAllContent = true)
		{
			var tm = new TranslationMemory();

			var createTmRequest = createRequest(post_tm_url, HttpMethods.Post, tm);
			var response = (HttpWebResponse)createTmRequest.GetResponse();

			var reader = new StreamReader(response.GetResponseStream());
			var id = reader.ReadToEnd().Replace("\"", "");

			Console.WriteLine("Содержимое ответа от сервера: {0}", id);

			if (tmxFilePath != null)
			{
				var tmx = new Tmx(id, tmxFilePath, replaceAllContent);
				var url = post_tm_tmx_url.Replace("{tmId}", tmx.TmId) + tmx.ReplaceAllContent;
				httpUploadFile(url, tmx.TmxFile);
			}

			response.Close();
			response.Dispose();

			return tm.Name;
		}

		public void CreateTm(TranslationMemory tm)
		{
			var createTmRequest = createRequest(post_tm_url, HttpMethods.Post, tm);
			var response = (HttpWebResponse)createTmRequest.GetResponse();

			response.Close();
			response.Dispose();
		}

		public Client CreateClient()
		{
			var catClient = new Client();

			Console.WriteLine("Имя клиента: {0}", catClient.Name);

			
			var authorizationValueBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(AuthorizationValue));

			var client = new RestClient(Url);
			var request = new RestRequest(post_client_url, Method.POST);

			request.AddHeader("Authorization", "Basic " + authorizationValueBase64);
			request.AddParameter("application/json", JsonConvert.SerializeObject(catClient.Name), ParameterType.RequestBody);

			IRestResponse response = client.Execute(request);
			var content = response.Content; // raw content as string

			Console.WriteLine("Содержимое ответа от сервера: {0}", content);

			catClient.Id = content.Replace("\"", "");

			
			return catClient;
		}

		private HttpWebRequest createRequest(string url, HttpMethods method, object obj)
		{
			
			var authorizationValueBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(AuthorizationValue));
			var request = (HttpWebRequest)WebRequest.Create(url);
			Console.WriteLine("{0} запрос отправлен на адрес {1}", method, url);
			var jsonString = JsonConvert.SerializeObject(obj, Formatting.None,
				new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
			Console.WriteLine("Содержимое запроса: {0}", jsonString);
			byte[] byteArray = Encoding.UTF8.GetBytes(jsonString);

			request.Headers.Add("Authorization", "Basic " + authorizationValueBase64);
			request.Method = method.Description();
			request.ContentType = "application/json";
			request.Timeout = 200000;

			Stream dataStream = request.GetRequestStream();
			dataStream.Write(byteArray, 0, byteArray.Length);
			dataStream.Close();
			dataStream.Dispose();

			
			return request;
		}

		private void httpUploadFile(string url, string filePath)
		{
			
			var authorizationValueBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(AuthorizationValue));

			using (WebClient client = new WebClient())
			{
				client.Headers.Add("Authorization", "Basic " + authorizationValueBase64);
				client.UploadFile(url, filePath);
				client.Dispose();
			}

			
		}

		private string takeKey(ConcurrentBag<string> keys)
		{
			string key = null;
			var timer = 1;

			while (!keys.TryTake(out key) && timer <= 300)
			{
				Thread.Sleep(1000);
				timer++;
			}

			if (timer > 300)
			{
				throw new Exception("Произошла ошибка:\n нет ключей в очереди");
			}

			Console.WriteLine("Ключ {0} взят из очереди после {1} попытки.", key, timer);

			return key;
		}

		private void returnKey(ConcurrentBag<string> keys, string key)
		{
			try
			{
				if (!keys.Contains(key))
				{
					keys.Add(key);
					Console.WriteLine("Ключ {0} возвращен в очередь.", key);
				}
			}
			catch
			{
				Console.WriteLine("Произошла ошибка: \nне удалось вернуть ключ {0} в очередь.", key);
			}
		}

		private static readonly string post_tm_url = Url + "/api/integration/v1/translationmemory";
		private static readonly string post_tm_tmx_url = Url + "/api/integration/v1/translationmemory/{tmId}?replaceAllContent=";
		private static readonly string post_client_url = "/api/integration/v1/client/create";
		private static readonly string post_project_create_url = "/api/integration/v1/project/create";
		private static readonly string get_assignable_executives = "/api/integration/v1/account/assignableExecutives";
		private static readonly string get_projects_list = "/api/integration/v1/project/list";


		private enum HttpMethods
		{
			[Description("GET")]
			Get,
			[Description("POST")]
			Post,
			[Description("PUT")]
			Put,
			[Description("DELETE")]
			Delete
		}
	}
}
