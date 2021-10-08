using System;
using System.Collections.Generic;
using System.Linq;
using HospiEnCasa.App.Dominio.Entidades;

namespace HospiEnCasa.App.Persistencia.AppRepositorios
{
    public class RepositorioMedico : IRepositorioMedico
    {
        private readonly AppContext _appContext;
        
        public RepositorioMedico(AppContext _appContext)
        {
            this._appContext = appContext;
        }

        public Medico AddMedico(Medico medico)
        {
            var medicoAdicionado = _appContext.Medicos.Add(medico);
            _appContext.SaveChanges();
            return (medico)medicoAdicionado.Entity;
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

        public IEnumerable<Medico> GetMedico(int idMedico)
        {
            return _appContext.Medicos.FirstOrDefault(p => p.Id == idMedico);
        }

        public Medico UpdateMedico(Medico medico)
        {
            var medicoEncontrado = _appContext.Medicos.FirstOrDefault(p => p.Id == idMedico);
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
    }
}