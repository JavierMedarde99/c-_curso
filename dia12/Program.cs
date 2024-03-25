// See https://aka.ms/new-console-template for more information
using System;
using System.Security.Cryptography;
using System.Text.RegularExpressions;


namespace Dia12
{

    struct Juego{
        public string nombre;
        public string nombreDesarrollador;

        public void Mostar(){
            System.Console.WriteLine("El nombre del juego es {0}",nombre);
            System.Console.WriteLine("El desarrollador es {0}",nombreDesarrollador);
        }

        public Juego(string nombre,string nombreDesarrollador){
            this.nombre = nombre;
            this.nombreDesarrollador = nombreDesarrollador;
        }
    }

    enum Dia
    {
        Lu , Ma, Mi, Ju, Vi, Sa, Do
    };

    enum Mes
    {
        Ene=1, Feb, Mar, Abr, May, Jun, Jul,Ago, Sep,Oct,Nov,Dic
    };

    class Program
    { 
        static void Main(String[] arg){

            //struct
            Juego juego1;

            juego1.nombre = "Casa Zombie";
            juego1.nombreDesarrollador = "nintendo";

            juego1.Mostar();   

            //Enums
            Dia viernes = Dia.Vi;

            Dia domingo = Dia.Do;

            Dia a = Dia.Vi;

            System.Console.WriteLine(Dia.Lu);

            System.Console.WriteLine((int) Dia.Lu);

            System.Console.WriteLine(viernes == a); 

            System.Console.WriteLine((int) Mes.Feb);      

            //Math

            int a2 =13;
            int b = 9;

            System.Console.WriteLine("Redondeo hacia arriba de 15.3 es {0}", Math.Ceiling(15.3));  

            System.Console.WriteLine("Redondeo hacia abajo de 15.3 es {0}", Math.Floor(15.3));

            System.Console.WriteLine("El valor mas bajo entre {0} y {1} es {2}",a2,b,Math.Min(a2,b));

            System.Console.WriteLine("El valor mas alto entre {0} y {1} es {2}",a2,b,Math.Max(a2,b));

            System.Console.WriteLine("3 elevado a la 5 es " + Math.Pow(3,5));

            System.Console.WriteLine("PI es {0}",Math.PI);

            System.Console.WriteLine("La raiz cuadrada de 25 es {0}",Math.Sqrt(25));

            System.Console.WriteLine("El absoluto de -25 es {0}",Math.Abs(-25));

            System.Console.WriteLine("El coseno de 1 es {0}",Math.Cos(1));

            //Random

            Random dado = new Random();

            int numCara;
            string respuesta;

            for (int i = 0; i < 10; i++)
            {
                numCara = dado.Next(1,7);
                System.Console.WriteLine(numCara);
            }

            System.Console.WriteLine("Inserte aqui su pregunta");
            //Console.ReadLine();

            int respuestaNum = dado.Next(1,4);

            if(respuestaNum == 1){
                respuesta = "si";
            }else if(respuestaNum==2){
                respuesta = "quizas";
            }else{
                respuesta = "no";
            }

            System.Console.WriteLine("La respuesta es : {0}",respuesta);

            //ExpresionesRegulares
            string patron = @"\d{6}";
            string texto = "Hola mi numero telefonico 123456";
            Regex regex = new Regex(patron);

            MatchCollection aciertos = regex.Matches(texto);

            System.Console.WriteLine("{0} aciertos encontrados:\n{1}",aciertos.Count,texto);

            foreach (Match acierto in aciertos)
            {
                GroupCollection grupo = acierto.Groups;
                System.Console.WriteLine("{0} fue encontrado en {1}",grupo[0].Value,grupo[0].Index);
            }

            //DateTime
            DateTime tiempo = new DateTime(1999,12,11);
            System.Console.WriteLine("Mi nacimiento fue el {0}",tiempo);

            // mostrar fecha actual
            System.Console.WriteLine(DateTime.Today);

            // Mostrar la hora actual
            System.Console.WriteLine(DateTime.Now);
            
            DateTime maniana = ProximoDia();

            System.Console.WriteLine("Mañana va a ser {0}",maniana);

            System.Console.WriteLine("Hoy es {0}",DateTime.Today.DayOfWeek);

            System.Console.WriteLine(PrimerDiaDelAnio(1999));

            int dias = DateTime.DaysInMonth(2000,2);
            System.Console.WriteLine("El mes de febrero de 2000 tuvo {0}",dias);

            dias = DateTime.DaysInMonth(2001,2);
            System.Console.WriteLine("El mes de febrero de 2001 tuvo {0}",dias);

            dias = DateTime.DaysInMonth(2004,2);
            System.Console.WriteLine("El mes de febrero de 2004 tuvo {0}",dias);

            DateTime ahora = DateTime.Now;
            System.Console.WriteLine("Minuto : {0}",ahora.Minute);

            System.Console.WriteLine("esta es la hora actual. Hora : {0}, Minuto : {1} y segundos: {2}",ahora.Hour,ahora.Minute,ahora.Second);

            System.Console.WriteLine("Porfavor ingrese una fecha en el siguente formato: aaaa-mm-dd");
            string ingreso = Console.ReadLine();

            if(DateTime.TryParse(ingreso, out tiempo)){
                System.Console.WriteLine(tiempo);
                TimeSpan diasEnteros = ahora.Subtract(tiempo);
                System.Console.WriteLine("Dias que pasaron desde esa fecha: {0}",diasEnteros.Days);
            }else{
                System.Console.WriteLine("ingreso incorrecto");
            }

            //Nulabilidad
            int? num1 = null;
            int? num2 = 1337;
            int num5;

            double? num3 = new double?();
            double? num4 = 3.14157;

            bool? valor = new bool?();

            System.Console.WriteLine("nuestros valores son: {0}, {1},{2},{3}",num1,num2,num3,num4);
            System.Console.WriteLine("Nuestro booleano es : {0}",valor);

            bool? esHombre = null;

            if(esHombre == true){
                System.Console.WriteLine("El usuario es hombre");
            }else if(esHombre == false){
                System.Console.WriteLine("El usuario es mujer");
            }else{
                System.Console.WriteLine("No se especifico genero");
            }

            double? num6 = 13.1;
            double? num7 = null;
            double num8;

            if(num6 == null){
                num8 = 0.00;
            }else{
                num8 = (double) num6;
            }

            System.Console.WriteLine("El valor de num8 es {0}", num8);

            num8 = num6 ?? 0.53;

            System.Console.WriteLine("El valor de num8 es {0}", num8);

            num8 = num7 ?? 0.53;
            System.Console.WriteLine("El valor de num8 es {0}", num8);



            Console.Read();

        }

        static DateTime ProximoDia(){
            return DateTime.Today.AddDays(1);
        }

        static DateTime PrimerDiaDelAnio(int anio){
            return new DateTime(anio,1,1);

        }
    }
}
