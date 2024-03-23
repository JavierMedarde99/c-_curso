namespace Dia10
{
    class Pasante:Empleado{
        public int HorasDeTrabajo { get; set; }
        public int HorasDeEscuela { get; set; }

        public void Aprender(){
            System.Console.WriteLine("Estoy aprendiendo durante {0} cantidad de horas",this.HorasDeEscuela+this.HorasDeTrabajo);
        }

        public void Trabajar(){
            System.Console.WriteLine("Cantidad de hora semana es {0}",this.HorasDeTrabajo);
        }

        public Pasante(){

        }
        public Pasante(string nombre, string apellido, double salario,int horasDeEscuela,int horasDeTrabajo){
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Salario = salario;
            this.HorasDeTrabajo = horasDeTrabajo;
            this.HorasDeEscuela = horasDeEscuela;
        } 
    }
}