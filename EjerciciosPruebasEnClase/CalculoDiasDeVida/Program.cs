using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculoDiasDeVida
{
    class Program
    {
        static void Main(string[] args)
        {
            # region declaramos variables
                string nombre;
                byte edad;
                int dias;
            # endregion
            Console.WriteLine("Ejercicio Nº1: Calculo días de vida");
            Console.WriteLine("***********************************");
            //Utilizamos Write para imprimir sin el enter al final
            Console.Write("ingrese su nombre: ");
            //Le asignamos a la variable nombre lo que escriba el usuario
            nombre = Console.ReadLine();

            Console.Write("ingrese su edad: ");
            //Utilizamos el metodo ToByte para convertir el texto que entrega ReadLine en byte (numero)
            edad = Convert.ToByte(Console.ReadLine());
            dias = edad * 365;

            //Imprimimos
            Console.WriteLine("Hola " + nombre);
            Console.WriteLine("Los Días de vida aproximados son: " + dias.ToString());
            Console.ReadLine();
        }
    }
}
