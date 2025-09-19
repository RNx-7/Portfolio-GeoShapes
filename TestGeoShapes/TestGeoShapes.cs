using Xunit;
using Portfolio_GeoShapes;

namespace TestGeoShapes
{
    public class TestGeoShapes
    {

        [Fact]
        public void DreieckUmfangFlaecheTest()
        {
            var d = new Dreieck(3, 4, 5);
            Assert.Equal(12.0, d.BerechneUmfang(), 5); 
            Assert.Equal(6, d.BerechneFlaeche(), 5); 
        }

        [Fact]
        public void RechteckUmfangFlaecheTest()
        {
            var r = new Rechteck(2, 3);
            Assert.Equal(10.0, r.BerechneUmfang(), 5); 
            Assert.Equal(6.0, r.BerechneFlaeche(), 5); 
        }

        [Fact]
        public void Formenbehaelter_haelt_Mengenregeln_ein()
        {
            var fb = new Formenbehaelter();

            var r1 = new Rechteck(5, 12);
            var r2 = new Rechteck(34, 35);
            Assert.True(fb.AddRechteck(r1));
            Assert.True(fb.AddRechteck(r2));
            Assert.False(fb.AddRechteck(new Rechteck(1, 1)));
            Assert.False(fb.RemoveRechteck(r1));
            Assert.True(fb.AddDreieck(new Dreieck(8, 8, 8)));
            Assert.True(fb.AddDreieck(new Dreieck(4, 4, 6)));
            Assert.True(fb.AddDreieck(new Dreieck(5, 6, 5)));
            Assert.True(fb.AddDreieck(new Dreieck(6, 7, 8)));
            Assert.False(fb.AddDreieck(new Dreieck(7, 8, 9)));

            var k1 = new Kreis(1);
            var k2 = new Kreis(2);
            var k3 = new Kreis(3);
            Assert.True(fb.AddKreis(k1));
            Assert.False(fb.RemoveKreis(k1));
            Assert.True(fb.AddKreis(k2));
            Assert.True(fb.AddKreis(k3));
            Assert.False(fb.AddKreis(k3));
            Assert.True(fb.RemoveKreis(k2));
            Assert.True(fb.RemoveKreis(k3));
            Assert.False(fb.RemoveKreis(k1));
        }
    }
}