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
		public static IEnumerable<Bird> GetRedRirds()
		{
			return from b in BirdRepository.LoadBirds() where b.Color == "Red" select b;
		}

		//Возвращает имена красных птиц:)
		//Пример запроса возвращающего список свойств
		public static IEnumerable<string> GetRedRirdsNames()
		{
			//Эмпирически выяснено что в условии where можно использовать булевы выражения например where b.Color == "Red" && b.Sightings > 1
			return from b in BirdRepository.LoadBirds() where b.Color == "Red" && b.Sightings > 1 select b.Name;
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
