// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Data;

namespace Dia7
{
    class Program{
        static void Main(String[] arg){
            int[][] irregular = new int[3][];

            irregular[0] = new int[5];
            irregular[1] = new int[3];
            irregular[2] = new int[2];

            irregular[0] = new int[]{2,3,8,9,11};
            irregular[1] = new int[] { 23,100,15};
            irregular[2] = new int[]{5,100};

            int [][] irregurar2 = new int [][]{
                new int[]{2,3,8,9,11},
                new int[] { 23,100,15},
                new int[]{5,100}
            };

            System.Console.WriteLine("El valor en el medio del primer array es {0}", irregurar2[0][2]);
            

            for (int i = 0; i < irregurar2.Length; i++)
            {
                System.Console.WriteLine("Los valores del array {0} son:",i);
                for (int j = 0; j < irregurar2[i].Length; j++)
                {
                    System.Console.WriteLine(irregurar2[i][j]);
                }
            }

            string[]familiaJuan = new string[]{"Laura","Juan"};

            //Desafio
            string[][] party = new string[][]{
                new string[]{"Miguel","Sandra"},
                new string[]{"Franco","Claudia","Oscar","Leon"},
                new string[]{"Andres","Monica","Lucia"},
                familiaJuan
            };

            System.Console.WriteLine("Hola {0}, quiero presentarte a {1}",party[0][0],party[1][0]);
            System.Console.WriteLine("Hola {0}, quiero presentarte a {1}",party[1][1],party[2][2]);
            System.Console.WriteLine("Hola {0}, quiero presentarte a {1}",party[1][3],party[0][1]);
            System.Console.WriteLine("Hola {0}, quiero presentarte a {1}",party[2][0],party[1][2]);
            System.Console.WriteLine("Hola {0}, quiero presentarte a {1}",party[3][1],party[1][2]);

            int[] calificaciones = new int[]{9,5,3,7,10};
            double promedioResultado = ObtenerPromedio(calificaciones);

            foreach (int nota in calificaciones)
            {
                System.Console.WriteLine(nota);
            }

            System.Console.WriteLine("El promedio es {0}",promedioResultado);

            double[] saldos = {
                233.2,222.5,-234
            };

            credito(saldos);

            // arrayList

            //declarar un arrayList indeterminado
            ArrayList miArrayList = new ArrayList();

            //Declarar un arrayList determinado
            ArrayList miArrayList2 = new ArrayList(100);

            //Agregar elementos al arrayList
            miArrayList.Add(25);
            miArrayList.Add("Hola");
            miArrayList.Add(13.37);
            miArrayList.Add(13);
            miArrayList.Add(128);
            miArrayList.Add(25.3);

            //Eliminar Elementos del arrayList
            miArrayList.Remove(13);

            //Eliminar un elemento por posicion
            miArrayList.RemoveAt(0);

            //Contar elementos del arrayList
            System.Console.WriteLine(miArrayList.Count); 

            double suma =0;

            foreach (object obj in miArrayList)
            {
                if(obj is int){
                    suma = suma + Convert.ToDouble(obj);
                }else if(obj is double){
                    suma = suma + Convert.ToDouble(obj);
                }else if(obj is string){
                    System.Console.WriteLine(obj);
                }
            }

            System.Console.WriteLine(suma);


            // inmutable - mimintado a un tipo
            int[] puntaje = new int[]{99,96,87,76};


            List<int> lista = new List<int> {1,2,3,4,5};

            lista.Add(0);
            lista.Add(32);
            lista.Sort();
            lista.RemoveRange(2,2);

            foreach (int list in lista)
            {
                System.Console.WriteLine(list);
            }

            System.Console.WriteLine(lista.Contains(4));

            int indice = lista.FindIndex(x => x==4);
            System.Console.WriteLine(lista[indice]);
            lista.RemoveAt(indice);

            lista.ForEach(i => System.Console.WriteLine(i));


            ArrayList  arrL = new ArrayList();

            arrL.Add(1);
            arrL.Add("dos");
            arrL.Add("3");
            arrL.Add(new numero{ N = 4});

            foreach (object obj in arrL)
            {
                System.Console.WriteLine(obj);
            }

            System.Console.Read();


        }

        static double ObtenerPromedio(int [] arrayDePuntajes){
            int cantidad = arrayDePuntajes.Length;
            double promedio;
            int suma = 0;

            for (int i = 0; i < cantidad; i++)
            {
                suma = suma + arrayDePuntajes[i];
            }
            promedio = suma/cantidad;
            return promedio;
        }

        static void credito(double[] cuentas){
            for (int i = 0; i < cuentas.Length; i++)
            {
                cuentas[i] = cuentas[i]+200;
                System.Console.WriteLine(cuentas[i]);
            }
        }

        class numero{
            public int N {get; set;}

            public override string ToString()
            {
                return N.ToString();
            }
        }
    }
}