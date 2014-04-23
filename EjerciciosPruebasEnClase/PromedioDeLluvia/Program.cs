using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromedioDeLluvia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio Nº2: Precipitaciones");
            Console.WriteLine("***********************************");
            int milimetros = 0;
            int suma = 0;
            int mes = 1;
            int promedio = 0;
            do
                {
                    Console.Write("ingrese los milimetros de lluvia para el mes " + mes +": ");
                    milimetros = int.Parse(Console.ReadLine());
                    suma = suma + milimetros;
                    mes ++;
                }
                while (mes < 7);
            Console.WriteLine("El total de milimetros es " + suma);
            promedio = (suma / 6);
            Console.WriteLine("El promedio de pricipitaciones es: " + promedio);
            Console.ReadKey();
        }
    }
}