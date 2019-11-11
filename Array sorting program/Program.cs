using System;

namespace Array_sorting_program
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = new int[10];
            Console.WriteLine("Введите 10 чисел");
            for(int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine("{0}- e число:", i + 1);
                mass[i] = Int32.Parse(Console.ReadLine());
            }
            int sort;
            for(int i = 0; i < mass.Length -1; i++)
            {
                for(int j = i + 1; j < mass.Length; j++)
                {
                    if(mass[i] > mass[j])
                    {
                        sort = mass[i];
                        mass[i] = mass[j];
                        mass[j] = sort;

                    }
                }

            }
            Console.WriteLine("Вывод отсортированного массива");
            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine(mass[i]);
            }
            Console.ReadLine();
        }
    }
}
