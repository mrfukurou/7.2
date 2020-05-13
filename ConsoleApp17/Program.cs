using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите строку: ");
                StringBuilder a = new StringBuilder(Console.ReadLine());
                string str = a.ToString();
                if (!String.IsNullOrWhiteSpace(str))
                {
                    Console.Write("Слова, которые встречаются один раз в предложении: ");
                    var s = str.ToLower().Split(new[] { ' ','.', ',', '?', '!', ':', ';' }, StringSplitOptions.RemoveEmptyEntries)
                    .GroupBy(x => x)
                    .Where(x => x.Count() == 1)
                    .Select(x => x.Key);
                    foreach (var rez in s) Console.Write( rez + ",");
                    Console.WriteLine();
                }
                else
                {
                throw new Exception();
                }
            }
            catch { Console.WriteLine("Некорректный ввод! "); }
        }

	}
}
 
