using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Gaitov_D_PR_32_zd_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string _file = "input.txt";
                string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                string rez = "";

                if (File.Exists(_file))
                {
                    string[] A = File.ReadAllLines(_file);

                    for (int i = 0; i < A[0].Length; i++)
                    {
                        int max = -1;
                        foreach (string line in A)
                        {
                            if (max <= Alphabet.IndexOf(line[i])) max = Alphabet.IndexOf(line[i]);
                        }
                        rez += Alphabet[max];
                    }

                    Console.WriteLine(rez);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Файл не найден");
                    Console.ReadKey();
                }
            }
            catch
            {
                Console.WriteLine("Ошибка в ходе выполнения программы");
                Console.ReadKey();
            }
        }
    }
}
