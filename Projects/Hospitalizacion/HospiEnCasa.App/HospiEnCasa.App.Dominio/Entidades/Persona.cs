namespace HospiEnCasa.App.Dominio.Entidades
{
    public class Persona
    {
        public int Id {get; set;}
        public string Nombre {get; set;}
        public string Apellido {get; set;}
        public TipoDocumento TipoDocumento {get; set;}
        public string Documento {get; set;}
        public Genero Genero {get; set;}
    }

}