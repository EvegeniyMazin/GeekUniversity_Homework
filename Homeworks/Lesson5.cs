using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Homeworks
{
	class StringsHW
	{
		//проверям перестановку символов
		public StringsHW(string text1, string text2, bool isPalindrome = false)
		{
			isPalindrome = text1.Select(Char.ToUpper).OrderBy(x => x).SequenceEqual(text2.Select(Char.ToUpper).OrderBy(x => x));
			if (isPalindrome == true)
			{
				Console.WriteLine("Один текст является перестановкой другого");
			}
			else
			{
				Console.WriteLine("Тексты отличаются. Один текст не является перестановкой другого");
			}

			Console.ReadKey();
		}
		
		/*игнорировать этот вариант 
		public StringsHW(string text1, string text2, int x, bool isPalindrome = false)
		{
			
			//Создаём массив и копируем туда все совпадающие имена. Сравниваем длину массива с суммой длин юзерских массивов 
			
			StringBuilder first = new StringBuilder(text1);//abba
			StringBuilder second = new StringBuilder(text2);//baba
			StringBuilder compare = new StringBuilder();//aabbbbaa
			compare.Insert(0, '.');
			int CompareInd = 0;

			if (text1.Length != text2.Length)
			{
				Console.WriteLine("Тексты отличаются. Один текст не является перестановкой другого");
			}
			else
			{
				for (int i = 0; i < text1.Length; i++)
				{
					for (int j = 0; j < text2.Length; j++)
					{
						if (text1[i] == text2[j] && compare[CompareInd] == '.')
						{
							compare.Insert(0, text1[i]);
							CompareInd++;
							Console.WriteLine($"i={i}  j={j}\ntext1[i]={text1[i]}\ntext2[j]={text2[j]}\ncompare[i]={compare[i]}\ncompare.Length={compare.Length}\nCompareInd={CompareInd}\n");
							
						}
						else if (text1[i] == text2[j])
						{
							compare.Insert(compare.Length + 1, text1[i]);
							Console.WriteLine($"i={i}  j={j}\ntext1[i]={text1[i]}\ntext2[j]={text2[j]}\ncompare[i]={compare[i]}\ncompare.Length={compare.Length}\nCompareInd={CompareInd}\n");
							//compare.Insert(0, text1[i]);
						}
					}
					
				}
				Console.WriteLine("array compare:\n");
				int compareLCount = Convert.ToInt32(compare.Length); 
				while(compareLCount >= 0)
				{
					Console.WriteLine(compare[compareLCount]);
					compareLCount -= 1;
				}

				if (compare.Length == text1.Length)
				{
						Console.WriteLine("Один текст является перестановкой другого");
						Console.ReadKey();
				}
				else
				{
						Console.WriteLine("Тексты отличаются. Один текст не является перестановкой другого");
						Console.ReadKey();
				}
			*/
	}
		
	class Message
	{
		public void UserLength(string userText, int length)
		{
			string[] GetWords = userText.Split(' ');
			string newUserText = "";
			for(int i =0; i <GetWords.Length; i++)
			{
				if (GetWords[i].Length < length)
				{
					newUserText += GetWords[i] + ' ';
				}
			}
					
			Console.WriteLine($"Слова, содержащие менее {length} букв: {newUserText}");
			Console.ReadKey();

		}
		public void DelIfLastSymbol(string userText, char c)
		{
			string[] GetWords = userText.Split(' ');
			string newUserText = "";
			for(int i = 0; i< GetWords.Length; i++)
			{
				if (GetWords[i].LastIndexOf(c)+1 != GetWords[i].Length)
				{
					newUserText += GetWords[i]+" ";
				}
			}
			Console.WriteLine($"Слова, НЕ заканчивающиеся на {c} : {newUserText}");
			Console.ReadKey();
		}
		public void LongestWord(string userText)
		{
			string[] GetWords = userText.Split(' ');
			StringBuilder longestwords = new StringBuilder(userText.Length);
			string newUserText = "";
			int LongestWords = GetWords[0].Length;
			for (int i = 0; i < GetWords.Length; i++)
			{
				if (GetWords[i].Length > LongestWords)
				{
					LongestWords = GetWords[i].Length;
				}
			}
			for (int i = 0; i < GetWords.Length; i++)
			{
				if (GetWords[i].Length == LongestWords)
				{
					newUserText += GetWords[i] + "\n";
					longestwords.Append(GetWords[i]+" ");
				}
			}
			Console.WriteLine($"Максимальная длина слова в вашем тексте: {LongestWords}\nСамые длинные слова в вашем тексте: \n{newUserText}");
			Console.WriteLine($"Ваша строка Stringbuilder из самых длинных слов: {longestwords}");
			Console.ReadKey();
		}
	}
	class Task1
	{
		public bool IsValidChar(string userLogin)
		{
			for (int i = 0; i <= userLogin.Length; i++)
			{
				if ((userLogin[i] >= 'A' && userLogin[i] <= 'Z') || (userLogin[i] >= 'a' && userLogin[i] <= 'z')|| (userLogin[i] >= '0' && userLogin[i] <= '9'))
				{
					return true;
				}
			}
			return false;
		}
		public bool StartsWithNumber(string userLogin)
		{
			
			return (Char.IsDigit(userLogin[0]));
			
		}
		public bool CorrectLength(string userLogin)
		{
			return (userLogin.Length > 2 && userLogin.Length <=10);
		}
		public bool RegEx(string userLogin)
		{
			Regex isValid = new Regex(@"^\D[a-zA-Z0-9]{1,9}$");
			return isValid.IsMatch(userLogin);
		}
	}
}
