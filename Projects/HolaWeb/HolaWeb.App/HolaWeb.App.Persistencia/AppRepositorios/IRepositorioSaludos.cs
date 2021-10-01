using System.Collections.Generic;
using HolaWeb.App.Dominio.Entity;

namespace HolaWeb.App.Persistencia.AppRepositorios
{
    public interface IRepositorioSaludos
    {
        IEnumerable<Saludo> GetAll();
        Saludo GetSaludoPorId(int IdSaludo);
    }
}