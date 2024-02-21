using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class _2
    {
        static double[] input()
        {
            double[] num = new double[2];
            double a, b;
            a = Int64.Parse(Console.ReadLine());
            b = Int64.Parse(Console.ReadLine());
            num[0] = a;
            num[1] = b;
            return num;
        }
        static double[] PS(double[] num1)
        {
            double[] num2 = new double[2];
            double P, S;
            P = 2 * num1[0] + 2 * num1[1];
            S = num1[0] * num1[1];
            num2[0] = P;
            num2[1] = S;
            return num2;
        }
        static void Main(string[] args)

        {
            double[] finish = new double[2];
            double max = -100;
            for (int i = 0; i < 3; i++)
            {
                finish = input();
                finish = PS(finish);
                Console.WriteLine(finish[0]);
                if (finish[0] > 7 && finish[0] < 15)
                {
                    Console.WriteLine($" номер:{i + 1}");
                }
                if (finish[1] > max)
                {
                    max = finish[1];
                }
            }
            Console.WriteLine(max);
        }
    }
}
