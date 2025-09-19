using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio_GeoShapes
{
    public class Linie
    {
        private readonly double laenge;
        public double Laenge => laenge;

        public Linie(double laenge)
        {
            if (laenge <= 0)
                throw new ArgumentOutOfRangeException(nameof(laenge), "Laenge muss > 0 sein.");
            this.laenge = laenge;
        }

        public Linie(int laenge) : this((double)laenge) { }
    }
}