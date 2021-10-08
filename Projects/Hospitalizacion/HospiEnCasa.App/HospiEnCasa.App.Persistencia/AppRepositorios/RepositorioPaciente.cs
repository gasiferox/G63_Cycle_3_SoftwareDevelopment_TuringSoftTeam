using System.Collections;
using System.Collections.Generic;
using System.Linq;
using HospiEnCasa.App.Dominio.Entidades;

namespace HospiEnCasa.App.Persistencia.AppRepositorios
{
    public class RepositorioPaciente : IRepositorioPaciente
    {
        private readonly AppContext _appContext;

        public RepositorioPaciente(AppContext appContext) 
        {
            this._appContext = appContext;
        }

        public Paciente AddPaciente(Paciente paciente)
        {
            var pacienteAdicionado = _appContext.Pacientes.Add(paciente);
            _appContext.SaveChanges();
            return (Paciente)pacienteAdicionado.Entity;
        }

        public void DeletePaciente(int idPaciente)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
            if (pacienteEncontrado == null)
                return;
            _appContext.Pacientes.Remove(pacienteEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Paciente> GetAllPacientes()
        {
            return _appContext.Pacientes;
        }

        public Paciente GetPaciente(int idPaciente)
        {
            return _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
        }

        public Paciente UpdatePaciente(Paciente paciente)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == paciente.Id);
            if (pacienteEncontrado != null)
            {
                pacienteEncontrado.Nombre = paciente.Nombre;
                pacienteEncontrado.Apellido = paciente.Apellido;
                pacienteEncontrado.Telefono = paciente.Telefono;
                pacienteEncontrado.Genero = paciente.Genero;
                pacienteEncontrado.TipoDocumento = paciente.TipoDocumento;
                pacienteEncontrado.Documento = paciente.Documento;
                pacienteEncontrado.Latitud = paciente.Latitud;
                pacienteEncontrado.Longitud = paciente.Longitud;
                pacienteEncontrado.FechaNacimiento = paciente.FechaNacimiento;
/*                pacienteEncontrado.FamiliarDesignado = paciente.FamiliarDesignado;
                pacienteEncontrado.Medico = paciente.Medico;
                pacienteEncontrado.Enfermera = paciente.Enfermera;
                pacienteEncontrado.HistoriaClinica = paciente.HistoriaClinica;
                pacienteEncontrado.SignosVitales = paciente.SignosVitales;
*/
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

        /* Medico IRepositorioPaciente.AsignarMedico(int idPaciente, int idMedico)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
            if (pacienteEncontrado != null)
            {
                var medicoEncontrado = _appContext.medicos.FirstOrDefault(p => p.Id == idMedico);
                if (medicoEncontrado != null)
                {
                    pacienteEncontrado.Medico = medicoEncontrado;
                    _appContext.SaveChanges();
                }return medicoEncontrado;
            }return null;
        } */
    }
}