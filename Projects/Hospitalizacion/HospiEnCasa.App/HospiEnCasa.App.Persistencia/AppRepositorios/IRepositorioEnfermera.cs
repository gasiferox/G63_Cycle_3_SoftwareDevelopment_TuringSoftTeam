using HospiEnCasa.App.Dominio.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace HospiEnCasa.App.Persistencia.AppRepositorios
{
    public interface IRepositorioEnfermera
    {
         Enfermera AddEnfermera(Enfermera Enfermera);
         Enfermera GetEnfermera(int idEnfermera);
         IEnumerable<Enfermera> GetAllEnfermeras();
         void DeleteEnfermera(int idEnfermera);
         Enfermera UpdateEnfermera(Enfermera Enfermera);
    }
}