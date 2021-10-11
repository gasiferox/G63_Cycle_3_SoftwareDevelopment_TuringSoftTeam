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
        public IEnumerable<Enfermera> GetAllEnfermeras()
        {
            return _appContext.Enfermeras;
        }
        /* void DeleteEnfermera(int idEnfermera);
        Enfermera UpdateEnfermera(Enfermera Enfermera);
        Enfermera GetEnfermera(int idEnfermera); */
    }
}