using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Dia10
{
    class PublicacionVideo:Publicacion{

        //Variables 
        protected bool seReproduce = false;
        protected int duracionActual = 0;

        Timer reloj;

        // propiedades
        public string UrlVideo { get; set; }
        public int Duracion { get; set; }

        //Constructor por defecto
        public PublicacionVideo(){

        }

        //Constructor parametrizado
        public PublicacionVideo(string titulo,string autor,string urlVideo, bool esPublico,int duracion){
            this.ID=CrearID();
            this.Titulo = titulo;
            this.Autor=autor;
            this.EsPublico = esPublico;
            this.UrlVideo = urlVideo;
            this.Duracion = duracion;
        }

        public override string ToString()
        {
            return String.Format(" {0} - {1} - creado por {2} - url {3} con una duracion de {4} minutos",this.ID,this.Titulo,this.Autor,this.UrlVideo,this.Duracion);
        }

        public void Play(){
            if(!seReproduce){
                seReproduce = true;
                System.Console.WriteLine("Se esta reproduciendo");
                reloj = new Timer(Reproduccion,null,0,1000);
            }
        }
        public void Stop(){
            if(seReproduce){
                seReproduce = false;
                System.Console.WriteLine("\nDetenido en {0}",duracionActual);
                duracionActual = 0;
                reloj.Dispose();
            }
        }

        private void Reproduccion(Object o){
            if(duracionActual < Duracion){
                duracionActual ++;
                System.Console.WriteLine("video en {0}",duracionActual);
                GC.Collect();

            }else{
                Stop();
            }
        }
    }
}