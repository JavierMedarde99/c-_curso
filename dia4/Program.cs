// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace Dia4
{
    class Program
    {
        static int puntuacionRecord = 10;
        static string jugadorRecord = "juan";
        static void Main(String[] arg) {
            Console.WriteLine("Ingrese la temperatura");
            string input = Console.ReadLine();
            int temperatura;

            if(int.TryParse(input,out temperatura)){
            temperatura = int.Parse(input);
            //string resultado = temperatura<=15 ? "Hace mucho frio" : (temperatura>=16 && temperatura<=28 ? "Hace un clima agradable" : "Hace mucho calor");

            if(temperatura <10){
                Console.WriteLine("Abrigate!");
            }
            else if(temperatura == 10){
                Console.WriteLine("Hace 10 grados de temperatura");
            }
            else if(temperatura >30){
                Console.WriteLine("Hacen 30 grados, !Que calor¡");
            }else {
                Console.WriteLine("Esta calido");
            }

            }else{
                Console.WriteLine("El valor ingresado no era un numero");
            }
            

            //If anidados

            bool esAdmin = false;
            bool estaRegistrado = true;
            string nombreDeUsuario = "";

            Console.WriteLine("Por favor ingrese su nombre de usuario");
            nombreDeUsuario = Console.ReadLine();
            if(estaRegistrado){
                Console.WriteLine("Hola usuario registrado");
                if(nombreDeUsuario != ""){
                    Console.WriteLine("Hola " + nombreDeUsuario);
                    if(nombreDeUsuario.Equals("Admin")){
                        Console.WriteLine("Hola Admin");
                    }
                }
            }

            if(estaRegistrado && nombreDeUsuario != "" && nombreDeUsuario.Equals("Admin")){
                Console.WriteLine("Bienvenido Admin");
            }

            //desafio 1
            Registro();

            //switch

            int autos = 1;
            switch (autos)
            {
                case 0:
                    Console.WriteLine("Usted no paga inpuestos");
                    break;
                case 1:
                    Console.WriteLine("Usted paga 15 dolares");
                    break;
                case 2:
                    Console.WriteLine("Usted paga 30 dolares");
                    break;
                default:
                    Console.WriteLine("Usted paga 15 dolares por auto");
                    break;
            }

            string piedraPapelTiejera = "piedra";
            switch (piedraPapelTiejera)
            {
                case "piedra":
                     Console.WriteLine("Piedra mata a tijera");
                     break;
                case "tijera":
                     Console.WriteLine("Piedra mata a papel");
                     break;
                case "papel":
                     Console.WriteLine("Piedra mata a piedra");
                     break;
                default:
                     Console.WriteLine("ese elemento no forma parte del juego");
                     break;
            }

            //ternarios
            int temperatura1 = -5;
            string estadoDeAgua;

            /*
            if(temperatura1<0){
                estadoDeAgua = "solido";
            } else{
                estadoDeAgua="liquido";
            }*/

            
            estadoDeAgua = temperatura1<0 ? "solido":(temperatura1>99 ? "gaseoso":"liquido");

            Console.WriteLine("El estado del agua es " + estadoDeAgua);

            Console.Read();
        }

        public static void Registro(){
            Console.WriteLine("Por favor ingrese un nombre de usuario");
            string nombreDeUsuarioRegistrado = Console.ReadLine();

            Console.WriteLine("Por favor ingrese una Contraseña");
            string ContraseniaRegistrado = Console.ReadLine();

            Console.WriteLine("Usuario Registrado correctamente, porfavor logease");

            Console.WriteLine("Por favor ingrese su nombre de usuario");
            string nombreDeUsuarioLogin = Console.ReadLine();

            Console.WriteLine("Por favor ingrese su Contraseña");
            string Contrasenialogin = Console.ReadLine();

            if(nombreDeUsuarioRegistrado.Equals(nombreDeUsuarioLogin) && ContraseniaRegistrado.Equals(Contrasenialogin)){
                Console.WriteLine("bienvenido "+ nombreDeUsuarioLogin);
            }else{
                Console.WriteLine("Usuario incorrecto");
            }
        }

        public static void Puntuacion(string nombreJugador, int puntuacion){
            if(puntuacion>puntuacionRecord){
                puntuacionRecord = puntuacion;
                jugadorRecord = nombreJugador;
                Console.WriteLine("La nueva puntuacion mas alta es "+puntuacion);
                Console.WriteLine("La puntuacion mas alta fue lograda por "+ nombreJugador);
            }else{
                Console.WriteLine("La puntuacion mas alta de "+puntuacionRecord+" no se ha podido superar, y aun esta en manos de "+ jugadorRecord);
            }
        }
    }
}