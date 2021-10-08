using System;
using System.Collections.Generic;

namespace HospiEnCasa.App.Dominio.Entidades
{
    public class Paciente : Persona
    {
        public DateTime FechaNacimiento { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public string Telefono { get; set; }
        public PlanMedico PlanMedico { get; set; }
        public FamiliarDesignado FamiliarDesignado { get; set; }
        public Enfermera Enfermera { get; set; }
        public Medico Medico { get; set; }
        public HistoriaClinica HistoriaClinica { get; set; }
        public List<SignoVital> SignosVitales { get; set; }
    }

    public enum PlanMedico
    {
        EPS,
        Subsidiado,
        Contributivo
    }
}