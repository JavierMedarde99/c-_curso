using System;

namespace Dia11
{
    class Bmw:Auto{

        private string Marca = "BMW";
        public string Modelo { get; set; }

        public Bmw(){
        }

        public Bmw(int hp, string color,string modelo):base(hp,color){
            this.Modelo = modelo;
        }

        public new void MostrarDetalles(){
            System.Console.WriteLine("Este BMW tiene tantas HP {0}n es de color {1} y modelo {2}",this.Hp,this.Color,this.Modelo);
        }

        public sealed override void Reparar(){
            System.Console.WriteLine("BMW reparado");
        }
    }
}