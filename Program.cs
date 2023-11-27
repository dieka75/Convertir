using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double gradosAr, radianes, pi = 3.14159;
            Console.Write("Ingresa los grados: ");
            gradosAr = Convert.ToDouble(Console.ReadLine());

            radianes = Convertir(gradosAr);

            Console.WriteLine("{0}° equivalen a {1} Radianes", gradosAr, radianes); 

        }
        static double Convertir(double gradosPa)
        {
            double radianes;

            radianes = gradosPa * Math.PI / 180;
            return radianes;

        }
    }
}
