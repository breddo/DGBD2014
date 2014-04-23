using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromedioDeLLuvia1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio Nº1: Calculo días de vida");
            Console.WriteLine("***********************************");
            int milimetros = 0;
            int suma = 0;
            Console.Write("ingrese los milimetros de lluvia para el mes enero: ");
            milimetros = int.Parse(Console.ReadLine());
            suma = suma + milimetros;
            Console.Write("ingrese los milimetros de lluvia para el mes febrero: ");
            milimetros = int.Parse(Console.ReadLine());
            suma = suma + milimetros;
            Console.Write("ingrese los milimetros de lluvia para el mes marzo: ");
            milimetros = int.Parse(Console.ReadLine());
            suma = suma + milimetros;
            Console.Write("ingrese los milimetros de lluvia para el mes abril: ");
            milimetros = int.Parse(Console.ReadLine());
            suma = suma + milimetros;
            Console.Write("ingrese los milimetros de lluvia para el mes mayo: ");
            milimetros = int.Parse(Console.ReadLine());
            suma = suma + milimetros;
            Console.Write("ingrese los milimetros de lluvia para el mes junio: ");
            milimetros = int.Parse(Console.ReadLine());
            suma = suma + milimetros;
            Console.Write("ingrese los milimetros de lluvia para el mes julio: ");
            milimetros = int.Parse(Console.ReadLine());
            suma = suma + milimetros;
            Console.WriteLine("El total de precipitaciones en ml es: " + suma);
            Console.WriteLine("El promedio de precipitaciones en ml es: " + (suma / 6));
            Console.ReadKey();
        }
    }
}
