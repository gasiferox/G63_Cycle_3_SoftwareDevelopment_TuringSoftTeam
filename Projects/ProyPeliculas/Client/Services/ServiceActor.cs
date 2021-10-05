using System;
using System.Collections.Generic;
using ProyPeliculas.Shared.Entity;

namespace ProyPeliculas.Client.Services
{
    public class ServiceActor : IServiceActor
    {
        public List<Actor> GetActors()
        {
            return new List<Actor>()
            {
                new Actor(){IdActor=1, Name="Al", LastName="Pacino", Gender=Gender.Masculino, Birthday= new DateTime(1977, 01, 01), PlaceOfBirth="", ArtisticName="", CareerTime= new DateTime(1990, 01, 01), Photo="/img/actors/profile_alPacino.jpg"},
                new Actor(){IdActor=2, Name="Ana", LastName="De Armas", Gender=Gender.Femenino, Birthday= new DateTime(1977, 01, 01), PlaceOfBirth="", ArtisticName="", CareerTime= new DateTime(1990, 01, 01), Photo="/img/actors/profile_anaDeArmas.jpg"},
                new Actor(){IdActor=3, Name="Dwayne", LastName="Johnnson", Gender=Gender.Masculino, Birthday= new DateTime(1977, 01, 01), PlaceOfBirth="", ArtisticName="The Rock", CareerTime= new DateTime(1990, 01, 01), Photo="/img/actors/profile_dwayneJohnnson.jpg"},
                new Actor(){IdActor=4, Name="Hugh", LastName="Jackman", Gender=Gender.Masculino, Birthday= new DateTime(1968, 10, 12), PlaceOfBirth="Sidney, Australia", ArtisticName="", CareerTime= new DateTime(1990, 01, 01), Photo="/img/actors/profile_hughJackman.jpg"},
                new Actor(){IdActor=5, Name="Johnny", LastName="Depp", Gender=Gender.Masculino, Birthday= new DateTime(1977, 01, 01), PlaceOfBirth="", ArtisticName="", CareerTime= new DateTime(1990, 01, 01), Photo="/img/actors/profile_johnnyDepp.jpg"},
                new Actor(){IdActor=6, Name="Keanu", LastName="Reeves", Gender=Gender.Masculino, Birthday= new DateTime(1977, 01, 01), PlaceOfBirth="", ArtisticName="", CareerTime= new DateTime(1990, 01, 01), Photo="/img/actors/profile_keanuReeves.jpg"},
                new Actor(){IdActor=7, Name="Watkin Tudor", LastName="Jones", Gender=Gender.Masculino, Birthday= new DateTime(1974, 09, 26), PlaceOfBirth="Johannesburg, South Africa", ArtisticName="Ninja", CareerTime= new DateTime(1990, 01, 01), Photo="/img/actors/profile_ninja.jpg"}
            };
        }
    }
}