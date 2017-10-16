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
            var americanexpres= (34,37);
            var amexpres =  Convert.ToBoolean(americanexpres);
            var MasterCard = (51, 52, 53, 54, 55);
            var resMast =  Convert.ToBoolean(MasterCard);
            int visa = 4;
            var resvisa =  Convert.ToBoolean(visa);
            int uno = 0;
            var cero =  Convert.ToBoolean(uno);
            int n = 2; 
            String un = numeroTarjeta.Substring(0,1);
            String dos = numeroTarjeta.Substring(1,2);
            String tres = numeroTarjeta.Substring(2,3);
            String cuatro = numeroTarjeta.Substring(3,4);
            String cinco = numeroTarjeta.Substring(4,5);
            String seis = numeroTarjeta.Substring(5,6);
            String siete = numeroTarjeta.Substring(6,7);
            String ocho = numeroTarjeta.Substring(7,8);
            String nueve = numeroTarjeta.Substring(9,10);
            String dies = numeroTarjeta.Substring(10,11);
            String once = numeroTarjeta.Substring(11,12);
            String doce = numeroTarjeta.Substring(12,13);
            String trece = numeroTarjeta.Substring(13,14);
            String catorese = numeroTarjeta.Substring(15,16);
            String quince = numeroTarjeta.Substring(16);

            String substring = numeroTarjeta.Substring(0,1);
            var Sub =  Convert.ToBoolean(substring);
            String Mas = numeroTarjeta.Substring(0,2);
            var MAS =  Convert.ToBoolean(Mas);
            String Amex = numeroTarjeta.Substring(0,2); 
            var Am = Convert.ToBoolean(Amex);
            if(Sub = resvisa){
            Console.WriteLine("tu targeta es: Visa");
            int num = Convert.ToInt32(dos);
            var Xd= num * n;
            int num1 = Convert.ToInt32(cuatro);
            var Xd1= num1 * n;
            int num2 = Convert.ToInt32(seis);         
            var Xd2= num2*n;
            int num3 = Convert.ToInt32(ocho);
            var Xd3=num3*n;
            int num4 = Convert.ToInt32(dies);
            var Xd4= num4*n;
            int num5 = Convert.ToInt32(doce);
            var Xd5= num5*n;
            int num6 = Convert.ToInt32(catorese);
            var Xd6= num6*n;
            int num7 = Convert.ToInt32(quince);
            var Xd7= num7*n;
            var Xdu=Xd+Xd1+Xd2+Xd3+Xd4+Xd5+Xd6+Xd7;
            var Xdt=uno+tres+cinco+siete+nueve+once+trece;
            String final = Xdt.Substring(1);
            var Final =  Convert.ToBoolean(final);
            if(cero=Final){
               Console.WriteLine("Tu Targeta es lejitima");
                }
            else{
               Console.WriteLine("Tu Targeta es falsa");
            }
            }
            else{
            if(MAS=resMast){
            Console.WriteLine("Tu Targeta es: MasterCard");
            int num = Convert.ToInt32(dos);
            var Xd= num * n;
            int num1 = Convert.ToInt32(cuatro);
            var Xd1= num1 * n;
            int num2 = Convert.ToInt32(seis);         
            var Xd2= num2*n;
            int num3 = Convert.ToInt32(ocho);
            var Xd3=num3*n;
            int num4 = Convert.ToInt32(dies);
            var Xd4= num4*n;
            int num5 = Convert.ToInt32(doce);
            var Xd5= num5*n;
            int num6 = Convert.ToInt32(catorese);
            var Xd6= num6*n;
            int num7 = Convert.ToInt32(quince);
            var Xd7= num7*n;
            var Xdu=Xd+Xd1+Xd2+Xd3+Xd4+Xd5+Xd6+Xd7;
            var Xdt=uno+tres+cinco+siete+nueve+once+trece;
            String final = Xdt.Substring(1);
            var Final =  Convert.ToBoolean(final);
            if(MAS=Final){
                Console.WriteLine("Tu Targeta es lejitima");
            }
            else{
                Console.WriteLine("Tu Targeta es falsa");
            }
            }
            else{
            if(Am=amexpres){
            Console.WriteLine("Tu Targeta es: American Express");
             int num = Convert.ToInt32(dos);
            var Xd= num * n;
            int num1 = Convert.ToInt32(cuatro);
            var Xd1= num1 * n;
            int num2 = Convert.ToInt32(seis);         
            var Xd2= num2*n;
            int num3 = Convert.ToInt32(ocho);
            var Xd3=num3*n;
            int num4 = Convert.ToInt32(dies);
            var Xd4= num4*n;
            int num5 = Convert.ToInt32(doce);
            var Xd5= num5*n;
            int num6 = Convert.ToInt32(catorese);
            var Xd6= num6*n;
            int num7 = Convert.ToInt32(quince);
            var Xd7= num7*n;
            var Xdu=Xd+Xd1+Xd2+Xd3+Xd4+Xd5+Xd6+Xd7;
            var Xdt=uno+tres+cinco+siete+nueve+once+trece;
            String final = Xdt.Substring(1);
            var Final =  Convert.ToBoolean(final);
            if(MAS=Final){
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
            //while (numeroTarjeta = visa) 
            //{
            //Console.WriteLine("Current value of n is {0}", chars);
            //n++;
            //}
            //Console.WriteLine(numeroTarjeta.TipoDeTarjeta());
        //}

    }
    }
}
