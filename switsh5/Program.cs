using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switsh5
{
    class Program
    {
        static void Main(string[] args)
        //viajes
        {
            int h, g = 0;
            string c;

            Console.Write("Ingresa el tipo de camión: ");
            c = Console.ReadLine();

            Console.Write("Ingresa la cantidad de horas conducidas: ");
            h = Convert.ToInt32(Console.ReadLine());


            switch (c)
            {
                case "Q":
                    Console.Write("Ingrese las toneladas de quimicos: ");
                    int ton = Convert.ToInt32(Console.ReadLine());
                    g = (50 * h) + 1000 + (500 * ton);
                    break;
                case "P":
                    Console.Write("Ingrese la cantidad de personas: ");
                    int per = Convert.ToInt32(Console.ReadLine());
                    g = (50 * h) + 1000 + (200 * per);
                    break;
                case "M":
                    Console.Write("Ingrese las toneladas de mercancia: ");
                    int tm = Convert.ToInt32(Console.ReadLine());
                    g = (50 * h) + 1000 + (400 * tm);
                    break;

            }

            Console.WriteLine("La ganancia total del chofer es: " + g);

            Console.ReadKey();

        }
    }
}
