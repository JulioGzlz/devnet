using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
            

        {
            double a, b, resul;
            Console.WriteLine("Ingrese su primer digito ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su segundo digito ");
            b = double.Parse(Console.ReadLine());

            resul = a + b;

            Console.WriteLine("El resultado de su operacion es: "+resul);
        }
    }
}
