using System;
using System.Diagnostics;
namespace dia6{
    class Miembros{

        //Miembros - campos privados
        private string nombrePersona;
        private string tituloTrabajo;
        private int salario;

        //Miembros - campos publicos
        public int edad;

        //Miembros - Propiedades
        public string TituloTrabajo { get; set; }

        //Miembros - metodo privado
        private void CompartirInfoPrivada(){
            Console.WriteLine("Hola mi salario es +", salario);
        }

        //Miembros - metodos publicos

        public void Amigo(bool esAmigo){
            if(esAmigo){
                CompartirInfoPrivada();
            }else{
                Console.WriteLine("Hola, mi nombre es {0} y mi edad es {1}",nombrePersona,edad);
            }
        }

        //Miembros - contructor
        public Miembros(){
            edad = 30;
            nombrePersona= "Anna";
            salario = 50000;
            TituloTrabajo = "Desarrollador web";
            Console.WriteLine("Objeto creado");
        }

        //Miembro - Finalizador/destructor

        ~Miembros(){
            Console.WriteLine("Destrucion de objeto miembro");
            Debug.Write("Destrucion de objeto miembro");
        }

    }
}