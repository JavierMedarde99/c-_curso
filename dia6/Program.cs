// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Runtime.InteropServices;

namespace dia6
{
    class Program
    {
        static void Main(String[] arg)
        {
            //Crea un objeto desde mi clase
            //es una instancia de Humano
            Humano juan = new Humano("Juan", "Manuel","marrones",23);
            //acceder a una variable publica
            //juan.primerNombre = "Juan";
            //juan.apellido = "Manuel";

            //metodo de la clase
            juan.presentarme();

            Humano pedro = new Humano("Pedro", "Perez","azules",30);
            //pedro.primerNombre = "Pedro";
            //pedro.apellido = "Perez";
            pedro.presentarme();

            Humano humanoBasico = new Humano();
            humanoBasico.presentarme();

            Humano alberto = new Humano("Alberto","Perez","Verde");
            alberto.presentarme();

            Caja caja = new Caja(3,5,4);
            Console.WriteLine("el volumen es " + caja.Volumen);
            caja.MuentraInf();
            Console.Read();
        }
    }
}
