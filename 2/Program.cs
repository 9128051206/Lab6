using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine(); 
            string reverseStr = ""; 
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverseStr += str[i]; 
            }
            if (str == reverseStr)
                Console.WriteLine("Введенная строка является палиндромом.");
            else
                Console.WriteLine("Введенная строка не является палиндромом.");
            Console.ReadKey();
        }
    }
}
