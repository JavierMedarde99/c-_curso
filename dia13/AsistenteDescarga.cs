namespace Dia13
{

    public class ArchivoEventArgs:EventArgs{
        public Archivo Archivo{get;set;}
    }
    public class AsistenteDescargar{

        //paso 1 - crear el delegado
        //public delegate void GestorEventoArchivoDescargado(object fuente, ArchivoEventArgs args);

        //paso 2 - crear evento basado en el delegado
        public event EventHandler<ArchivoEventArgs> ArchivoDescargado;

        //paso 3 - iniciar el evento
        protected virtual void EnArchivoDescargado(Archivo archivo){
            if(ArchivoDescargado != null){
                ArchivoDescargado(this,new ArchivoEventArgs(){Archivo = archivo});
            }
        }

        public void Descarga(Archivo archivo){
            System.Console.WriteLine("Descargando archivo...");
            Thread.Sleep(4000);

            //paso 3.1 - 
            EnArchivoDescargado(archivo);
        }
    }
    
}