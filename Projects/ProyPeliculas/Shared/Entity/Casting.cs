namespace ProyPeliculas.Shared.Entity
{
    public class Casting
    {
        /* public int IdCasting { get; set; } */
        public Director Director { get; set; }
        public Actor FirstRole { get; set; }
        public Actor SecondaryRole { get; set; }
        public Actor SupportingActor {get; set; }
    }
}