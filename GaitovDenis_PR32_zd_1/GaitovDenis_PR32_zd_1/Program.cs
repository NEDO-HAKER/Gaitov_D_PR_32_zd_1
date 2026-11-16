using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GaitovDenis_PR32_zd_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double[] A = new double[5];

                string line = Console.ReadLine().Trim();

                string[] A_str = line.Split(' ');

                int _i = 0;
                foreach (string str in A_str)
                {
                    if (!string.IsNullOrEmpty(str)) A[_i] = double.Parse(str);

                    if (A[_i] < 0) { Console.WriteLine("Введенные данные не могут быть отрицательными"); Console.ReadKey(); return; }

                    _i++;
                }

                if (A[1] == 0 || A[3] == 0) { Console.WriteLine("В веденных данных есть деление на 0"); Console.ReadKey(); return; }

                for (int i = 0; i < 5; i++)
                {
                    if (A[i] == 0) { Console.WriteLine("Введены не все значения"); Console.ReadKey(); return; }
                }

                double first_brother = Math.Ceiling((Double)(A[0] / A[1]));
                double second_brother = Math.Ceiling((Double)(A[0] / A[3]));

                double time_first_brother = first_brother * A[2];
                double time_second_brother = second_brother * A[4];

                if (time_first_brother > time_second_brother) Console.WriteLine(time_second_brother);
                else Console.WriteLine(time_first_brother);
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Ошибка в ходе выполнения программы");
                Console.ReadKey();
            }
        }                
    }
}
