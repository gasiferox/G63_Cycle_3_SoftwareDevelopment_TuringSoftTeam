using System.Collections.Generic;
using ProyPeliculas.Shared.Entity;

namespace ProyPeliculas.Client.Services
{
    public interface IServiceMovie
    {
         List<Movie> GetMovies();

         /* Se define como una nueva clase dentro de entity */
         List<Casting> GetCasting(); 
    }
}