using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Homeworks
{
    class Lesson6
    {
       
        public delegate double Fun(double x, double a);
		#region Task 1
		public void Table(Fun F, double x, double a)
        {
            Console.WriteLine($"{F(x, a):0.00}");
            Console.WriteLine("---------------");
        }

        public double MyFunc(double x, double a)
        {
            return Math.Sin(x) * a;
        }

        public double Sin(double x, double a)
        {
            return x * x * a;
        }
        #endregion
        #region Task 2
        public delegate double DeleteMin(double x);
        public DeleteMin Task2;
        public double F1(double x)
        {
            return x * x - 50 * x + 10;
        }
        public double F2(double x)
        {
            return x * x - 50 * x + 100;
        }
        public double F3(double x)
        {
            return x * x - 50 * x - 10;
        }

        public void SaveFunc(DeleteMin func, string fileName, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(func(x));
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }
        public double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }
       

		#endregion
		

	}
}
