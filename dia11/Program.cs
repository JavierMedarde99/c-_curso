// See https://aka.ms/new-console-template for more information
using System;
using System.IO;

namespace Dia11
{
    class Program{
        static void Main(String[] arg){
            var autos = new List<Auto> {
                new Audi(200,"azul","a4"),
                new Bmw(250,"rojo","m3")
            };

            foreach (var auto in autos)
            {
                auto.Reparar();
            }

            Auto auto1 = new Bmw(200,"negro","z3");
            Auto auto2 = new Audi(100,"verde","a3");

            auto1.SetearAutoInfo(1234,"Juan Garay");
            auto2.SetearAutoInfo(1235,"Milena Rios");

            auto1.LeerAutoInfo();
            auto2.LeerAutoInfo();

            auto1.MostrarDetalles();
            auto2.MostrarDetalles();

            Bmw bmwM5 = new Bmw(330,"blanco","M5");
            bmwM5.MostrarDetalles();

            Auto autoB = (Auto)bmwM5;
            autoB.MostrarDetalles();

            M3 miM3 = new M3(260,"rojo","M3Super turbo");

            miM3.Reparar();


            //leer texto completo
            string texto = System.IO.File.ReadAllText(@"/home/javi/cSharp/cShart-curso/dia11/textos/LeerArchivoTexto.txt");
            System.Console.WriteLine(texto);

            //leer de a lines
            string[] lineas = System.IO.File.ReadAllLines(@"/home/javi/cSharp/cShart-curso/dia11/textos/LeerArchivoTexto.txt");
            foreach (string linea in lineas)
            {
                System.Console.WriteLine("\t"+linea);
            }
            
            //metodo 1 crear file
            string[]lineas2 = {"Primero 250","Segund0 242","Tercer 240"};
            File.WriteAllLines(@"/home/javi/cSharp/cShart-curso/dia11/textos/Puntajes.txt",lineas2);

            //metodo 2 crear file
            System.Console.WriteLine("Porfavor ingrse el nombre del archivo");
            string nombreArchivo = Console.ReadLine();

            System.Console.WriteLine("Porfavor ingrese el contenido del archivo");
            string texto2 = Console.ReadLine(); 

            //metodo 3 crear file
            using(StreamWriter archivo = new StreamWriter(@"/home/javi/cSharp/cShart-curso/dia11/textos/Mitexto.txt")){
                foreach (string linea in lineas)
                {
                    if(linea.Contains("Segundo")){
                        archivo.WriteLine(linea);
                    }
                }
            }

            File.WriteAllText(@"/home/javi/cSharp/cShart-curso/dia11/textos/"+nombreArchivo+".txt",texto2);



            Console.Read();
        }
    }
}
