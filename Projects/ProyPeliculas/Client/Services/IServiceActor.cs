using System.Collections.Generic;
using ProyPeliculas.Shared.Entity;

namespace ProyPeliculas.Client.Services
{
    public interface IServiceActor
    {
         List<Actor> GetActors(); 
    }
}