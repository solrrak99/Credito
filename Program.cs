using System;
using System.Linq;
using System.Collections.Generic;

namespace Credito
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Ingrese el numero de su Tarjeta: ");
            string numeroTarjeta = Console.ReadLine();
            var amexpres= (34,37);
            var MasterCard = (51, 52, 53, 54, 55);
            var visa = 4;
            var uno = 0;
            String Rot = numeroTarjeta.Substring(uno);
            var dos = 1;
            var tre = 2;
            String Rnt = numeroTarjeta.Substring(tre);
            var U = 4;
            String Rat = numeroTarjeta.Substring(U);
            var C = 6;
            String Ret = numeroTarjeta.Substring(C);
            var S = 8;
            String Rrt = numeroTarjeta.Substring(S);
            var O = 10;
            String Rtt = numeroTarjeta.Substring(O);
            var N = 12;
            String Ryt = numeroTarjeta.Substring(N);
            var T = 14;
            String Rut = numeroTarjeta.Substring(T);
            var Y = 16;
            String Rit = numeroTarjeta.Substring(Y);
            var K=3;
            String RYt = numeroTarjeta.Substring(K);
            var X=5;
            String RXt = numeroTarjeta.Substring(X);
            var Z=7;
            String RZt = numeroTarjeta.Substring(Z);
            var G=9;
            String RGt = numeroTarjeta.Substring(G);
            var Ñ=11;
            String RÑt = numeroTarjeta.Substring(Ñ);
            var M=13;
            String RMt = numeroTarjeta.Substring(M);
            var LK=15;
            String RLKt = numeroTarjeta.Substring(LK);

            String substring = numeroTarjeta.Substring(uno);
            String Mas = numeroTarjeta.Substring(uno,dos);
            String Amex = numeroTarjeta.Substring(uno,dos);           
            if(substring = visa){
            Console.WriteLine("tu targeta es: Visa");
            var Xd= Rot * tre;
            var Xd1= Rnt * tre;
            var Xd2= Rat*tre;
            var Xd3=Ret*tre;
            var Xd4= Rrt*tre;
            var Xd5= Rtt*tre;
            var Xd6=Ryt*tre;
            var Xdu=Xd+Xd1+Xd2+Xd3+Xd4+Xd5+Xd6;
            var Xdt=Xdu+RYt+RXt+RZt+RGt+RÑt+RMt;
            if(Xdt=60){
                Console.WriteLine("Tu Targeta es lejitima");
            }
            else{
                Console.WriteLine("Tu Targeta es falsa");
            }
            }
            else{
            if(Mas=MasterCard){
            Console.WriteLine("Tu Targeta es: MasterCard");
            var Xdm= Rot * tre;
            var Xds= Rnt * tre;
            var Xdt= Rat*tre;
            var Xdr=Ret*tre;
            var Xde= Rrt*tre;
            var Xdl= Rtt*tre;
            var Xdf=Ryt*tre;
            var Xdk= XdRut*tre;
            var XdP=Rit*tre;
            var Xdz=Xdm+Xds+Xdt+Xdr+Xde+Xdl+Xdf+XdP+Xdk;
            var Xdp=Xdu+RYt+RXt+RZt+RGt+RÑt+RMt+RLKt;
            if(Xdp=60){
                Console.WriteLine("Tu Targeta es lejitima");
            }
            else{
                Console.WriteLine("Tu Targeta es falsa");
            }
            }
            else{
            if(Amex=amexpres){
            Console.WriteLine("Tu Targeta es: American Express");
            var Xd7= Rot * tre;
            var Xd8= Rnt * tre;
            var Xd9= Rat*tre;
            var Xd10=Ret*tre;
            var Xd11= Rrt*tre;
            var Xd12= Rtt*tre;
            var Xd13=Ryt*tre;
            var Xd14= XdRut*tre;
            var Xdz16=Xd7+Xd8+Xd9+Xd10+Xd11+Xd12+Xd13+Xd14;
            var Xdp17=Xdu+RYt+RXt+RZt+RGt+RÑt+RMt+RLKt;
            if(Xdp17=60){
                Console.WriteLine("Tu Targeta es lejitima");
            }
            else{
                Console.WriteLine("Tu Targeta es falsa");
            }
            }
            else{
            Console.WriteLine("El numero ingresado es incorrecto");
            }
            }
            }
            ///while (numeroTarjeta = visa) 
            //{
            //Console.WriteLine("Current value of n is {0}", chars);
            //n++;
            //}
            //Console.WriteLine(numeroTarjeta.TipoDeTarjeta());
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
