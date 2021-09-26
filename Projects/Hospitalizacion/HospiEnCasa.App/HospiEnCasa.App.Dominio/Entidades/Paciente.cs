using System.Collections.Generic;

namespace HospiEnCasa.App.Dominio.Entidades
{
    public class Paciente : Persona
    {
        public string FechaNacimiento { get; set; }
        public int Latitud { get; set; }
        public double Longitud { get; set; }
        public string Telefono { get; set; }
        public string PlanMedico { get; set; }
        public FamiliarDesignado FamiliarDesignado { get; set; }
        public Enfermera Enfermera { get; set; }
        public Medico Medico { get; set; }
        public HistoriaClinica HistoriaClinica { get; set; }
        public List<SignoVital> SignosVitales { get; set; }
    }
}