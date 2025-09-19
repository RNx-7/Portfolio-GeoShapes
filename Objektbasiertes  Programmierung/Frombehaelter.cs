using GeoShapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoShapes;

internal class Formenbehaelter
{
    internal sealed class FormenAddRemove
    {
        private readonly List<Rechteck> _rechtecke = new();
        private readonly List<Dreieck> _dreiecke = new();
        private readonly List<Kreis> _kreise = new();

        public bool AddRechteck(Rechteck rechteck)
        {
            if (rechteck == null) return false;
            if (_rechtecke.Count >= 2) return false;
            if (rechteck.ImBehaelter) return false;

            _rechtecke.Add(rechteck);
            rechteck.ImBehaelter = true;
            return true;
        }

        public bool AddDreieck(Dreieck dreieck)
        {
            if (dreieck == null) return false;
            if (_dreiecke.Count >= 4) return false;
            if (dreieck.ImBehaelter) return false;

            _dreiecke.Add(dreieck);
            dreieck.ImBehaelter = true;
            return true;
        }

        public bool AddKreis(Kreis kreis)
        {
            if (kreis == null) return false;
            if (_kreise.Count >= 3) return false;
            if (kreis.ImBehaelter) return false;

            _kreise.Add(kreis);
            kreis.ImBehaelter = true;
            return true;
        }

        public bool RemoveRechteck(Rechteck rechteck)
        {
            if (rechteck == null) return false;
            if (_rechtecke.Count <= 2) return false;

            bool ok = _rechtecke.Remove(rechteck);
            if (ok) rechteck.ImBehaelter = false;
            return ok;
        }

        public bool RemoveDreieck(Dreieck dreieck)
        {
            if (dreieck == null) return false;
            bool ok = _dreiecke.Remove(dreieck);
            if (ok) dreieck.ImBehaelter = false;
            return ok;
        }

        public bool RemoveKreis(Kreis kreis)
        {
            if (kreis == null) return false;
            if (_kreise.Count <= 1) return false;

            bool ok = _kreise.Remove(kreis);
            if (ok) kreis.ImBehaelter = false;
            return ok;
        }
    }
}
