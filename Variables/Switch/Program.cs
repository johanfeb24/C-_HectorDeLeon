using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = 1;
            switch (op)
            {
                case 1:
                    Console.WriteLine("Seleccionaste 1");
                    break;
                case 2:
                    Console.WriteLine("Seleccionaste el 2");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Selecdionaste la opción 3 o 4");
                    break;
                default:
                    Console.WriteLine("Invalido");
                    break;
            }

        }
    }
}
