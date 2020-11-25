using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks
{

	class ArrayRank1
	{
		public int[] arr;
		public int MaxCount = 0;

		//rand array creation
		public ArrayRank1(int length, int min, int max)
		{
			this.arr = new int[length];
			Random rnd = new Random();
			for (int i = 0; i < length; i++)
			{
				this.arr[i] = rnd.Next(min, max);

			}

		}
		//array with user step creation
		public ArrayRank1(int length, int startV, short step = 1)
		{
			this.arr = new int[length];
			this.arr[0] = startV;
			for (int i = 1; i < length; i++)
			{
				this.arr[i] = this.arr[i - 1] + step;
			}
		}
		//counting couples of array values
		public int CountCouples()
		{
			int c = 0;

			for (int i = 0; i < this.arr.Length - 1; i++)
			{
				if (this.arr[i] % 3 == 0 || this.arr[i + 1] % 3 == 0)
				{
					c++;
				}
			}
			return c;
		}
		//inverse array
		public int[] Inverse()
		{
			for (int i = 0; i < this.arr.Length; i++)
			{
				this.arr[i] = -this.arr[i];
			}

			return arr;
		}

		//multiply array
		public int[] Multiply(int multiplier)
		{
			for (int i = 0; i < this.arr.Length; i++)
			{
				arr[i] *= multiplier;
			}

			return arr;
		}
		//sum array
		public int Sum()
		{
			int iSum = 0;
			for (int i = 0; i < this.arr.Length; i++)
			{
				iSum += this.arr[i];
			}
			return iSum;
		}
		public void maxCount(int[] arr, int length)
		{
			for (int i = 0; i < length; i++)
			{
				if (arr[i] == arr.Max<int>())
				{
					MaxCount++;
				}
			}
		}
	}
	class ArrayRank2
	{
		public int[,] arr;
		public int arrMaxV;//max value in array
		public int arrMinV;//min value in array
		public int MaxV_L;//max value length index
		public int MaxV_H;//max value height index

		public ArrayRank2(int length, int height, int min, int max)
		{
			this.arr = new int[length, height];
			Random rnd = new Random();
			for (int i = 0; i < length; i++)
			{
				for (int j = 0; j < height; j++)
				{
					this.arr[i, j] = rnd.Next(min, max);
				}
			}
			arrMaxV = arr.Cast<int>().Max();
			arrMinV = arr.Cast<int>().Min();
		}
		public int Sum()
		{
			int iSum = 0;
			for (int i = 0; i < this.arr.GetLength(dimension: 0); i++)
			{
				for (int j = 0; j < this.arr.GetLength(dimension: 1); j++)
				{
					iSum += this.arr[i, j];
				}
			}
			return iSum;
		}
		public int SumIf(int MaxV)
		{
			int iSum = 0;
			for (int i = 0; i < this.arr.GetLength(dimension: 0); i++)
			{
				for (int j = 0; j < this.arr.GetLength(dimension: 1); j++)
				{
					if (this.arr[i, j] > MaxV)
					{
						iSum += this.arr[i, j];
					}
				}
			}
			return iSum;
		}
		public void MaxVIndex()
		{
			for (int i = 0; i < this.arr.GetLength(dimension: 0); i++)
			{
				for (int j = 0; j < this.arr.GetLength(dimension: 1); j++)
				{
					if (this.arr[i, j] == arrMaxV)
					{
						MaxV_L = i;//row number
						MaxV_H = j;//column number
					}
				}
			}
		}
		/*Пример расчёта порядкового номера максимального значения двумерного массива
		public void Array2dValueIndex()
		{
			int arrMaxV;
			int MaxV_L;
			int MaxV_H;
			int Number;
			int[,] array2d = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
			int dimension_0 = array2d.GetLength(dimension: 0);//4 - ряды
			int dimension_1 = array2d.GetLength(dimension: 1);//3 - колонки
			Console.WriteLine($"Dimension 0:  {dimension_0}");
			Console.WriteLine($"\nDimension 1:  {dimension_1}");
			arrMaxV = array2d.Cast<int>().Max();
			Console.WriteLine($"Максимальное значение массива: {arrMaxV}");

			for (int i = 0; i < dimension_0; i++)
			{
				for (int j = 0; j < dimension_1; j++)
				{
					if (array2d[i, j] == arrMaxV)
					{
						MaxV_L = i;//row number
						MaxV_H = j;//column number
						Number = MaxV_H * dimension_0 + MaxV_L + 1;//порядковый номер нашего числа
						Console.WriteLine($"Индекс максимального значения: {i}, {j}\nПорядковый номер максимального значения: {Number}");
						Console.ReadKey();
					}
				}
			}
			Console.ReadKey();
		}*/

	}
	struct Account
	{
		private string log;
		private string pw;

		Account(int LP) //setting login and pw
		{
			log = "1";
			pw = "1234";
		}

		public void LP(string UserLog, string UserPw)
		{
			string[] LP_arr = new string[2];
			string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			string fileName = "Accounts_base.txt";

			log = UserLog;
			pw = UserPw;

			LP_arr[0] = log;
			LP_arr[1] = pw;


				if (File.Exists(fileName))
				{
					using (StreamWriter sw = new StreamWriter(new FileStream(fileName, FileMode.Append, FileAccess.Write)))
					{
						
						sw.WriteLine($"login: {LP_arr[0]} , password: {LP_arr[1]}");
						sw.WriteLine("Дата создания учётной записи: "+DateTime.Now+ "\n");
						sw.Flush();
						sw.Close();
					}
				}
				else
				{
					StreamWriter accBase = new StreamWriter(fileName, false, Encoding.UTF8);
					
					accBase.WriteLine($"login: {LP_arr[0]} , password: {LP_arr[1]}");
					accBase.WriteLine("Дата создания учётной записи: " + DateTime.Now + "\n");
					accBase.Flush();
					accBase.Close();
				}

						
		}
	}
}
	

