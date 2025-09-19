using GeoShapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoShapes
{
    /// <summary>Rechteck mit genau vier Linien.</summary>
    public sealed class Rechteck(Linie a, Linie b, Linie c, Linie d) : IGeometrischeForm
    {
        private readonly Linie _a = a ?? throw new ArgumentNullException(nameof(a));
        private readonly Linie _b = b ?? throw new ArgumentNullException(nameof(b));
        private readonly Linie _c = c ?? throw new ArgumentNullException(nameof(c));
        private readonly Linie _d = d ?? throw new ArgumentNullException(nameof(d));

        public bool ImBehaelter { get; internal set; } = false;

        /// <summary>
        /// Overload: erstellt a,b,a,b aus Breite/Höhe und ruft den Primary Constructor auf.
        /// </summary>
        public Rechteck(double breite, double hoehe)
            : this(new Linie(breite), new Linie(hoehe), new Linie(breite), new Linie(hoehe)) { }

        public double BerechneUmfang()
        {
            double la = _a.Laenge, lb = _b.Laenge;
            return 2 * (la + lb);
        }

        public double BerechneFlaeche()
        {
            double la = _a.Laenge, lb = _b.Laenge;
            return la * lb;
        }
    }
}