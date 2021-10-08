using System;
using HospiEnCasa.App.Persistencia;
using HospiEnCasa.App.Dominio.Entidades;
using HospiEnCasa.App;

namespace HospiEnCasa.App.Consola
{
    public class Program
    {
        private static HospiEnCasa.App.Persistencia.AppRepositorios.IRepositorioPaciente  _repoPaciente = new HospiEnCasa.App.Persistencia.AppRepositorios.RepositorioPaciente(new Persistencia.AppContext());

        public static void Main(string[] args)
        {
            Console.WriteLine("\n####################################################");
            Console.WriteLine("#                    TuringSoft                    #");
            Console.WriteLine("#         Proyecto Hospitalización en Casa         #");
            Console.WriteLine("# Implementación Base de Datos - Entity Framework  #");
            Console.WriteLine("####################################################\n");

            AddPaciente();
            //BuscarPaciente(5);
            //BorrarPaciente(4);
            //AsignarMedico();
        }

        private static void AddPaciente()
        {
            var paciente = new Paciente
            {
                Nombre = "Andrey",
                Apellido = "Bonilla",
                Telefono = "5478551",
                Genero = Genero.Masculino,
                TipoDocumento = TipoDocumento.CedulaDeCiudadania,
                Documento = "474515",
                Latitud = 5.478784D,
                Longitud = -74.14753D,
                FechaNacimiento = new DateTime(1999, 06, 30)
            };
            _repoPaciente.AddPaciente(paciente);
            Console.WriteLine("El Paciente, " + paciente.Nombre + " " + paciente.Apellido + " fué agregado con éxito por el Equipo TuringSoft");
        }

        private static void BuscarPaciente(int idPaciente)
        {
            var paciente = _repoPaciente.GetPaciente(idPaciente);
            Console.WriteLine("Paciente: " + paciente.Nombre + " " + paciente.Apellido);
            Console.WriteLine("Teléfono: " + paciente.Telefono + "\nGénero: " + paciente.Genero);
            Console.WriteLine("Identificación: " + paciente.TipoDocumento + " " + paciente.Documento);
            Console.WriteLine("Geolocalización: ( " + paciente.Latitud + ", " + paciente.Longitud + " )");
            Console.WriteLine("Fecha de Nacimiento: " + paciente.FechaNacimiento);
        }

        private static void BorrarPaciente(int idPaciente)
        {
            _repoPaciente.DeletePaciente(idPaciente);
            Console.WriteLine("Paciente eliminádo con éxito!");
        }

        private static void AsignarMedico()
        {
            var medico = _repoPaciente.AsignarMedico(1, 2);
            Console.WriteLine(medico.Nombre + " " + medico.Apellido);
        }
    }
}
