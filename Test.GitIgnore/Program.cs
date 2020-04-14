using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите строку (содержит не менее одного символа 'w'): ");
            string a = Console.ReadLine();
            var count = a.Count(s => s == 'w');
            Console.WriteLine("Проверка строки, содержащей символ 'w', от 1 до 3 раз:");
            Console.WriteLine(count >= 1 && count <= 3);
            
        }
    }
}
