using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Xml;
using System.Text.RegularExpressions;
using System.Threading;



namespace Homeworks
{
	class Homework
	{
		#region Lesson 3
		public void L3_Task1()
        {
            Complex first = new Complex();
            Complex second = new Complex();
            Complex result = new Complex();

            first.i = 11;
            second.i = 8;
            first.re = 3;
            second.re = 1;

            Console.WriteLine(string.Format("Task 1\n"));

            result = first.Division(second);
            Console.WriteLine($"{result.i} , {result.re} (Division)\n");

            result = first.Multiply(second);
            Console.WriteLine($"{result.i} , {result.re} (Multi)\n");

            result = first.Subtraction(second);
            Console.WriteLine($"{result.i} , {result.re} (Subtraction)\n");

            result = first.Sum(second);
            Console.WriteLine($"{result.i} , {result.re} (Summ)\n");
        }

        public void L3_Task2()
        {
            Console.WriteLine("\nTask 2\n");
            Lesson3 task = new Lesson3();
            Console.WriteLine($"Please enter numbers to count \nPress 0 to stop\n");
            task.oddSum();
        }

        public void L3_Task3()
        {
            Console.WriteLine("\nTask 3\n");

            Double task = new Double();
            Double task2 = new Double();

            Console.WriteLine("\nPlease enter first numerator and denumerator");
            task.num = Convert.ToInt32(Console.ReadLine());
                if(task.denom == 0)
                {
                    Console.WriteLine("You can't divide by zero. Please enter different number");
                    task.denom = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
				}

            Console.WriteLine("\nPlease enter second numerator and denumerator");
            task2.num = Convert.ToInt32(Console.ReadLine());
            task2.denom = Convert.ToInt32(Console.ReadLine());
                if (task2.denom == 0)
                {

                    Console.WriteLine("You can't divide by zero. Please enter different number");
                    task2.denom = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                }                
        
            task.Division(task2);
            task.Multi(task2);
            task.Subtraction(task2);
            task.Summ(task2);
        }
        #endregion
        #region lesson 4
        public void L4_Task1()
		{

            ArrayRank1 task1 = new ArrayRank1(20, -10, 10);
            Console.WriteLine("Задание 1\nДля удобства проверки минимальное и максимальные значения массива уменьшены (-10, +10).\nВаш массив из "+ task1.arr.Length + " элементов:\n");
            for (int i = 0; i < task1.arr.Length; i++)
            {
                Console.WriteLine(task1.arr[i]);
            }
            Console.WriteLine("\nколичество пар элементов массива, в которых хотя бы одно число делится на 3 без остатка: "+task1.CountCouples() + "\n");
            Console.ReadKey();
        }
        public void L4_Task2()
		{
            
            int UserLength;
            int UserStartV;
            short UserStep;
            int UserMultiplier;
            Console.WriteLine("Задание 2\nПожалуйста, введите количество значений (длину) массива:");
            UserLength = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nПожалуйста, введите стартовое значение массива:");
            UserStartV = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nПожалуйста, введите шаг изменения каждого последующего значения массива:");
            UserStep = Convert.ToInt16(Console.ReadLine());//не забываем, что третий параметр - шорт
            
            ArrayRank1 test2 = new ArrayRank1(UserLength, UserStartV, UserStep);

            Console.WriteLine($"\n Ваш массив из {test2.arr.Length} элементов, где начальное значение {test2.arr[0]}, с шагом {UserStep} :");
            //выводим элементы массива
            for (int i = 0; i < test2.arr.Length; i++)
            {
                Console.WriteLine(test2.arr[i]);
            }
            Console.ReadKey();
            //выводим элементы массива с методом inverse
            Console.WriteLine("\nПрименяем метод Inverse к массиву:\n");
            test2.Inverse();
            for (int i = 0; i < test2.arr.Length; i++)
            {
                Console.WriteLine(test2.arr[i]);
            }
            Console.ReadKey();
            //выводим элементы массива с методом Multiply
            Console.WriteLine("\nПрименяем метод Multiply к массиву.\nПожалуйста, введите число, на которое будем умножать каждое значение массива:");
            UserMultiplier = Convert.ToInt32(Console.ReadLine());
            test2.Multiply(UserMultiplier);
            for (int i = 0; i < test2.arr.Length; i++)
            {
                Console.WriteLine(test2.arr[i]);
            }
            Console.ReadKey();
            //выводим элементы массива с методом Sum
            Console.WriteLine("\nПрименяем метод Sum к массиву.\nВсе элементы массива будут приведены к положительным значениям для удобства проверки");
            test2.Inverse();
            for (int i = 0; i < test2.arr.Length; i++)
            {
                Console.WriteLine(test2.arr[i]);
            }
            Console.WriteLine($"\nСумма элементов вашего массива: {test2.Sum()}");

            test2.maxCount(test2.arr, UserLength);
            Console.WriteLine($"\nКоличество максимальных значений вашего массива: {test2.MaxCount}");

            Console.ReadKey();
        }
        public void L4_Task3() 
        {
            Account user = new Account();

            string userLog, userPw;
            Console.WriteLine("Задание 3\nЗадайте свой логин: ");
            userLog = Console.ReadLine();
            Console.WriteLine("\nЗадайте свой пароль: ");
            userPw = Console.ReadLine();

            user.LP(userLog, userPw);

            Console.WriteLine("\nВы успешно зарегистрировались! Данные сохранены в Базе данных.");
            
            Console.ReadKey();
        }
        public void L4_Task4()
		{
            int UserLength;
            int UserHeight;
            int UserMaxV;
            Console.WriteLine("Задание 4\nПожалуйста, введите количество значений (длину) двухмерного массива:");
            UserLength = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nПожалуйста, введите высоту массива:");
            UserHeight = Convert.ToInt32(Console.ReadLine());
            
            ArrayRank2 test2 = new ArrayRank2(UserLength, UserHeight, 10, 100);
            Console.WriteLine($"\n Ваш массив из случайных элементов от 10 до 100:");
            //выводим элементы массива
            for (int i = 0; i < UserLength; i++)
            {
                for (int j = 0; j < UserHeight; j++)
                {
                    
                    Console.WriteLine(test2.arr[i,j]);
                }
            }
            
            Console.ReadKey();
                      
            Console.WriteLine($"\nПрименяем метод Sum к массиву.\nСумма элементов вашего массива: {test2.Sum()}");
            Console.ReadKey();

            Console.WriteLine("\nПожалуйста, введите число. Значения массива больше этого числа будут просуммированы:");
            UserMaxV = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nСумма элементов массива, которые больше {UserMaxV} : {test2.SumIf(UserMaxV)}");
            Console.ReadKey();

            Console.WriteLine($"\nМаксимальное из значений элементов массива : {test2.arrMaxV}");
            Console.WriteLine($"\nМинимальное из значений элементов массива : {test2.arrMinV}");
            test2.MaxVIndex();
            Console.WriteLine($"\nИндекс Максимального из значений элементов массива : {test2.MaxV_L} , {test2.MaxV_H}");
            
            int Number = test2.MaxV_H * test2.arr.GetLength(dimension: 0) + test2.MaxV_L + 1;
            Console.WriteLine($"\nОСТОРОЖНО! СЛЕДЮЩИЙ КОНТЕНТ ДЛЯ ОСОБО ИЗВРАЩЕННЫХ ЛЮДЕЙ!:)\nПорядковый номер Максимального из значений элементов массива : {Number} ");

            Console.ReadKey();
        }
		#endregion
		#region lesson 5
        public void L5_Task1A()
		{
            Console.WriteLine("Придумайте ваш логин: от 2 до 10 символов, содержащий только буквы латинского алфавита или цифры, при этом цифра не может быть первой:");
            var userLogin = Console.ReadLine();
            Task1 Task1 = new Task1();
            bool isValid = Task1.IsValidChar(userLogin);
            bool startsWithN = Task1.StartsWithNumber(userLogin);
            bool correctLength = Task1.CorrectLength(userLogin);

            if (!startsWithN && correctLength && isValid == true)
            {
                Console.WriteLine($"\nВаш логин {userLogin} удовлетворяет условиям и принят!");
                Console.ReadKey();
            }
            else { Console.WriteLine($"\nВаш логин {userLogin} не удовлетворяет условиям. Вы ввели недопустимые значения."); Console.ReadKey(); }
            
        }
        public void L5_Task1B()
		{

            Task1 Task1 = new Task1();
            Console.WriteLine("Придумайте ваш логин: от 2 до 10 символов, содержащий только буквы латинского алфавита или цифры, при этом цифра не может быть первой:");
            var userLogin = Console.ReadLine();
            bool isValid = Task1.RegEx(userLogin);
			if (isValid && userLogin.Length>2 && userLogin.Length<10)
			{
                Console.WriteLine($"\nВаш логин {userLogin} удовлетворяет условиям и принят!");
                Console.ReadKey();
            }
            else { Console.WriteLine($"\nВаш логин {userLogin} не удовлетворяет условиям. Вы ввели недопустимые значения."); Console.ReadKey(); }

        }
        public void L5_Task2a()
		{
            Message task2a = new Message();//task 2.a
            Console.WriteLine("Введите ваш текст");
            string userText = Console.ReadLine();
            Console.WriteLine("Введите количество букв. Выведутся слова, содержащие менее этого количества букв");
            int userLength = Convert.ToInt32(Console.ReadLine());
            task2a.UserLength(userText, userLength);


		}
        public void L5_Task2b()
		{
            Message task2b = new Message();//task 2.b
            Console.WriteLine("Введите ваш текст");
            string userText = Console.ReadLine();
            Console.WriteLine("Введите символ. Слова, заканчивающиеся на указанный символ, будут удалены.");
            char userChar = Convert.ToChar(Console.ReadLine());
            task2b.DelIfLastSymbol(userText, userChar);
        }
        public void L5_Task2cd()
		{
            Message task2c = new Message();
            Console.WriteLine("Введите ваш текст");
            string userText = Console.ReadLine();
            task2c.LongestWord(userText);
        }
       
        public void L5_Task3()
		{
            string UserText1;
            string UserText2;
            Console.WriteLine("Таsk3\nВведите первый текст, который вы хотите сравнить");
            UserText1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите второй текст, который вы хотите сравнить с первым");
            UserText2 = Convert.ToString(Console.ReadLine());
            StringsHW task3 = new StringsHW(UserText1, UserText2);
        }
		#endregion
		#region lesson 6
        public void L6_Task1()
		{
            Lesson6 task1 = new Lesson6();
            Console.WriteLine("------------Task 1-------------");
            task1.Table(task1.MyFunc, 3, 2);
            Console.ReadKey();
		}
        public void L6_Task2() 
        {
            Lesson6 task2 = new Lesson6();
            Console.WriteLine("Выберите функцию F1 (введите 1), F2(введите 2), F3(введите 3)");
            int fun = Convert.ToInt32(Console.ReadLine());
            if (fun == 1)
            {
                task2.Task2[0] = task2.F1;
            }
            else if (fun == 2)
            {
                task2.Task2[0] = task2.F2;
            }
            else if (fun == 3)
            {
                task2.Task2[0] = task2.F3;
            }
            else { Console.WriteLine("Такой функции не существует"); }
            double tempMin;
            task2.SaveFunc(task2.Task2[0], "data.bin", -100, 100, 0.5);
            Console.WriteLine(task2.Load("data.bin",out tempMin));
            Console.ReadKey();
        }
        public void L6_Task3()
		{
            Console.WriteLine("CSV файл отсутствует. Задание некорректное.");
		}
        #endregion
    }
	class Program
    {
        static void Main(string[] args)
        {
            Homework task = new Homework();
            #region lesson 2 HW
            /*Lesson2 HW2 = new Lesson2();
             HW2.MinInt(5, 2, 7);
             HW2.intLenght("182212");
             HW2.OddNumbers();
             HW2.logIn();
             */
            #endregion
            #region lesson 3 HW
            //task.L3_Task1();
            //task.L3_Task2();
            //task.L3_Task3();
            #endregion
            #region lesson 4 HW
            //task.L4_Task1();
            //task.L4_Task2();
            //task.L4_Task3();
            //task.L4_Task4();
            #endregion
            #region lesson 5 HW
            //task.L5_Task1A();
            //task.L5_Task1B();
            //task.L5_Task2a();
            //task.L5_Task2b();
            //task.L5_Task2cd();
            //task.L5_Task3();
            #endregion
            #region lesson 6 HW
            //task.L6_Task1();
            //task.L6_Task2();
			#endregion


		}
	}
}
