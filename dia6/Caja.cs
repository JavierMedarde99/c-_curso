using System;
namespace dia6{
    class Caja{

        //Desafio 



        private int largo;
        //private int alto;
        //private int ancho;
        private int volumen;

        public Caja(int largo,int alto,int ancho){
            this.largo = largo;
            this.Alto = alto;
            this.Ancho = ancho;
        }

        //Propiedades corta (aunto inplementada)
        public int Ancho { get; set; }
        public int Alto { get; set; }

        //propiedades largo
        /**public int Largo{
            get{
                return largo;
            }
            set{
                largo = value;
            }
        }**/

        public int Largo{
            get=> largo;
            set=> largo = value;
        }

        public int Volumen { set{
            volumen = value;
        }
        get{
            return Alto*Ancho*Largo;
        } }

        public void MuentraInf(){
            Console.WriteLine("El largo es {0}. La altura es {1}. El ancho es {2}. El volumen es {3}", largo,Alto,Ancho,volumen = Ancho*Alto*largo);
        }

        public int SuperficieFrontal{
            get{
                return Alto* Largo;
            }
        }

        /**public void SetLargo(int largo){
            this.largo = largo;
        }

        public int GetLargo(){
            return this.largo;
        }**/


    }
}