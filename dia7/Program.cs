// See https://aka.ms/new-console-template for more information
using System;

namespace Dia7
{
    class Program
    {

        // NivelDeAcceso - (static) - TipoDeRetorno - NombreDelMetodo - (Parametro1,Parametro2...) 
        static void Main(string[] args)
        { /**
            //primera manera de hacer array
            int [] calificacion = new  int[5];

            calificacion[0] = 10;
            calificacion[1] = 7;
            calificacion[2] = 9;
            calificacion[3] = 3;
            calificacion[4] = 7;

            //string ingreso = Console.ReadLine();
            //calificacion[0] = int.Parse(ingreso);

            Console.WriteLine("Primera calificacion : {0}", calificacion[0]);

            //Segunda manera de crear arrays
            int[] edades = {17,15,16,15,17};

            //Tercera manera de crear arrays
            int[] faltasAlColegio = new int[]{3,5,7,3,4,5};

            Console.WriteLine("El array de falta al colegio tiene {0} casos",faltasAlColegio.Length);

            int[] nums = new int[10];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i +5;
            }

            
            for(int j=0; j < nums.Length; j++){
                Console.WriteLine("El valor del indice {0} es {1}",j,nums[j]);
            }

            foreach (int k in nums)
            {
                 Console.WriteLine("El valor del indice {0} es {1}",k,nums[k]);
            }

            string[]amigos = {"juan","pepe","javi"};

            foreach (string amigo in amigos)
            {
                Console.WriteLine("Hola, {0}",amigo);
            }

            //Declaracion de un array de 2D
            string[,]matriz2D;

            int[,,]matriz3D;

            string[,]array2D = new string[,]{
                {"A","B","C"},
                {"A","B","C"},
                {"A","B","C"},
            };

            string[,,]array3D = new string[,,]{
                {
                    {"A","B","C"},
                    {"A","B","C"},
                    {"A","B","C"}
                },
                {
                    {"A","B","C"},
                    {"A","B","C"},
                    {"A","B","C"}
                },
                {
                    {"A","B","C"},
                    {"A","B","C"},
                    {"A","B","C"}
                }
            };

            string[,]otroArray2D = new string[3,2]{
                {"maria","Lopez"},
                {"Franco", "miler"},
                {"Juana","Garay"}
            };

            otroArray2D[1,1] = "Paxo";

            int dimesion = otroArray2D.Rank;

            int[,] a2D = {
                {1,2},
                {3,4}
            };

            Console.WriteLine("Las dimensiones del array son {0}",dimesion);

            Console.WriteLine("El valor central es {0}", array2D[2,0]);
            Console.WriteLine("EL valor de A es {0}", array3D[0,0,0]);
            Console.WriteLine("EL valor de A es {0}", array3D[1,2,1]);
**/

            // desafio tic tac toc

                int jugador = 2;
            int ingreso = 0;
            bool ingresoCorrecto = true;

            do
            {
                if (jugador == 2)
                {
                    jugador = 1;
                    PonerXoO(jugador, ingreso);
                }else if (jugador == 1)
                {
                    jugador = 2;
                    PonerXoO(jugador, ingreso);
                }

                CreaTablero();

                //Código que verifica si hay un ganador
                #region
                char[] cadaSigno = { 'X', 'O' };

                foreach (char signo in cadaSigno)
                {
                    if ((tableroJuego[0, 0] == signo) && (tableroJuego[0, 1] == signo) && (tableroJuego[0, 2] == signo)
                        || (tableroJuego[1, 0] == signo) && (tableroJuego[1, 1] == signo) && (tableroJuego[1, 2] == signo)
                        || (tableroJuego[2, 0] == signo) && (tableroJuego[2, 1] == signo) && (tableroJuego[2, 2] == signo)
                        || (tableroJuego[0, 0] == signo) && (tableroJuego[1, 0] == signo) && (tableroJuego[2, 0] == signo)
                        || (tableroJuego[0, 1] == signo) && (tableroJuego[1, 1] == signo) && (tableroJuego[2, 1] == signo)
                        || (tableroJuego[0, 2] == signo) && (tableroJuego[1, 2] == signo) && (tableroJuego[2, 2] == signo)
                        || (tableroJuego[0, 0] == signo) && (tableroJuego[1, 1] == signo) && (tableroJuego[2, 2] == signo)
                        || (tableroJuego[0, 2] == signo) && (tableroJuego[1, 1] == signo) && (tableroJuego[2, 0] == signo))
                    {
                        if (signo == 'X')
                            Console.WriteLine("Felicitaciones. Ha ganado el jugador 2");
                        else
                            Console.WriteLine("Felicitaciones. Ha ganado el jugador 1");

                        Console.WriteLine("Presione cualquier tecla para reiniciar el juego");
                        Console.Read();
                        ingreso = 0;
                        Resetear();

                        break;

                    }

                    else if (turnos == 10)
                    {
                        Console.WriteLine("\n¡Empate!");
                        Console.WriteLine("Presione cualquier tecla para reiniciar el juego");
                        Console.Read();
                        Resetear();
                        break;
                    }

                   


                }




                #endregion

                //Código que verifica si el valor ingresado es válido
                #region
                do
                {
                    Console.WriteLine("\nJugador {0}: Por favor elija un casillero...", jugador);
                    try
                    {
                        ingreso = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Por favor ingrese un número");
                    }

                    if ((ingreso == 1) && (tableroJuego[0, 0] == '1'))
                        ingresoCorrecto = true;
                    else if ((ingreso == 2) && (tableroJuego[0, 1] == '2'))
                        ingresoCorrecto = true;
                    else if ((ingreso == 3) && (tableroJuego[0, 2] == '3'))
                        ingresoCorrecto = true;
                    else if ((ingreso == 4) && (tableroJuego[1, 0] == '4'))
                        ingresoCorrecto = true;
                    else if ((ingreso == 5) && (tableroJuego[1, 1] == '5'))
                        ingresoCorrecto = true;
                    else if ((ingreso == 6) && (tableroJuego[1, 2] == '6'))
                        ingresoCorrecto = true;
                    else if ((ingreso == 7) && (tableroJuego[2, 0] == '7'))
                        ingresoCorrecto = true;
                    else if ((ingreso == 8) && (tableroJuego[2, 1] == '8'))
                        ingresoCorrecto = true;
                    else if ((ingreso == 9) && (tableroJuego[2, 2] == '9'))
                        ingresoCorrecto = true;
                    else
                    {
                        Console.WriteLine("\nPor favor ingrese otro número");
                        ingresoCorrecto = false;
                    }


                } while (!ingresoCorrecto);
                #endregion


            } while (true);


            Console.Read();
        }
             //Método para identificar Jugador
        public static void PonerXoO(int jugador, int ingreso)
        {
            char signo = ' ';

            if (jugador == 1)
            {
                signo = 'X';
            }
            else if (jugador == 2)
            {
                signo = 'O';
            }

            switch (ingreso)
            {
                case 1: tableroJuego[0, 0] = signo; break;
                case 2: tableroJuego[0, 1] = signo; break;
                case 3: tableroJuego[0, 2] = signo; break;
                case 4: tableroJuego[1, 0] = signo; break;
                case 5: tableroJuego[1, 1] = signo; break;
                case 6: tableroJuego[1, 2] = signo; break;
                case 7: tableroJuego[2, 0] = signo; break;
                case 8: tableroJuego[2, 1] = signo; break;
                case 9: tableroJuego[2, 2] = signo; break;
            }
        }

                //Array que contiene variables del juego
        static char[,] tableroJuego =
        {
            {'1','2','3' },
            {'4','5','6' },
            {'7','8','9' }
        };

        //Array que contiene variables del juego inicial
        static char[,] tableroJuegoInicial =
        {
            {'1','2','3' },
            {'4','5','6' },
            {'7','8','9' }
        };

        static int turnos = 0;

        //Método que Crea el Tablero
        public static void CreaTablero()
        {
            Console.Clear();
            Console.WriteLine("     |     |");
            Console.WriteLine("  {0}  |  {1}  |  {2}",tableroJuego[0,0], tableroJuego[0, 1], tableroJuego[0, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |");
            Console.WriteLine("  {0}  |  {1}  |  {2}", tableroJuego[1, 0], tableroJuego[1, 1], tableroJuego[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |");
            Console.WriteLine("  {0}  |  {1}  |  {2}", tableroJuego[2, 0], tableroJuego[2, 1], tableroJuego[2, 2]);
            Console.WriteLine("     |     |");
            turnos++;
        }

        //Método que reinicia todo el juego
        public static void Resetear()
        {
            tableroJuego = tableroJuegoInicial;
            CreaTablero();
            turnos = 0;
        }
    }
}