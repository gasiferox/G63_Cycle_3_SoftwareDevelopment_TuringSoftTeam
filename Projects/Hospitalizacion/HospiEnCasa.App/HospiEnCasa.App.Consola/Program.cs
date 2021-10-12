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

            //AddPaciente();
            BuscarPaciente(2);
            //BorrarPaciente(4);
            //AsignarMedico();
        }

        private static void AddPaciente()
        {
            var paciente = new Paciente
            {
                Nombre = "Luisa",
                Apellido = "Bonilla",
                Telefono = "32123234",
                Genero = Genero.Femenino,
                TipoDocumento = TipoDocumento.CedulaDeCiudadania,
                Documento = "124511567",
                Latitud = 5.022184D,
                Longitud = -72.68953D,
                FechaNacimiento = new DateTime(1999, 02, 08)
            };
            _repoPaciente.AddPaciente(paciente);
            Console.WriteLine("El Paciente, " + paciente.Nombre + " " + paciente.Apellido + " fué agregado con éxito!");
        }

        private static void BuscarPaciente(int idPaciente)
        {
            var paciente = _repoPaciente.GetPaciente(idPaciente);
            Console.WriteLine("Paciente: " + paciente.Nombre + " " + paciente.Apellido);
            Console.WriteLine("Teléfono: " + paciente.Telefono + "\nGénero: " + paciente.Genero);
            Console.WriteLine("Identificación: " + paciente.TipoDocumento + " " + paciente.Documento);
            Console.WriteLine("Geolocalización: (Latitud: " + paciente.Latitud + ", Longitud: " + paciente.Longitud + ")");
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
