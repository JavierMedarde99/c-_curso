// See https://aka.ms/new-console-template for more information
using System;

namespace Dia11
{
    class Auto{

        public int Hp { get; set; }
        public string Color { get; set; }

        //Tiene una relacion con autoInfo
        protected AutoInfo autoInfo = new AutoInfo();

        public Auto(){
        }
        public Auto(int hp, string color){
            this.Hp = hp;
            this.Color = color;
        }

        public void MostrarDetalles(){
            System.Console.WriteLine("Este auto tiene tantas HP {0} y es de color {1}",this.Hp,this.Color);
        }

        public virtual void Reparar(){
            System.Console.WriteLine("Auto reparado");
        }

        public void SetearAutoInfo(int id, string propetario){
            autoInfo.ID = id;
            autoInfo.Propietario = propetario;
        }

        public void LeerAutoInfo(){
            System.Console.WriteLine("El id del auto es {0} y su propietario es {1}",autoInfo.ID,autoInfo.Propietario);
        }
    }
}