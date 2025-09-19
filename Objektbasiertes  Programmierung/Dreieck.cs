using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoShapes
{
    public sealed class Dreieck : IGeometrischeForm
    {
        readonly Linie a, b, c;
        public bool ImBehaelter { get; internal set; }

        public Dreieck(Linie a, Linie b, Linie c)
        {
            this.a = a ?? throw new ArgumentNullException(nameof(a));
            this.b = b ?? throw new ArgumentNullException(nameof(b));
            this.c = c ?? throw new ArgumentNullException(nameof(c));
            double la = this.a.Laenge, lb = this.b.Laenge, lc = this.c.Laenge;
            if (la <= 0 || lb <= 0 || lc <= 0) throw new ArgumentOutOfRangeException("Seitenlängen müssen > 0 sein.");
            if (la + lb <= lc || la + lc <= lb || lb + lc <= la) throw new ArgumentException("Dreiecksungleichung verletzt.");
        }

        public Dreieck(double a, double b, double c) : this(new Linie(a), new Linie(b), new Linie(c)) { }

        public double BerechneUmfang() => a.Laenge + b.Laenge + c.Laenge;

        public double BerechneFlaeche()
        {
            double la = a.Laenge, lb = b.Laenge, lc = c.Laenge, s = (la + lb + lc) / 2.0;
            double u = s * (s - la) * (s - lb) * (s - lc);
            if (u <= 0) throw new InvalidOperationException("Länge ungültig für ein Dreieck.");
            return Math.Sqrt(u);
        }
    }
}