using Portfolio_GeoShapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio_GeoShapes
{
    public class Dreieck : IGeometrischeForm
    {
        readonly Linie a, b, c;
        public bool ImBehaelter { get; internal set; }

        public Dreieck(Linie a, Linie b, Linie c)
        {
            this.a = a ?? throw new ArgumentNullException(nameof(a));
            this.b = b ?? throw new ArgumentNullException(nameof(b));
            this.c = c ?? throw new ArgumentNullException(nameof(c));
            double la = this.a.Laenge, lb = this.b.Laenge, lc = this.c.Laenge;
            if (la <= 0)
                throw new ArgumentOutOfRangeException(nameof(a), la, "Linie darf nicht kleiner als 0 sein.");
            if (lb <= 0)
                throw new ArgumentOutOfRangeException(nameof(b), lb, "Linie darf nicht kleiner als 0 sein.");
            if (lc <= 0)
                throw new ArgumentOutOfRangeException(nameof(c), lc, "Linie darf nicht kleiner als 0 sein.");
            if (la + lb <= lc || la + lc <= lb || lb + lc <= la) throw new ArgumentException("So gehts nicht, versuchs mit anderen Zahlen.");
        }

        public Dreieck(double a, double b, double c) : this(new Linie(a), new Linie(b), new Linie(c)) { }


        /// <summary>Berechnet den Umfang des Dreiecks: a+b+c.</summary>
        /// <returns>Umfang.</returns>
        /// public double BerechneUmfang() { /* ... */ } // Dreieck

        public double BerechneUmfang() => a.Laenge + b.Laenge + c.Laenge;


        /// <summary>Berechnet die Flaeche des Dreiecks mit Heron: s=(a+b+c)/2, Flaeche = wurzel von(s*(s-a)*(s-b)*(s-c)).</summary>
        /// <returns>Flaeche > 0.</returns>
        /// <exception cref="InvalidOperationException">Wenn die Seiten kein gueltiges Dreieck bilden.</exception>
        /// public double BerechneFlaeche() { /* ... */ } // Dreieck

        public double BerechneFlaeche()
        {
            double la = a.Laenge, lb = b.Laenge, lc = c.Laenge, s = (la + lb + lc) / 2.0;
            double u = s * (s - la) * (s - lb) * (s - lc);
            if (u <= 0) throw new InvalidOperationException("Ueberpruefe nochmal deine Angaben fuer das Dreieck.");
            return Math.Sqrt(u);
        }
    }
}