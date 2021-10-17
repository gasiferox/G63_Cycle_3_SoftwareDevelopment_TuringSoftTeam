using System;
using HospiEnCasa.App.Dominio.Entidades;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HospiEnCasa.App.Persistencia.AppRepositorios
{
    public class RepositorioFamiliar : IRepositorioFamiliar
    {
        private readonly AppContext _appContext;
        public RepositorioFamiliar(AppContext appContext)
        {
            this._appContext = appContext;
        }
        public FamiliarDesignado AddFamiliarDesignado(FamiliarDesignado familiarDesignado)
        {
            var familiarAgregado = _appContext.Add(familiarDesignado);
            _appContext.SaveChanges();
            return (FamiliarDesignado) familiarAgregado.Entity;
        }
         public FamiliarDesignado GetFamiliarDesignado(int idFamiliarDesignado)
         {
             var familiarEncontrado = _appContext.FamiliaresDesignados.FirstOrDefault(p => p.Id == idFamiliarDesignado);
             return familiarEncontrado;
         }
         public IEnumerable<FamiliarDesignado> GetAllFamiliaresDesignados()
         {
             return _appContext.FamiliaresDesignados;
         }
         public void DeleteFamiliarDesignado(int idFamiliarDesignado)
         {
             var familiarEncontrado = _appContext.FamiliaresDesignados.FirstOrDefault(p => p.Id == idFamiliarDesignado);
             if (familiarEncontrado == null)
             {
                 return;
             }
             _appContext.FamiliaresDesignados.Remove(familiarEncontrado);
             _appContext.SaveChanges();
         }
         public FamiliarDesignado UpdateFamiliarDesignado(FamiliarDesignado familiarDesignado)
         {
             var familiarEncontrado = _appContext.FamiliaresDesignados.FirstOrDefault(p => p.Id == familiarDesignado.Id);
             if (familiarEncontrado != null)
             {
                familiarEncontrado.Nombre = familiarDesignado.Nombre;
                familiarEncontrado.Apellido = familiarDesignado.Apellido;
                familiarEncontrado.TipoDocumento = familiarDesignado.TipoDocumento;
                familiarEncontrado.Documento = familiarDesignado.Documento;
                familiarEncontrado.Genero = familiarDesignado.Genero;
                familiarEncontrado.Foto = familiarDesignado.Foto;

                familiarEncontrado.Parentesco = familiarDesignado.Parentesco;
                familiarEncontrado.Correo = familiarDesignado.Correo;

                _appContext.SaveChanges();
             }
             return familiarEncontrado;
         }
    }
}