using System.Collections.Generic;

namespace HospiEnCasa.App.Dominio.Entidades
{
    public class Tratamiento
    {
        public int Id { get; set; }
        public string Recomendaciones { get; set; }
        public int Incapacidad { get; set; }
        public List<Medicamento> Medicamentos { get; set; }
        public List<Remision> Remisiones { get; set; }
    }
}