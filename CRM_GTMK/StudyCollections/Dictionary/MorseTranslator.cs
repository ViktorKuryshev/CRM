using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyCollections.Dictionary
{
	static class MorseTranslator
	{
		private static Dictionary<char, string> _textToMorse = new Dictionary<char, string>
		{
			{' ', "/"},
	{'A', ".-"},
	{'B', "-..."},
	{'C', "-.-."},
	{'D', "-.."},
	{'E', "."},
	{'F', "..-."},
	{'G', "--."},
	{'H', "...."},
	{'I', ".."},
	{'J', ".---"},
	{'K', "-.-"},
	{'L', ".-.."},
	{'M', "--"},
	{'N', "-."},
	{'O', "---"},
	{'P', ".--."},
	{'Q', "--.-"},
	{'R', ".-."},
	{'S', "..."},
	{'T', "-"},
	{'U', "..-"},
	{'V', "...-"},
	{'W', ".--"},
	{'X', "-..-"},
	{'Y', "-.--"},
	{'Z', "--.."},
	{'1', ".----"},
	{'2', "..---"},
	{'3', "...--"},
	{'4', "....-"},
	{'5', "....."},
	{'6', "-...."},
	{'7', "--..."},
	{'8', "---.."},
	{'9', "----."},
	{'0', "-----"},
	{',', "--..--"},
	{'.', ".-.-.-"},
	{'?', "..--.."},
	{';', "-.-.-."},
	{':', "---..."},
	{'/', "-..-."},
	{'-', "-....-"},
	{'\'', ".----."},
	{'"', ".-..-."},
	{'(', "-.--."},
	{')', "-.--.-"},
	{'=', "-...-"},
	{'+', ".-.-."},
	{'@', ".--.-."},
	{'!', "-.-.--"},
	{'Á', ".--.-"},
	{'É', "..-.."},
	{'Ö', "---."},
	{'Ä', ".-.-"},
	{'Ñ', "--.--"},
	{'Ü', "..--"}
		};

		private static Dictionary<string, char> _morseToText = new Dictionary<string, char>();

		static MorseTranslator()
		{
			foreach(KeyValuePair<char, string> code in _textToMorse)
			{
				_morseToText[code.Value] = code.Key;

				//Альтернативный вариант, выбросит исключение если такое значение уже есть.
				//_morseToText.Add(code.Value, code.Key);
			}
		}

		public static string ToMorse(string input)
		{
			List<string> output = new List<string>(input.Length);
			foreach(char caracter in input.ToUpper())
			{
				try
				{
					string morseCode = _textToMorse[caracter];
					output.Add(morseCode);
				}
				catch (KeyNotFoundException)
				{
					output.Add("!");
				}
				
			}
			return string.Join(" ", output);
		}
	}
}
