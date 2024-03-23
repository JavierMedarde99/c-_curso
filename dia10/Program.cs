// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace Dia10
{
            public interface INotificion{
            void MostrarNotificion();

            string VerFecha();
        }
        
        public class Notificacion : INotificion{
            //Variables
            private string enviadoPor;
            private string mensaje;
            private string fecha;

            public Notificacion(){
                this.enviadoPor = "Fede";
                this.mensaje = "hola";
                this.fecha = "2024-03-23";
            }

            public Notificacion(string enviadoPor, string mensaje, string fecha){
                this.enviadoPor = enviadoPor;
                this.mensaje = mensaje;
                this.fecha = fecha;
            }

            
            public void MostrarNotificion(){

                System.Console.WriteLine("El mensaje: {0} - fue enviado por {1} el dia {2}",this.mensaje,this.enviadoPor,this.fecha);

            }

            public string VerFecha(){
                return fecha;
            }


        }
    class Program{
        static void Main(String[] arg){ 
            
            Publicacion post1 = new Publicacion("Gracias por los saludos de cumpleaños",true,"Laura Garay");
            PublicacionImagen imagen1 = new PublicacionImagen("Mira mi nuevo perrito","Laura Garay","https://imagen.com/perrito",true);
            PublicacionVideo video1 = new PublicacionVideo("Mira mi otro perrito","Laura Garay","https://imagen.com/perrito",true,2);
            System.Console.WriteLine(imagen1.ToString());
            System.Console.WriteLine(post1.ToString());
            System.Console.WriteLine(video1.ToString());
            video1.Play();
            System.Console.WriteLine("Presione cualquier tecla para detener");
            System.Console.ReadLine();
            video1.Stop();

            //Desafio
            Empleado miEmpleado = new Empleado("Juan","Perez",15000d);
            Jefe miJefe = new Jefe("Manolo","Fernandez",20000d,"Mercedes");
            Pasante miPasante = new Pasante("Antonio","Garcia",0,30,40);

            miJefe.Dirigir();
            miPasante.Trabajar();

            Notificacion n1 = new Notificacion("Fede","Como va todo","25.01.2020");
            Notificacion n2 = new Notificacion("Franco", "Esta todo bien","25.01.2020");

            n1.MostrarNotificion();
            n2.MostrarNotificion();
        
            Console.Read();
        }
    }
}
