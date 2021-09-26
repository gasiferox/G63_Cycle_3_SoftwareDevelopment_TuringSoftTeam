namespace HospiEnCasa.App.Dominio.Entidades
{
    public class Medicamento
    {
        public int Id { get; set; }
        public NombreMedicamento NombreMedicamento { get; set; }
        public string Posologia { get; set; }
    }
}