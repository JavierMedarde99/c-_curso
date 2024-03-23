namespace Dia10
{
    class Publicacion{
        private static int publicacionId;

        //Propiedades
        protected int ID{ get; set; }
        protected string Titulo { get; set; }
        protected string Autor { get; set; }
        protected bool EsPublico { get; set; }

        //Constructor por defecto
        public Publicacion(){
            ID = CrearID();
            Titulo = "Mi primera publicacion";
            EsPublico = true;
            Autor = "Juan Perez";
        }

        //constructor parametrizado
        public Publicacion(string titulo, bool esPublico, string autor){
            this.ID = CrearID();
            this.Titulo = titulo;
            this.EsPublico = EsPublico;
            this.Autor = autor;

        }

        //Metodo de autogenerar ID
        protected int CrearID(){
            return ++publicacionId;
        }

        //Metodo para editar publicacion
        public void Editar(string titulo,bool esPublico){
            this.Titulo = titulo;
            this.EsPublico = esPublico;
        }

        public override string ToString()
        {
            return String.Format(" {0} - {1} - creado por {2}",this.ID,this.Titulo,this.Autor);
        }
    }
}