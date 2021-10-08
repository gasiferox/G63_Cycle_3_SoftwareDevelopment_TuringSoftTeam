namespace HospiEnCasa.App.Dominio.Entidades
{
    public class Medico : Persona
    {
        public Especialidad Especialidad {get; set;}
        public string RegistroMedico {get; set;}
    }

    public enum Especialidad
    {
        Internista,
        Cardiologo,
        Urologo,
        Endocrino,
        Ginecologo,
        Neurocirujano
    }
}