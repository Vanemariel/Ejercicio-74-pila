using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercico73
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> Pila = new Stack<string>();


            Console.WriteLine("¿hola cual es tu nombre");
            string nombre = Console.ReadLine();//puedo usar mucho texto
            Console.WriteLine("¿" + nombre + "ingresa tu apellido?");
            string cadena = Console.ReadLine();
            Console.WriteLine("¿ cual es tu calle de donde vivis");
            string direccion = Console.ReadLine();

            Pila.Push(nombre);
            Pila.Push(cadena);
            Pila.Push(direccion);

            int Max = Pila.Count;

            for (int i = 0; i < Max; i++)
            {
                string Dato = Pila.Pop();
                Console.WriteLine(Dato);
            }
        }
    }
}