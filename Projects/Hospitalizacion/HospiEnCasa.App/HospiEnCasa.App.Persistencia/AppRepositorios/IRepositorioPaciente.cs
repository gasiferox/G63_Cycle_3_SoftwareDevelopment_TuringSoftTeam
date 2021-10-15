using System.Linq;
using System.Collections.Generic;
using HospiEnCasa.App.Dominio.Entidades;

namespace HospiEnCasa.App.Persistencia.AppRepositorios
{
    public interface IRepositorioPaciente
    {
        IEnumerable<Paciente> GetAllPacientes();
        Paciente AddPaciente(Paciente paciente);
        Paciente GetPaciente(int idPaciente);
        FamiliarDesignado GetFamiliarDesignado(int idPaciente);
        Medico GetMedicoAsignado(int idPaciente);
        Enfermera GetEnfermeraAsignada(int idPaciente);
        void DeletePaciente(int idPaciente);
        Paciente UpdatePaciente(Paciente paciente);
        
        /* Métodos para filtrar y listar */
        IEnumerable<Paciente> GetAllPacientesFemeninos();
        IEnumerable<Paciente> GetAllPacientesMasculinos();
        IEnumerable<Paciente> GetPacientesCorazon();

        /* Métodos para asignar */
        Medico AsignarMedico(int idPaciente, int idMedico);
        Enfermera AsignarEnfermera(int idPaciente, int idEnfermera);

        /* Nuevas instancias */
        IEnumerable<SignoVital> GetSignosPaciente(int idPaciente);
        /* SignoVital AddSignosPaciente(int idPaciente, SignoVital signoVital); */

        
    }
}