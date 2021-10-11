using System.Collections;
using System.Collections.Generic;
using System.Linq;
using HospiEnCasa.App.Dominio.Entidades;

namespace HospiEnCasa.App.Persistencia.AppRepositorios
{
    public class RepositorioMedico : IRepositorioMedico
    {
        private readonly AppContext _appContext;
        
        public RepositorioMedico(AppContext appContext)
        {
            this._appContext = appContext;
        }

        public Medico AddMedico(Medico medico)
        {
            var medicoAdicionado = _appContext.Medicos.Add(medico);
            _appContext.SaveChanges();
            return (Medico)medicoAdicionado.Entity;
        }

        public IEnumerable<Medico> GetAllMedicos()
        {
            return _appContext.Medicos;
        }

        public void DeleteMedico(int idMedico)
        {
            var medicoEncontrado = _appContext.Medicos.FirstOrDefault(p => p.Id == idMedico);
            if (medicoEncontrado == null)
            {
                return;
            }
            _appContext.Medicos.Remove(medicoEncontrado);
            _appContext.SaveChanges();
        }

        public Medico UpdateMedico(Medico medico)
        {
            var medicoEncontrado = _appContext.Medicos.FirstOrDefault(p => p.Id == medico.Id);
            if (medicoEncontrado != null)
            {
                medicoEncontrado.Nombre = medico.Nombre;
                medicoEncontrado.Apellido = medico.Apellido;
                medicoEncontrado.TipoDocumento = medico.TipoDocumento;
                medicoEncontrado.Documento = medico.Documento;
                medicoEncontrado.Genero = medico.Genero;

                medicoEncontrado.Especialidad = medico.Especialidad;
                medicoEncontrado.RegistroMedico = medico.RegistroMedico;

                _appContext.SaveChanges();
            }
            return medicoEncontrado;
        }

        public Medico GetMedico(int idMedico)
        {
            return _appContext.Medicos.FirstOrDefault(p => p.Id == idMedico);
        }

        public IEnumerable<Medico> GetAllMedicosEspecialidad()
        {
            return _appContext.Medicos.Where(p => p.Especialidad == Especialidad.Cardiologo).ToList();
        }
    }
}