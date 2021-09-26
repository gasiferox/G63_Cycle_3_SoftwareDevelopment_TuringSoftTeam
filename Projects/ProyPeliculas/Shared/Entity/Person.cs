using System;
namespace ProyPeliculas.Shared.Entity
{
    public class Person
    {
        /* public int IdPerson { get; set; } */
        public string Name { get; set; } 
        public string LastName { get; set; }
        public Gender Gender {get; set;}
        public DateTime Birthday { get; set; }
        public string PlaceOfBirth { get; set; }

    }

    public enum Gender
    {
        Masculino = 0,
        Femenino = 1,
        Otro = 2
    }
}