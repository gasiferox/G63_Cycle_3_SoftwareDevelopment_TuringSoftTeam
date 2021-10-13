using System.ComponentModel.DataAnnotations;

namespace HospiEnCasa.App.Dominio.Entidades
{
    public class Persona
    {
        public int Id {get; set;}
        [Required, StringLength(50)]
        public string Nombre {get; set;}
        [Required, StringLength(50)]
        public string Apellido {get; set;}
        public TipoDocumento TipoDocumento {get; set;}
        [Required, StringLength(15)]
        public string Documento {get; set;}
        public Genero Genero {get; set;}
    }

    public enum TipoDocumento
    {
        CedulaDeCiudadania = 0,
        Pasaporte = 1,
        TarjetaDeIdentidad = 2,
        CedulaDeExtranjeria = 3
    }

    public enum Genero
    {
        Masculino,
        Femenino,
        Otro
    }

}