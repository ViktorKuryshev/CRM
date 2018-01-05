using System;
using System.Windows.Forms;
using Testing_Async_and_Await;

namespace StudyCollections
{
	static class Program
	{
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new HashSet.Form1());
			CountCharactersInFile newWindow = new CountCharactersInFile();
			newWindow.ShowDialog();
		}
	}
}
