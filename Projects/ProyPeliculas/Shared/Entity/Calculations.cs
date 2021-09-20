using System;

namespace ProyPeliculas.Shared.Entity
{
    public class Calculations
    {
        public double Principal { get; set; }
        public double InterestRate { get; set; } = 4;
        public int Years { get; set; } = 10;
        public double total { get; set;} = 0;
        public string Total { get; set; }

        public void Calculate()
        {
            var total = Principal * Math.Pow(1 + InterestRate / (1200.0), Years * 12);
            Total = total.ToString("C");
        }
    }
}