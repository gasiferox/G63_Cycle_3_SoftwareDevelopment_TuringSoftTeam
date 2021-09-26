using System;
using HospiEnCasa.App.Persistencia;
using HospiEnCasa.App.Dominio.Entidades;

namespace HospiEnCasa.App.Consola
{
    public class Program
    {
        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente(new Persistencia.AppContext());

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World Entity Framework!");
            //AddPaciente();
            //BuscarPaciente(1);
            AsignarMedico();
        }

        private static void AddPaciente()
        {
            var paciente = new Paciente
            {
                Nombre = "Nicolas",
                Apellido = "Perez",
                Telefono = "33344455",
                Genero = Genero.Masculino,
                TipoDocumento = TipoDocumento.CedulaDeCiudadania,
                Documento = "799429933",
                Latitud = 5.006784D,
                Longitud = -73.67653D,
                FechaNacimiento = new DateTime(1977, 06, 09)
            };
            _repoPaciente.AddPaciente(paciente);
        }

        private static void BuscarPaciente(int idPaciente)
        {
            Paciente paciente = _repoPaciente.getPaciente(idPaciente);
            Console.WriteLine(paciente.Nombre + " " + paciente.Apellido);
        }

        private static void AsignarMedico()
        {
            var medico = _repoPaciente.AsignarMedico(1, 2);
            Console.WriteLine(medico.Nombre + " " + medico.Apellidos);
        }
    }
}
