using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio_GeoShapes
{
    public interface IGeometrischeForm
    {
        public double BerechneFlaeche();


        public double BerechneUmfang();

    }

}