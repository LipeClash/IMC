using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("qual e meu IMC");
            Console.WriteLine("\n");

            double Metros1 = 1.70 ;
            double Metros2 = 1.70 ;
            double Multiplicaraltura = Metros1 * Metros2;
            double Divisãodopeso = 57 / Multiplicaraltura;

            Console.WriteLine($"{Metros1} * {Metros2} = {Multiplicaraltura.ToString("F")}");
            Console.WriteLine($"{57} / {Multiplicaraltura.ToString("F")} = {Divisãodopeso.ToString("F")} = IMC");
            Console.WriteLine("\n");

            Console.WriteLine("Altura (m)..: 1,70");
            Console.WriteLine("Peso (kg)...: 57");
            Console.WriteLine("\n");
            Console.WriteLine("IMC: 19,72 kg/m²");

            

        }
    }
}
