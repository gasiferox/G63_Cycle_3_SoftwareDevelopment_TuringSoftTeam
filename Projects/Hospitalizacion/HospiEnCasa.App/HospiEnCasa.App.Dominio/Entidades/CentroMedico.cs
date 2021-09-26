namespace HospiEnCasa.App.Dominio.Entidades
{
    public class CentroMedico
    {
        public int Id { get; set; }
        public string NombreCentro { get; set; }
        public string Direccion { get; set;}
        public string nit { get; set; }


        /* Relación por composición */
/*        public Medico Medico = new Medico();

        public void AgregarMedico()
        {
            Medico.AgregarMedico();
        }

        public int ListarDoctor()
        {
            return Medico.ListarDoctor();
        }
*/    }
}