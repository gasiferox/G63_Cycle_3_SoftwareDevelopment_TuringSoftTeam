using System;
namespace HospiEnCasa.App.Dominio.Entidades
{
    public class SignoVital
    {
        public int Id {get; set;}
        public DateTime FechaHora {get; set;}
        public TipoSigno TipoSigno {get; set;}
        public float Valor {get; set;}
    }
}