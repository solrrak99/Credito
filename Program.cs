using System;
using System.Linq;
using System.Collections.Generic;

namespace Credito
{
    class Program
    {
        static void Main(string[] args)
        {
            
            System.Console.Write("Número: ");
            string numeroTarjeta = Console.ReadLine();
            
            Console.WriteLine(numeroTarjeta.TipoDeTarjeta());
        }

    }

    public static class ValidarTarjeta
    {
        public static string TipoDeTarjeta(this string input)
        {
            return "VISA O MASTERCARD O AMEX O INVALIDA";
        }
    }
}
