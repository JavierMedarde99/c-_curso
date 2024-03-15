// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace Dia2
{
    class Program{
        static void Main(String[] arg){
            // change console
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Clear();

            // number variable
            int num3,num4;
            int num1 = 13;
            int num2 = 5;
            int sum = num1 + num2;

            double d1 = 3.2;
            double d2 = 1.337;
            double sumd = d1 + d2;
            double sumd2 = d1 + num2;

            float f1 = 3.5f;

            Console.WriteLine("La suma de "+ num1 + " mas " + num2 + "da como resultado " + sum);
            Console.WriteLine("La suma de "+ d1 + " mas " + d2 + "da como resultado " + sumd);
            Console.WriteLine("La suma de "+ d1 + " mas " + num2 + "da como resultado " + sumd2);

            // String

            string MiNombre = "Javi";

            string mensaje ="Mi nombre es " + MiNombre;
            string mensMay = mensaje.ToUpper();
            string mensMin = mensaje.ToLower();
            
            Console.WriteLine(mensaje);
            Console.WriteLine(mensMay);
            Console.WriteLine(mensMin);
        

            //Conversion Explicita
            
            double miDouble = 13.37;
            int miInt;

            miInt = (int) miDouble;

            //Conversion Implicita

            int num = 123456;
            long numg = num;

            float miFloat = 13.37F;
            double miNuevoDouble = miFloat;

            //Conversion de tipo
            string miString = miDouble.ToString();


            Console.WriteLine(miInt);
            Console.WriteLine(numg);
            Console.WriteLine(miString);

            //parsing

            string miStringP = "15";
            string miSegundoString = "10";

            string resultado = miStringP + miSegundoString;

            int num1P = Int32.Parse(miStringP);
            int num2P = Int32.Parse(miSegundoString);

            int resultado2 = num1P + num2P;
            Console.WriteLine(resultado);
            Console.WriteLine(resultado2);

            //desafio 1

            string miStringD;
            Console.WriteLine("Porfavor ingrese su nombre:");
            miStringD = Console.ReadLine();
            string miStringDMayuscula = String.Format("En Mayusculas es {0}",miStringD.ToUpper());
            string miStringDMinuscula = String.Format("En Minuscula es {0}",miStringD.ToLower());
            string miStringDSinEspacio = String.Format("Sin espacio es {0}",miStringD.Trim());
            string miStringDSubString = String.Format("Sin espacio es {0}",miStringD.Substring(3));
            Console.WriteLine(miStringDMayuscula);
            Console.WriteLine(miStringDMinuscula);
            Console.WriteLine(miStringDSinEspacio);
            Console.WriteLine(miStringDSubString);


            //desafio 2
             
            Console.WriteLine("Porfavor ingrese un texto:");
            string miStringD2 = Console.ReadLine();

            Console.WriteLine("Porfavor ingrese uns letra:");
            char miStringD3= Console.ReadLine()[0];

            int buscarIndice = miStringD2.IndexOf(miStringD3);

            Console.WriteLine("el indice del caracter {0} en el texto es {1}",miStringD3.ToString(),buscarIndice.ToString());
            
            //desafio 3

            Console.WriteLine("Profavor ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Profavor ingrese su apellido: ");
            string apellido = Console.ReadLine();

            string nombreCompleto = String.Concat(nombre," ",apellido);
            Console.WriteLine("El nombre completo es {0}",nombreCompleto);

            //Contantes
            const double PI = 3.14;
            const int SEMANAS = 52, MESES = 12;
            const int DIAS = 365;
            const string nacimiento = "11.12.1999";

            Console.WriteLine("Mi nacimiento fue el: {0}",nacimiento);
            Console.Read();
            
        }
    }
}