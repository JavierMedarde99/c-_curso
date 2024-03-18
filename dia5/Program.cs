// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace Dia2
{
    class Program{
        static void Main(String[] arg){
            //loop for

            for(int contadofor=1;contadofor < 20;contadofor+=2){
                Console.WriteLine(contadofor);
            }

            //loop while
            int largoDeTexto = 0;
            string textoCompleto = "";
            do{
                Console.WriteLine("Pro favor, ingresa el nombre de un amigo");
                string nombreAmigo = Console.ReadLine();
                int largoActual = nombreAmigo.Length;
                largoDeTexto += largoActual;
                textoCompleto += nombreAmigo;

            }while(largoDeTexto<20);
            Console.WriteLine("Gracias eso es todo " + textoCompleto);
            

            //loop while

            int contador = 0;
            string textoIngresado=  "";

            while (textoIngresado.Equals("")){
                Console.WriteLine("Pro favor, ingrese un alumno");
                textoIngresado = Console.ReadLine();
                contador++;
                Console.WriteLine("alumno añadido, total de alumno: "+contador);
            }
            

            for (int contadorFor2 = 0; contadorFor2 <10; contadorFor2++){
                if(contadorFor2 % 2 == 0){
                    //break;
                    continue;
                }
                Console.WriteLine(contadorFor2);
            }

            // desafio 1

            int puntuacion = 0;
            contador = 0;
            int inputInt;
            string input;
            do{
                Console.WriteLine("ingrese una nota de un alumno");
                input= Console.ReadLine();
                
                if(int.TryParse(input,out inputInt)){
                    inputInt = int.Parse(input);
                    if(inputInt>=0 && inputInt<=10){
                        puntuacion =puntuacion+inputInt;
                        contador++;
                    }
                    continue;
                }
                continue;
            }while(!input.Equals("fin"));
            Console.WriteLine("La nota media del alumno es de "+ puntuacion/contador);
            Console.Read();

        }
    }
}
