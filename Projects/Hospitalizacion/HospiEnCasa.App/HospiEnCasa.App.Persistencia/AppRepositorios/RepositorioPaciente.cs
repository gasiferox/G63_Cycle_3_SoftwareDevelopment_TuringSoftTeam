using System;
using System.Collections.Generic;
using System.Linq;
using HospiEnCasa.App.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace HospiEnCasa.App.Persistencia.AppRepositorios
{
    public class RepositorioPaciente : IRepositorioPaciente
    {
        private readonly AppContext _appContext;

        public RepositorioPaciente(AppContext appContext)
        {
            this._appContext = appContext;
        }

        public IEnumerable<Paciente> GetAllPacientes()
        {
            return GetAllPacientes_();
        }

        public IEnumerable<Paciente> GetAllPacientes_()
        {
            return _appContext.Pacientes;
        }

        public Paciente AddPaciente(Paciente paciente)
        {
            var pacienteAdicionado = _appContext.Pacientes.Add(paciente);
            _appContext.SaveChanges();
            return (Paciente)pacienteAdicionado.Entity;
        }

        public Paciente GetPaciente(int idPaciente)
        {
            return _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
        }

        public void DeletePaciente(int idPaciente)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
            if (pacienteEncontrado == null)
                return;
            _appContext.Pacientes.Remove(pacienteEncontrado);
            _appContext.SaveChanges();
        }

        public Paciente UpdatePaciente(Paciente paciente)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == paciente.Id);
            if (pacienteEncontrado != null)
            {
                pacienteEncontrado.Nombre = paciente.Nombre;
                pacienteEncontrado.Apellido = paciente.Apellido;
                pacienteEncontrado.TipoDocumento = paciente.TipoDocumento;
                pacienteEncontrado.Documento = paciente.Documento;
                pacienteEncontrado.Genero = paciente.Genero;

                pacienteEncontrado.FechaNacimiento = paciente.FechaNacimiento;
                pacienteEncontrado.Latitud = paciente.Latitud;
                pacienteEncontrado.Longitud = paciente.Longitud;
                pacienteEncontrado.Telefono = paciente.Telefono;
                pacienteEncontrado.PlanMedico = paciente.PlanMedico;
                pacienteEncontrado.FamiliarDesignado = paciente.FamiliarDesignado;
                pacienteEncontrado.Enfermera = paciente.Enfermera;
                pacienteEncontrado.Medico = paciente.Medico;
                pacienteEncontrado.HistoriaClinica = paciente.HistoriaClinica;
                pacienteEncontrado.SignosVitales = paciente.SignosVitales;

                _appContext.SaveChanges();
            }
            return pacienteEncontrado;
        }

        IEnumerable<Paciente> IRepositorioPaciente.GetAllPacientesFemeninos()
        {
            return _appContext.Pacientes.Where(p => p.Genero == Genero.Femenino).ToList();
        }

        IEnumerable<Paciente> IRepositorioPaciente.GetAllPacientesMasculinos()
        {
            return _appContext.Pacientes.Where(p => p.Genero == Genero.Masculino).ToList();
        }

        IEnumerable<Paciente> IRepositorioPaciente.GetPacientesCorazon()
        {
            return _appContext.Pacientes.Where(p => p.SignosVitales.Any(s => TipoSigno.FrecuenciaCardiaca == s.TipoSigno && s.Valor <= 90)).ToList();
        }

        Medico IRepositorioPaciente.AsignarMedico(int idPaciente, int idMedico)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
            if (pacienteEncontrado != null)
            {
                var medicoEncontrado = _appContext.Medicos.FirstOrDefault(p => p.Id == idMedico);
                if (medicoEncontrado != null)
                {
                    pacienteEncontrado.Medico = medicoEncontrado;
                    _appContext.SaveChanges();
                }
                return medicoEncontrado;
            }
            return null;
        }

        IEnumerable<SignoVital> IRepositorioPaciente.GetSignosPaciente(int idPaciente)
        {
            var paciente = _appContext.Pacientes.Where(s => s.Id == idPaciente).Include(s => s.SignosVitales).FirstOrDefault();
            return paciente.SignosVitales;
        }

        /* SignoVital IRepositorioPaciente.AddSignosPaciente(int idPaciente, SignoVital signoVital)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
            if (pacienteEncontrado != null)
            {
                var nuevoSignoVital = _appContext.SignosVitales.FirstOrDefault(p => p.SignosVitales == signoVital);
                if (nuevoSignoVital != null)
                {
                    pacienteEncontrado.SignosVitales = nuevoSignoVital;
                    _appContext.SaveChanges();
                }
                return signoVital;
            }
            return null;
        } */
    }
}