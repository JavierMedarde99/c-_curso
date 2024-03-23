namespace Dia10
{
    class PublicacionImagen:Publicacion{
        //Propiedad nueva
        public string UrlImagen { get; set; }

        //Constructor por defecto 
        public PublicacionImagen(){

        }

        //Constructor parametrizado
        public PublicacionImagen(string titulo,string autor,string urlImagen, bool esPublico){
            this.ID=CrearID();
            this.Titulo = titulo;
            this.Autor=autor;
            this.EsPublico = esPublico;
            this.UrlImagen = urlImagen;
        }

        public override string ToString()
        {
            return String.Format(" {0} - {1} - creado por {2} - url {3}",this.ID,this.Titulo,this.Autor,this.UrlImagen);
        }
    }
}