﻿using System;
using System.Collections.Generic;
using HospiEnCasa.App.Persistencia;
using HospiEnCasa.App.Dominio.Entidades;
using HospiEnCasa.App;

namespace HospiEnCasa.App.Consola
{
    public class Program
    {
        private static HospiEnCasa.App.Persistencia.AppRepositorios.IRepositorioPaciente _repoPaciente = new HospiEnCasa.App.Persistencia.AppRepositorios.RepositorioPaciente(new Persistencia.AppContext());

        private static HospiEnCasa.App.Persistencia.AppRepositorios.IRepositorioMedico _repoMedico = new HospiEnCasa.App.Persistencia.AppRepositorios.RepositorioMedico(new Persistencia.AppContext());

        private static HospiEnCasa.App.Persistencia.AppRepositorios.IRepositorioEnfermera _repoEnfermera = new HospiEnCasa.App.Persistencia.AppRepositorios.RepositorioEnfermera(new Persistencia.AppContext());

        public static void Main(string[] args)
        {
            Console.Clear();

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
            //ListarPacientesCorazon();
            //AsignarMedico(5,14);

            //AddMedico();

            AddEnfermera();
            //ListarEnfermeras();
            //ListarEnfermera(13);
            //BorrarEnfermera();
        }

        private static void AddPaciente()
        {
            var paciente = new Paciente
            {
                Nombre = "Yaneth",
                Apellido = "Mejía Rendón",
                TipoDocumento = TipoDocumento.CedulaDeCiudadania,
                Documento = "1.524.325.658",
                Genero = Genero.Femenino,
                FechaNacimiento = new DateTime(1995, 04, 13),
                Latitud = 5.8748784D,
                Longitud = -74.56853D,
                Telefono = "3184526321",
                PlanMedico = PlanMedico.Contributivo,
                FamiliarDesignado = new FamiliarDesignado {
                    Nombre = "Carmenza",
                    Apellido = "Mejía",
                    TipoDocumento = TipoDocumento.Pasaporte,
                    Documento = "P-785412",
                    Genero = Genero.Femenino,
                    Parentesco = "Madre",
                    Correo = "madre_Yaneth@correo.com"
                },
                SignosVitales = new List<SignoVital> {
                    new SignoVital{FechaHora= new DateTime(2021,10,07,22,30,08), TipoSigno=TipoSigno.Oximetria, Valor=92},
                    new SignoVital{FechaHora= new DateTime(2021,10,07,22,30,08), TipoSigno=TipoSigno.FrecuenciaRespiratoria, Valor=52},
                    new SignoVital{FechaHora= new DateTime(2021,10,07,22,30,08), TipoSigno=TipoSigno.FrecuenciaCardiaca, Valor=62},
                    new SignoVital{FechaHora= new DateTime(2021,10,07,22,30,08), TipoSigno=TipoSigno.Temperatura, Valor=32},
                    new SignoVital{FechaHora= new DateTime(2021,10,07,22,30,08), TipoSigno=TipoSigno.PresionArterial, Valor=122},
                    new SignoVital{FechaHora= new DateTime(2021,10,07,22,30,08), TipoSigno=TipoSigno.Glicemia, Valor=102}
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

        private static void AsignarMedico(int idPaciente, int idMedico)
        {
            var medico = _repoPaciente.AsignarMedico(idPaciente, idMedico);
            Console.WriteLine("El médico " + medico.Nombre + " " + medico.Apellido + " ha sido asignado al paciente No. " + "\n");
        }

        /* Médicos */
        public static void AddMedico()
        {
            var medico = new Medico{
                Nombre = "Carlos Hernando",
                Apellido = "Paez Lozano",
                TipoDocumento = TipoDocumento.CedulaDeExtranjeria,
                Documento = "89654123",
                Genero = Genero.Masculino,

                Especialidad = Especialidad.Internista,
                RegistroMedico = "RM-214365"
            };
            _repoMedico.AddMedico(medico);
            Console.WriteLine("El médico " + medico.Nombre + " " + medico.Apellido + " fue agregado con éxito.\n");
        }

        /* Enfermeras */
        public static void AddEnfermera()
        {
            var enfermera = new Enfermera{
                Nombre = "Maria",
                Apellido = "Del Valle",
                TipoDocumento = TipoDocumento.Pasaporte,
                Documento = "P-4753",
                Genero = Genero.Femenino,

                TarjetaProfesional = "TP-82376346234",
                HorasLaborales = 20
            };
            _repoEnfermera.AddEnfermera(enfermera);
            Console.WriteLine("La enfermera " + enfermera.Nombre + " " + enfermera.Apellido + " fué agregada con éxito a la BD de TuringSoft.\n");
        }

        public static void ListarEnfermera(int idEnfermera)
        {
            var enfermera = _repoEnfermera.GetEnfermera(idEnfermera);
            Console.WriteLine("Los datos de la enfermera solicitada son:\n");
            Console.WriteLine("Nombres y Apellidos: " + enfermera.Nombre + " " + enfermera.Apellido);
            Console.WriteLine(enfermera.TipoDocumento + ": " + enfermera.Documento);
            Console.WriteLine("Género: " + enfermera.Genero);
            Console.WriteLine("Tarjeta profesional: " + enfermera.TarjetaProfesional);
            Console.WriteLine("Holas laborales: " + enfermera.HorasLaborales);
            Console.WriteLine("\n");
        }

        public static void ListarEnfermeras()
        {
            var enfermerasL = _repoEnfermera.GetAllEnfermeras();
            foreach (var Enfermera in enfermerasL)
            {
                Console.WriteLine("Enfermera " + Enfermera.Id + ", Nombre: " + Enfermera.Nombre + " " + Enfermera.Apellido + ", con " + Enfermera.HorasLaborales + " Horas de trabajo.\n");
            }
        }

        public static void BorrarEnfermera(int idEnfermera)
        {
            _repoEnfermera.DeleteEnfermera(idEnfermera);
            Console.WriteLine("La enfermera fué eliminada con éxito.\n");
        }
    }
}
