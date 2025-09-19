using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoShapes
{
    public sealed class Kreis(Linie umfang) : IGeometrischeForm
    {
        private readonly Linie _umfang = umfang ?? throw new ArgumentNullException(nameof(umfang));

        public bool ImBehaelter { get; internal set; } = false;

        // weiterer, delegierender Konstruktor bleibt ganz normal möglich
        public Kreis(double radius) : this(new Linie(2.0 * Math.PI * radius)) { }

        public double BerechneUmfang() => _umfang.Laenge;

        public double BerechneFlaeche()
        {
            double r = _umfang.Laenge / (2.0 * Math.PI);
            return Math.PI * r * r;
        }
    }
}