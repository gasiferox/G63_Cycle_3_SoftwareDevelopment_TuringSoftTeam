using System;
//using System.Collections.Generic;

namespace HospiEnCasa.App.Dominio.Entidades
{
    public class HistoriaClinica
    {
        public int Id { get; set; }
        public String FechaAtencion { get; set; }
        public string Antecedentes { get; set; }
        public Tratamiento Tratamiento { get; set; }
    }
}