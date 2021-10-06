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
                new Actor(){Name="Al", LastName="Pacino", Gender="Masculino", Birthday= new DateTime(1977, 01, 01), PlaceOfBirth="None", ArtisticName="None", CareerTime= new DateTime(1990, 01, 01), Photo="/img/actors/profile_alPacino.jpg"},
                new Actor(){Name="Ana", LastName="De Armas", Gender="Femenino", Birthday= new DateTime(1977, 01, 01), PlaceOfBirth="None", ArtisticName="None", CareerTime= new DateTime(1990, 01, 01), Photo="/img/actors/profile_anaDeArmas.jpg"},
                new Actor(){Name="Dwayne", LastName="Johnnson", Gender="Masculino", Birthday= new DateTime(1977, 01, 01), PlaceOfBirth="None", ArtisticName="The Rock", CareerTime= new DateTime(1990, 01, 01), Photo="/img/actors/profile_dwayneJohnnson.jpg"},
                new Actor(){Name="Hugh", LastName="Jackman", Gender="Masculino", Birthday= new DateTime(1968, 10, 12), PlaceOfBirth="Sidney, Australia", ArtisticName="None", CareerTime= new DateTime(1990, 01, 01), Photo="/img/actors/profile_hughJackman.jpg"},
                new Actor(){Name="Johnny", LastName="Depp", Gender="Masculino", Birthday= new DateTime(1977, 01, 01), PlaceOfBirth="None", ArtisticName="None", CareerTime= new DateTime(1990, 01, 01), Photo="/img/actors/profile_johnnyDepp.jpg"},
                new Actor(){Name="Keanu", LastName="Reeves", Gender="Masculino", Birthday= new DateTime(1977, 01, 01), PlaceOfBirth="None", ArtisticName="None", CareerTime= new DateTime(1990, 01, 01), Photo="/img/actors/profile_keanuReeves.jpg"},
                new Actor(){Name="Watkin Tudor", LastName="Jones", Gender="Masculino", Birthday= new DateTime(1974, 09, 26), PlaceOfBirth="Johannesburg, South Africa", ArtisticName="Ninja", CareerTime= new DateTime(1990, 01, 01), Photo="/img/actors/profile_ninja.jpg"}
            };
        }
    }
}