// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace Dia13
{
    class Program{

        public delegate double HacerCalculo(double x, double y);
        public delegate int Calculos(int i);

        public delegate bool Comparacion(int i, Numero n);

        public static double Suma(double a, double b){
            System.Console.WriteLine("A+B es : {0}",a+b);
            return a+b;
        }

        public static double Division(double a, double b){
            System.Console.WriteLine("A/B es : {0}",a/b);
            return a/b;
        }

        public static double Resta(double a, double b){
            System.Console.WriteLine("A-B es : {0}",a-b);
            return a-b;
        }

        public delegate string ObetenerDelegadoTexto(string nombre);
        static void Main(String[] arg){
            HacerCalculo miSuma = Suma;
            //miSuma(5.0,5.0);
            HacerCalculo miDivision = Division;
            //miDivision(5.0,5.0);

            HacerCalculo calculoMultiple = miSuma + miDivision;
            calculoMultiple += Resta;
            calculoMultiple -= miSuma;
            calculoMultiple(3.2,3.2);

            //Metodos anonimos
            ObetenerDelegadoTexto miDelegado = delegate(string nombre){
                return "Hola, "+ nombre;
            };
            System.Console.WriteLine(miDelegado("Fede"));

            Mostar(miDelegado);

            HacerAlgo();

            //Eventos
            var archivo = new Archivo(){ Titulo = "Archivo 1"};
            var asistenteDescarga = new AsistenteDescargar(); //emisor
            var servicioDesempacar = new ServicioDesempacar(); //Receptor
            var servicioNotificacion = new ServicioNotificacion(); //Receptor

            asistenteDescarga.ArchivoDescargado += servicioDesempacar.EnArchivoDescargado;
            asistenteDescarga.ArchivoDescargado += servicioNotificacion.EnArchivoDescargado;

            asistenteDescarga.Descarga(archivo);

            System.Console.Read();
        }

        public class ServicioNotificacion{
            public void EnArchivoDescargado(object fuente,ArchivoEventArgs e){
                System.Console.WriteLine("Informamos que el archivo"+e.Archivo.Titulo+" se ha terminado de descargar");
            }
        }

        public class ServicioDesempacar{
            public void EnArchivoDescargado(object fuente,ArchivoEventArgs e){
                System.Console.WriteLine("ServicioDesempacar: desempacando el archivo "+ e.Archivo.Titulo);
            }
        }

        public static void HacerAlgo()
        {
            Calculos mate = new Calculos(PorDiez);
            Console.WriteLine(mate(8));

            List<int> lista = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            List<int> numerosPares = lista.FindAll(delegate (int i)
            {
                return (i % 2 == 0);

            });

            foreach(int par in numerosPares)
            {
                Console.WriteLine(par);
            }


            List<int> numerosImpares = lista.FindAll(i => i % 2 == 1);
                numerosImpares.ForEach(i =>
                {
                    Console.WriteLine("Numero impar: ");
                    Console.WriteLine(i);
                }
                
                );

            mate = new Calculos(x => x * x * x);
            Console.WriteLine(mate(8));

            Comparacion comp = (a, Numero) => a == Numero.n;
            Console.WriteLine(comp(5, new Numero { n = 5 }));
        }
        
        public static int Sumar(int a, int b)
        {
            return a + b;
        }

        public static int Cuadrado(int i)
        {
            return i * i;

        }

        public static int PorDiez(int i)
        {
            return i * 10;
        }
        
        static void Mostar(ObetenerDelegadoTexto midelegado){
            System.Console.WriteLine(midelegado("Mundo"));
        }

        public static void DecirHola(){
            System.Console.WriteLine("Hola");
        }
    }

    public class Numero
    {
        public int n { get; set; }
    }

    }

