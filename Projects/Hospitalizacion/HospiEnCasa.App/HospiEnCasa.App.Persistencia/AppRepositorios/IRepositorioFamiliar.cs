using HospiEnCasa.App.Dominio.Entidades;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HospiEnCasa.App.Persistencia.AppRepositorios
{
    public interface IRepositorioFamiliar
    {
         FamiliarDesignado AddFamiliarDesignado(FamiliarDesignado FamiliarDesignado);
         FamiliarDesignado GetFamiliarDesignado(int idFamiliarDesignado);
         IEnumerable<FamiliarDesignado> GetAllFamiliaresDesignados();
         void DeleteFamiliarDesignado(int idFamiliarDesignado);
         FamiliarDesignado UpdateFamiliarDesignado(FamiliarDesignado FamiliarDesignado);
    }
}