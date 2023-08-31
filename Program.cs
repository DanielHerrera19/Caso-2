using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string TI;
            int TA;
            double P;
            int K;
            double GA;

            Console.WriteLine("Tipo de la uva: A o B ");
            TI = Console.ReadLine();
            Console.WriteLine("Tamaño de la uva: 1 o 2 ");
            TA = int.Parse(Console.ReadLine());
            Console.WriteLine("Precio: ");
            P = double.Parse(Console.ReadLine());
            Console.WriteLine("Cuantos kilos: ");
            K = int.Parse(Console.ReadLine());

            if (TI == "A")
            {
                if (TA == 1)
                {
                    P = P + 2.04;
                }
                else if (TA == 2)
                {
                    P = P + 3.04;
                }
            }
            else if (TI == "B")
            {
                if (TA == 1)
                {
                    P = P - 3.04;
                }
                else if (TA == 2)
                {
                    P = P - 0.50;
                }
            }

            GA = P * K; 

            Console.WriteLine("La ganancia obtenida es: " + GA);
        }
    }
}