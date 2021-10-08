using System;
using System.Collections.Generic;
using HospiEnCasa.App.Persistencia;
using HospiEnCasa.App.Dominio.Entidades;
using HospiEnCasa.App;

namespace HospiEnCasa.App.Consola
{
    public class Program
    {
        private static HospiEnCasa.App.Persistencia.AppRepositorios.IRepositorioPaciente _repoPaciente = new HospiEnCasa.App.Persistencia.AppRepositorios.RepositorioPaciente(new Persistencia.AppContext());

        public static void Main(string[] args)
        {
            Console.WriteLine("\n####################################################");
            Console.WriteLine("#                    TuringSoft                    #");
            Console.WriteLine("#         Proyecto Hospitalización en Casa         #");
            Console.WriteLine("# Implementación Base de Datos - Entity Framework  #");
            Console.WriteLine("####################################################\n");

            //AddPaciente();
            //BuscarPaciente(5);
            //BorrarPaciente(6);
            //AddSignosPaciente(7);
            //ListarPacientesFemeninos();
            //ListarPacientesMasculinos();
            ListarPacientesCorazon();
            //AsignarMedico();
        }

        private static void AddPaciente()
        {
            var paciente = new Paciente
            {
                Nombre = "Pepito",
                Apellido = "Perez",
                TipoDocumento = TipoDocumento.CedulaDeExtranjeria,
                Documento = "E-5647483",
                Genero = Genero.Masculino,
                FechaNacimiento = new DateTime(1965, 06, 03),
                Latitud = 6.7648784D,
                Longitud = -78.14753D,
                Telefono = "87964546",
                PlanMedico = PlanMedico.Subsidiado,
                SignosVitales = new List<SignoVital> {
                    new SignoVital{FechaHora= new DateTime(2021,10,07,20,00,00), TipoSigno=TipoSigno.Oximetria, Valor=98},
                    new SignoVital{FechaHora= new DateTime(2021,10,07,20,00,00), TipoSigno=TipoSigno.FrecuenciaRespiratoria, Valor=50},
                    new SignoVital{FechaHora= new DateTime(2021,10,07,20,00,00), TipoSigno=TipoSigno.FrecuenciaCardiaca, Valor=60},
                    new SignoVital{FechaHora= new DateTime(2021,10,07,20,00,00), TipoSigno=TipoSigno.Temperatura, Valor=37},
                    new SignoVital{FechaHora= new DateTime(2021,10,07,20,00,00), TipoSigno=TipoSigno.PresionArterial, Valor=120},
                    new SignoVital{FechaHora= new DateTime(2021,10,07,20,00,00), TipoSigno=TipoSigno.Glicemia, Valor=100}
                }
            };
            _repoPaciente.AddPaciente(paciente);
            Console.WriteLine("El Paciente, " + paciente.Nombre + " " + paciente.Apellido + " fué agregado con éxito por el Equipo TuringSoft\n");
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

        private static void AddSignosPaciente(int idPaciente)
        {
            var paciente = _repoPaciente.GetPaciente(idPaciente);
            if (paciente != null)
            {
                if (paciente.SignosVitales != null)
                {
                    paciente.SignosVitales.Add(
                        new SignoVital { FechaHora = new DateTime(2021, 10, 07, 20, 00, 00), TipoSigno = TipoSigno.Oximetria, Valor = 96 });
                }
                else
                {
                    paciente.SignosVitales = new List<SignoVital> {
                    new SignoVital{FechaHora= new DateTime(2021,10,07,20,00,00), TipoSigno=TipoSigno.Oximetria, Valor=96}
                };
                }
                _repoPaciente.UpdatePaciente(paciente);
            }
            Console.WriteLine("El signo vital " + paciente.SignosVitales + " fué agregado con éxito al paciente " + paciente.Nombre + " " + paciente.Apellido);
        }

        private static void ListarPacientesFemeninos()
        {
            var pacientesF = _repoPaciente.GetAllPacientesFemeninos();
            foreach (Paciente p in pacientesF)
            {
                Console.WriteLine("La paciente No. " + p.Id + " con Nombre: " + p.Nombre + " y Apellido: " + p.Apellido);
            }
        }

        private static void ListarPacientesMasculinos()
        {
            var pacientesM = _repoPaciente.GetAllPacientesMasculinos();
            foreach (Paciente p in pacientesM)
            {
                Console.WriteLine("El paciente No. " + p.Id + " con Nombre: " + p.Nombre + " y Apellido: " + p.Apellido);
            }
        }

        private static void ListarPacientesCorazon()
        {
            var pacientesC = _repoPaciente.GetPacientesCorazon();
            Console.WriteLine("Los pacientes con Frecuencia cardiaca menores a 90 ppm");
            foreach (Paciente p in pacientesC)
            {
                Console.WriteLine("El paciente " + p.Id + " " + p.Nombre + " " + p.Apellido);
            }
        }

        /* private static void AsignarMedico()
        {
            var medico = _repoPaciente.AsignarMedico(1, 2);
            Console.WriteLine(medico.Nombre + " " + medico.Apellido);
        } */
    }
}
