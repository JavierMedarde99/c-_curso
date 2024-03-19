using System;

namespace dia6
{
    class Humano
    {
        // Miembro Variable
        private string primerNombre;
        private string apellido;

        private string colorDeOjos;

        private int edad;

        //Miembro constructor por defecto
        public Humano(){
            Console.WriteLine("constructor llamado. Objeto creado");
        }

        //Miembro constructor parametrizado
        public Humano(string primerNombre, string apellido,string colorDeOjos,int edad)
        {
            this.primerNombre = primerNombre;
            this.apellido = apellido;
            this.colorDeOjos = colorDeOjos;
            this.edad = edad;
        }

        public Humano(string primerNombre, string apellido,string colorDeOjos)
        {
            this.primerNombre = primerNombre;
            this.apellido = apellido;
            this.colorDeOjos = colorDeOjos;
        }

        public Humano(string primerNombre,string colorDeOjos)
        {
            this.primerNombre = primerNombre;
            this.colorDeOjos = colorDeOjos;
        }

        public Humano(string primerNombre,int edad)
        {
            this.primerNombre = primerNombre;
            this.edad = edad;
        }


        //Miembre metodo
        public void presentarme()
        {
            if(edad == 1){ 
                Console.WriteLine("hola soy {0}, {1} tengo {2} año de edad. Mi color de ojos es {3}", primerNombre, apellido,edad,colorDeOjos);
            }else if(edad==0){
                Console.WriteLine("hola soy {0}, {1}, mi color de ojos es {2}", primerNombre, apellido,colorDeOjos);
            }else if(apellido == null){
                Console.WriteLine("hola soy {0} tengo {1} años de edad. Mi color de ojos es {2}", primerNombre, edad,colorDeOjos);
            }else if(colorDeOjos == null){
                Console.WriteLine("hola soy {0}, {1} tengo {2} años de edad.", primerNombre, apellido,edad);
            }else{
                Console.WriteLine("hola soy {0}, {1} tengo {2} años de edad. Mi color de ojos es {3}", primerNombre, apellido,edad,colorDeOjos);
            }
            
        }
    }
}
