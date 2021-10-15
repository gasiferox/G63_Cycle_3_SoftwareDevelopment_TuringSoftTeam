using System;
using HospiEnCasa.App.Dominio.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace HospiEnCasa.App.Persistencia.AppRepositorios
{
    public class RepositorioEnfermera : IRepositorioEnfermera
    {
        private readonly AppContext _appContext;

        public RepositorioEnfermera(AppContext appContext)
        {
            this._appContext = appContext;
        }
        public Enfermera AddEnfermera(Enfermera enfermera)
        {
            var enfermeraAgregada = _appContext.Enfermeras.Add(enfermera);
            _appContext.SaveChanges();
            return (Enfermera)enfermeraAgregada.Entity;
        }
        public Enfermera GetEnfermera(int idEnfermera)
        {
            var enfermeraEncontrada = _appContext.Enfermeras.FirstOrDefault(p => p.Id == idEnfermera);
            return enfermeraEncontrada;
        }public IEnumerable<Enfermera> GetAllEnfermeras()
        {
            return _appContext.Enfermeras;
        }
        public void DeleteEnfermera(int idEnfermera)
        {
            var enfermeraEncontrada = _appContext.Enfermeras.FirstOrDefault(p => p.Id == idEnfermera);
            if (enfermeraEncontrada == null)
            {
                return;
            }
            _appContext.Enfermeras.Remove(enfermeraEncontrada);
            _appContext.SaveChanges();
        }
        public Enfermera UpdateEnfermera(Enfermera enfermera)
        {
            var enfermeraEncontrada = _appContext.Enfermeras.FirstOrDefault(p => p.Id == enfermera.Id);
            if (enfermeraEncontrada != null)
            {
                enfermeraEncontrada.Nombre = enfermera.Nombre;
                enfermeraEncontrada.Apellido = enfermera.Apellido;
                enfermeraEncontrada.TipoDocumento = enfermera.TipoDocumento;
                enfermeraEncontrada.Documento = enfermera.Documento;
                enfermeraEncontrada.Genero = enfermera.Genero;
                enfermeraEncontrada.Foto = enfermera.Foto;

                enfermeraEncontrada.TarjetaProfesional = enfermera.TarjetaProfesional;
                enfermeraEncontrada.HorasLaborales = enfermera.HorasLaborales;

                _appContext.SaveChanges();
            }
            return enfermeraEncontrada;
        }
        
    }
}