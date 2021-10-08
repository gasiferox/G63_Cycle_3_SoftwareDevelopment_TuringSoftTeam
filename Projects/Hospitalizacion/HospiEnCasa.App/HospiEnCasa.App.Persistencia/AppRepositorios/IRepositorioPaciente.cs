using System.Collections;
using System.Linq;
using System.Collections.Generic;
using HospiEnCasa.App.Dominio.Entidades;

namespace HospiEnCasa.App.Persistencia.AppRepositorios
{
    public interface IRepositorioPaciente
    {
        IEnumerable<Paciente> GetAllPacientes();
        Paciente AddPaciente(Paciente paciente);
        Paciente UpdatePaciente(Paciente paciente);
        void DeletePaciente(int idPaciente);
        Paciente GetPaciente(int idPaciente);
        /* Métodos para filtrar y listar */
        IEnumerable<Paciente> GetAllPacientesFemeninos();
        IEnumerable<Paciente> GetAllPacientesMasculinos();
        IEnumerable<Paciente> GetPacientesCorazon();
    }
}