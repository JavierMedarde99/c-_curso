// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;


namespace Dia3
{
    class Program
    {

        // NivelDeAcceso - (static) - TipoDeRetorno - NombreDelMetodo - (Parametro1,Parametro2...) 
        public static void EscribeAlgo()
        {
            Console.WriteLine("Yo naci en un metodo");

        }

        public static void EscribeAlgoEspecifico(string miTexto)
        {
            Console.WriteLine(miTexto);
        }

        public static int Sumar(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiplica(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Dividir(int num1, int num2)
        {
            return num1 / num2;
        }

        //desafio 1
        public static void Saludar(string nombreAmigo)
        {
            Console.WriteLine("¡Hola " + nombreAmigo + " buen dia!");
        }

        public static int Calcular()
        {
            Console.WriteLine("Por favor, ingresa un numero");
            string numero1Input = Console.ReadLine();
            Console.WriteLine("Por favor, ingresa otro numero");
            string numero2Input = Console.ReadLine();

            int num1Input = int.Parse(numero1Input);
            int num2Input = int.Parse(numero2Input);
            int resultado = num1Input + num2Input;
            return resultado;
        }

        static void Main(String[] arg)
        {

            EscribeAlgo();
            Console.WriteLine(Sumar(15, 32));
            Console.WriteLine(Multiplica(15, 32));
            Console.WriteLine(Dividir(15, 32));

            Saludar("Juan");
            Saludar("Pepe");
            Saludar("Antonio");

            String input = Console.ReadLine();
            Console.WriteLine(input);

            Console.WriteLine(Calcular());


            Console.WriteLine("Porfavor ingresa un numero");
            string valorIngresado = Console.ReadLine();

            try
            {
                int valorComoInt = int.Parse(valorIngresado);
            }
            catch (FormatException)
            {
                Console.WriteLine("El formato del valor ingresado es incorrecto");
            }
            catch (OverflowException)
            {
                Console.WriteLine("El numero ingresado es demasiado largo o demasiado corto");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("No se ha ingresado ningun valor");
            }
            finally
            {
                Console.WriteLine("Esta frase aparecera pase lo que pase");
            }

            int num1New = 5;
            int num2New = 0;
            int resultado;

            try
            {
                resultado = num1New / num2New;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("No se puede dividir por cero");
            }

            //operadores
            int num1 = 5;
            int num2 = 3;
            int num3;

            num3 = -num1;
            Console.WriteLine("El valor negativo de num1 es " + num3);

            bool haySol = true;
            Console.WriteLine("Hay sol? " + !haySol);

            //operador de adicion

            int num = 0;
            num++;
            Console.WriteLine("num es " + num);
            Console.WriteLine("num es " + num++);
            Console.WriteLine("num es " + num);

            //operadores de sustraccion

            num--;
            Console.WriteLine("num es " + num);
            Console.WriteLine("num es " + --num);
            Console.WriteLine("num es " + num);

            //operadores Matematicos

            int resultado2 = num1 + num2;
            Console.WriteLine("El resultado de {0} + {1} es igual a {2}",num1,num2,resultado2);
            resultado2 = num1 - num2;
            Console.WriteLine("El resultado de {0} - {1} es igual a {2}",num1,num2,resultado2);
            resultado2 = num1 * num2;
            Console.WriteLine("El resultado de {0} * {1} es igual a {2}",num1,num2,resultado2);
            resultado2 = num1 / num2;
            Console.WriteLine("El resultado de {0} / {1} es igual a {2}",num1,num2,resultado2);
            resultado2 = num1 % num2;
            Console.WriteLine("El resultado de {0} % {1} es igual a {2}",num1,num2,resultado2);

            //operadores relacionales

            bool esMenor;
            esMenor = num1 < num2;
            Console.WriteLine("El resultado de {0} < {1} es igual a {2}",num1,num2,esMenor);

            bool esIgual;
            esIgual = num1 == num2;
            Console.WriteLine("El resultado de {0} == {1} es igual a {2}",num1,num2,esIgual);

            esIgual = num1 != num2;
            Console.WriteLine("El resultado de {0} != {1} es igual a {2}",num1,num2,esIgual);

            //operadores condicionales
            //Y

            bool esMenorYSoleado;

            esMenorYSoleado = esMenor && haySol;
            Console.WriteLine("El resultado de {0} && {1} es igual a {2}",esMenor,haySol,esMenorYSoleado);

            //O

            
            esMenorYSoleado = esMenor || haySol;
            Console.WriteLine("El resultado de {0} && {1} es igual a {2}",esMenor,haySol,esMenorYSoleado);

            Console.Read();
        }
    }
}