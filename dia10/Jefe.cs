namespace Dia10
{
    class Jefe:Empleado{
        public string AutoDeEmpresa { get; set; }

        public void Dirigir(){
            System.Console.WriteLine("Soy el jefe");
        }

        public Jefe(){

        }

        public Jefe(string nombre, string apellido, double salario,string autoDeEmpresa){
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Salario = salario;
            this.AutoDeEmpresa = autoDeEmpresa;
        }
    }
}