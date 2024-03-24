using System;

namespace Dia11
{
    class Audi:Auto{

        private string Marca = "Audi";
        public string Modelo { get; set; }

        public Audi(int hp, string color,string modelo):base(hp,color){
            this.Modelo = modelo;
        }

        public void MostrarDetalles(){
            System.Console.WriteLine("Este Audi tiene tantas HP {0}, es de color {1} y modelo {2}",this.Hp,this.Color,this.Modelo);
        }

        public override void Reparar(){
            System.Console.WriteLine("Audi reparado");
        }
    }
}