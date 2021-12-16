﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string startString = Console.ReadLine();
            startString = startString.Trim();
            string[] stringArray = startString.Split(' ');
            int maxlen = 0, index = 0;
            for (int i = 0; i < stringArray.Length; i++)
            {
                if (stringArray[i].Length > maxlen)
                {
                    maxlen = stringArray[i].Length;
                    index = i;
                }
            }
            Console.Write("Самое длинное слово: {0}", stringArray[index]);
            Console.ReadLine();

        }
    }
}
    
