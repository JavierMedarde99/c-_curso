namespace Dia10
{
    class Empleado{
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public double Salario { get; set; }

        public void Trabajar(){
            System.Console.WriteLine("Estoy trabajando");
        }

        public void Descansar(){
            System.Console.WriteLine("Estoy descansando");
        }

        public Empleado(){

        }

        public Empleado(string nombre, string apellido, double salario){
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Salario = salario;
        }
    }
}