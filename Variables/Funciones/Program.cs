﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            Show();
            Sum(1,2);
        }

        static void Sum(int num1, int num2)
        {
            int num3 = num1 + num2;
            Console.WriteLine(num3);
        }
        static void Show()
        {
            Console.WriteLine("Hola me imprimo desde función");
        }
    }
}
