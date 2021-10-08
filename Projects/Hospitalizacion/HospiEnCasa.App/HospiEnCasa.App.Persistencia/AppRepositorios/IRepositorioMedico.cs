using System;
using System.Collections.Generic;
using System.Linq;
using HospiEnCasa.App.Dominio.Entidades;

namespace HospiEnCasa.App.Persistencia.AppRepositorios
{
    public interface IRepositorioMedico
    {
         Medico AddMedico(Medico medico);
         Medico UpdateMedico(Medico medico);
         void DeleteMedico(int idMedico);
         Medico GetMedico(int idMedico);
         IEnumerable<Medico> GetAllMedicos();
         IEnumerable<Medico> GetAllMedicosEspecialidad();
    }
}