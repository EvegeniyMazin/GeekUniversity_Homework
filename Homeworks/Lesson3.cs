using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks
{    struct Complex
    {
        public double i;
        public double re;

        public Complex Multiply(Complex x)
        {
            Complex multi;
            multi.i = i * x.i;
            multi.re = re * x.re;
            return multi;
        }
        public Complex Division(Complex x)
        {
            Complex division;
            division.i = i/ x.i;
            division.re = re / x.re;
            return division;
        }

        public Complex Sum(Complex x)
        {
            Complex summ;
            summ.i = i + x.i;
            summ.re = re + x.re;
            return summ;
        }

        public Complex Subtraction(Complex x)
        {
            Complex subtraction;
            subtraction.i = i - x.i;
            subtraction.re = re - x.i;
            return subtraction;
        }

    }
    class Lesson3
    {
        public void oddSum()
        {
            bool check = true;
            string input;
            int Number = -1;
            int summ = 0;



            while (Number != 0 || !check)
            {
                input = Console.ReadLine();
                check = int.TryParse(input, out Number);

                if (check == true)
                {
                    if (Number > 0 && Number % 2 == 1)
                    {
                        summ += Number;
                    }
                }
                else
                {
                    Console.WriteLine($"Your input was: {input}, please type another number");
                }

            }
            Console.WriteLine($"The summ of odd numbers is = {summ}");
        }
    }
    class Double
    {
        public int num;
        public int denom;

        public void Summ(Double other)
        {
            Console.WriteLine($"{num * other.denom + other.num * denom} | {denom * other.denom}");
        }

        public void Subtraction(Double other)
        {
            Console.WriteLine($"{num * other.denom - other.num * denom} | {denom * other.denom}");
        }

        public void Multi(Double other)
        {
            Console.WriteLine($"{num * other.num} | {denom * other.denom}");
        }

        public void Division(Double other)
        {
            Console.WriteLine($"{num * other.denom} | {denom * other.num}");
        }
    }

}
