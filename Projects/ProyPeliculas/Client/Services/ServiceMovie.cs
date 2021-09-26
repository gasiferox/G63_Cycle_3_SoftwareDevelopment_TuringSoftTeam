using System;
using System.Collections.Generic;
using ProyPeliculas.Shared.Entity;

namespace ProyPeliculas.Client.Services
{
    public class ServiceMovie : IServiceMovie
    {
        public List<Movie> GetMovies()
        {
            return new List<Movie>()
            {
            new Movie(){Name="Archer", Sinopsis="Trama de la película...", Image="/img/poster_archer.jpg", Premier=new DateTime(2021, 10, 15), Category=Category.Accion, Casting=new Casting()},
            new Movie(){Name="Back to the future", Sinopsis="Trama de la película...", Image="/img/poster_backToTheFuture.jpg", Premier=new DateTime(2021, 10, 15), Category=Category.Accion,Casting=new Casting()},
            new Movie(){Name="Joker", Sinopsis="Trama de la película...", Image="/img/poster_joker.jpg", Premier=new DateTime(2021, 10, 15), Category=Category.Suspenso, Casting=new Casting()},
            new Movie(){Name="Wolverine I", Sinopsis="Trama de la película...", Image="/img/poster_wolverine.jpg", Premier=new DateTime(2021, 10, 15), Category=Category.Accion, Casting=new Casting()},
            new Movie(){Name="Wolverine II", Sinopsis="Trama de la película...", Image="/img/poster_wolverine_2.jpg", Premier=new DateTime(2021, 10, 15), Category=Category.Accion, Casting=new Casting()},
            new Movie(){Name="World War Z", Sinopsis="Trama de la película...", Image="/img/poster_worldWarZ.jpg", Premier=new DateTime(2021, 10, 15), Category=Category.Accion, Casting=new Casting()},
            new Movie(){Name="Antman", Sinopsis="Trama de la película...", Image="/img/poster_antman.jpg", Premier=new DateTime(2021, 10, 15), Category=Category.Accion, Casting=new Casting()},
            new Movie(){Name="After", Sinopsis="Trama de la película...", Image="/img/poster_after.jpg", Premier=new DateTime(2021, 10, 15), Category=Category.Terror, Casting=new Casting()},
            new Movie(){Name="Star Trek", Sinopsis="Trama de la película...", Image="/img/poster_starTrek.jpeg", Premier=new DateTime(2021, 10, 15), Category=Category.Accion, Casting=new Casting()},
            new Movie(){Name="Suicide Squad", Sinopsis="Trama de la película...", Image="/img/poster_suicideSquad.jpg", Premier=new DateTime(2021, 10, 15), Category=Category.Accion, Casting=new Casting()}
            };
        }

        public List<Casting> GetCasting()
        {
            return new List<Casting>()
            {
                new Casting(){Director=new Director(), FirstRole=new Actor(), SecondaryRole = new Actor(), SupportingActor = new Actor()}
            };
        }
    }

    
}