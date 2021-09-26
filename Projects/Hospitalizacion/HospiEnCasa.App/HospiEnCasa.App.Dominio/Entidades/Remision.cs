using System;

namespace HospiEnCasa.App.Dominio.Entidades
{
    public class Remision
    {
        public int Id { get; set; }
        public TipoExamen TipoExamen { get; set; }
        public DateTime FechaHora { get; set;}
        public string Resultado { get; set; }
    }
}