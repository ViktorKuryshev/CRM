using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdWatcher
{
	public class Bird
	{
		public Bird(string name, string color, int sightings)
		{
			Name = name;
			Color = color;
			Sightings = sightings;
		}

		public string Name { get; set; }
		public string Color { get; set; }
		public int Sightings { get; set; }

		public override string ToString()
		{
			return string.Format("Name: {0}, Color: {1}, Sightings: {2}\n", Name, Color, Sightings);
		}
	}

	public static class BirdRepository
	{
		public static List<Bird> LoadBirds()
		{
			return new List<Bird>
			{
				new Bird ( "Cardinal", "Red", 3 ),
				new Bird ( "Dove", "White", 2 ),
				new Bird ( "Robin", "Red", 5 ),
				new Bird ( "Canary", "Yellow", 0 ),
				new Bird ( "Blue Jay", "Blue", 1 )
			};
		}
	}

	public static class LinqMethods
	{
		//Возвращает красных птиц :) 
		// Пример запроса возвращающего список объектов с определенным свойством
		public static IEnumerable<Bird> GetRedВirds()
		{
			return from b in BirdRepository.LoadBirds() where b.Color == "Red" select b;
		}

		//Возвращает имена красных птиц:)
		//Пример запроса возвращающего список свойств
		public static IEnumerable<string> GetRedВirdsNames()
		{
			//Эмпирически выяснено что в условии where можно использовать булевы выражения например where b.Color == "Red" && b.Sightings > 1
			return from b in BirdRepository.LoadBirds() where b.Color == "Red" && b.Sightings > 1 select b.Name;
		}

		//Сортирует птиц по именам:)
		//Примет запроса возвращает список отсортированный по параметру
		public static IEnumerable<string> SortBirdsByNames()
		{			
			return from b in BirdRepository.LoadBirds() orderby b.Name select b.Name;
		}

		//Ставит птиц по именам задом на перед:)
		//Примет запроса возвращает список отсортированный в обратном порядке по параметру
		public static IEnumerable<string> ReversedSortBirdsByNames()
		{
			//для обратного порядка используем ключевое слово descending
			return from b in BirdRepository.LoadBirds() orderby b.Name descending select b.Name;
		}

		//Сортирует по птиц по имени и цвету:)
		//Примет запроса возвращает список отсортированный по параметру нескольким параметрам
		public static IEnumerable<string> MultipleSortBirdsByNames()
		{
			//для сортировки по разным параметрам, указываем их через запятую
			return from b in BirdRepository.LoadBirds() orderby b.Name, b.Color select b.Name;
		}

		//Сортирует по птиц по имени и цвету туда и сюда:)
		//Примет запроса возвращает список отсортированный нескольким параметрам в разных направлениях
		public static IEnumerable<string> MultipleSortInOpositeDirectionsBirdsByNames()
		{
			//для сортировки по разным параметрам, указываем их через запятую 
			//ставим desceniding после того которого хотим в обратном направлении
			return from b in BirdRepository.LoadBirds() orderby b.Name descending, b.Color select b.Name;
		}

		//Собираем птиц в стаи по цвету:)
		//Примет запроса создвает список груп(списков) сформированных на основе параметра
		public static void BirdsGroupsByColor()
		{
			var birdsByColor = from b in BirdRepository.LoadBirds()
							   group b by b.Color;
		}

		//Делаем какую-то хрень с птицами:)
		//Примет произведения каких-то действий со списком групп птиц
		public static void BirdsGroupsByColorQuery()
		{
			var someResult = from b in BirdRepository.LoadBirds()
								group b by b.Color 
								into birdsByColor
								where birdsByColor.Count() > 1
								select new {Color = birdsByColor.Key, Count = birdsByColor.Count()};
		}

		//Делает красных хз кого
		//Пример создания анонимных объектов
		public static void CreatRedAnonims()
		{
			//Создаем непонятную хрень, красного цвета
			var unknownThings = from b in BirdRepository.LoadBirds() where b.Color == "Red" && b.Sightings > 1 select new { ThingName = b.Name };
			//Мы не хрена не можем сделать с этой хренью, но можем забрать у ней данные 
			foreach(var thing in unknownThings)
			{
				new Bird(thing.ThingName, "Bred", 3);
			}
			//Т.е. неведомая зверушка(анонимная) позволяет временно сохранить данные а потом их передать.
			
		}
	}
}
