using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks
{
	class Lesson2
	{
        public void MinInt(int a, int b, int c)
        //Задание 1 
        {
            Console.WriteLine("Task 1: finding min value.\n>>>>>>>>>>\n");
            int min = a < b ? a : b;
            min = min < c ? min : c;
            Console.WriteLine($"The lowest number among {a} , {b} and {c} is {min}");
            Console.ReadKey();
        }
        public void intLenght(string number)
        //задание 2
        {
            Console.WriteLine("Task 2: finding number length.\n>>>>>>>>>>\n");
            int NumberLength = number.Length;
            Console.WriteLine($"The length of the {number} is {NumberLength}");
            Console.ReadKey();
        }
        public void OddNumbers()
        //Задание 3
        {
            Console.WriteLine("Task 3: finding the sum of odd numbers.\n>>>>>>>>>>\n");
            Console.WriteLine("Write any number. Func will calculate the sum of odd ones. \nTyping zero stops the function.");

            float NumSum = 0;
            bool zero = false;

            while (!zero)
            {
                float Number = Convert.ToSingle(Console.ReadLine());
                if (Number % 2 != 0 && Number > 0)
                {
                    NumSum += Number;
                }
                else if (Number == 0)
                {
                    zero = true;
                }
            }
            Console.WriteLine($"The summ of odd ones is: {NumSum}");
            Console.ReadKey();
        }
        public bool logIn()
        //Задание 4
        {
            int MaxAttempts = 3;
            int CurrentAttempt = 0;
            string TrueLogin = "root";
            string TruePassword = "GeekBrains";
            do
            {
                CurrentAttempt++;

                Console.WriteLine("Enter your Login");
                string Login = Console.ReadLine();

                Console.WriteLine("Enter your Password");
                string Password = Console.ReadLine();

                if (Login == TrueLogin && Password == TruePassword)
                {
                    Console.Clear();
                    Console.WriteLine("Welcome! press any button to proceed");
                    Console.ReadLine();
                    return true;
                }
                else if (Login == TrueLogin)
                {
                    Console.WriteLine("Wrong Password");
                    Console.WriteLine($"{MaxAttempts - CurrentAttempt} attempts  left , please try again");
                }
                else
                {
                    Console.WriteLine("Incorrect Data");
                    Console.WriteLine($"{MaxAttempts - CurrentAttempt} attempts  left , please try again");
                }
            }
            while (CurrentAttempt < MaxAttempts);
            Console.WriteLine("You haave no attempts left.");
            Console.Clear();
            return false;
        }
        //static void main()
        //{
        //    intlenght("182212");
        //    minint(3,5,1);
        //    oddnumbers();
        //    login();
        //}
    }
}
