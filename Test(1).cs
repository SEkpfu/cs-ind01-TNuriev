using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class _1
    {

        static double f(double x)
        {
            if (x <= 3)
            {
                return 7 / 3.0;
            }
            if (x > -3 & x < 3)
            {
                return (-2 + x * x) * Math.Cos(Math.PI * (x - 1) / (2.0 * x));
            }
            else
            {
                return ((x + 3) / (x - 1 / ((x - 1) * (x - 1) * (x - 1)))) * (x / (-2 + x));
            }
        }
        static double lenght(double x, double y)
        {
            return Math.Sqrt(x * x + y * y);
        }
        //static double lenght2(double x1, double y1, double x2, double y2)
        //{
        //    return Math.Sqrt(((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)));
        //}
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во x:");
            int n;
            n = Int32.Parse(Console.ReadLine());
            double x;
            double[] numx = new double[n];
            double[] numy = new double[n];
            int count = 0;
            double max = -1000, z = 0, v = 0;
            for (int i = 0; i < n; i++)
            {
                x = Int64.Parse(Console.ReadLine());
                numx[i] = x;
                numy[i] = f(x);
                if ((numx[i] <= 3 && numx[i] >= 0 && numy[i] <= 6 && numy[i] >= -6 && lenght(numx[i], numy[i]) < 6 && numy[i] <= 3) || (numx[i] >= -3 && numx[i] <= 0 && numy[i] <= 6 && numy[i] >= 0 && numy[i] >= (numx[i] - 3) / 2.0))
                {
                    count++;
                }
                else
                {
                    Console.WriteLine($"не попала {lenght(numx[i], numy[i])}");
                    if (max < lenght(numx[i], numy[i]) && numx[i] > 0 && numy[i] > 0)
                    {
                        max = lenght(numx[i], numy[i]);
                        z = numx[i];
                        v = numy[i];
                    }
                }

            }
            Console.WriteLine($"кол-во {count}");
            Console.WriteLine(z);
            Console.WriteLine(v);
        }
    }
}
