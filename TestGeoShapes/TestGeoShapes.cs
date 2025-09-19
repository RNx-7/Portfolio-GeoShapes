using Xunit;
using Portfolio_GeoShapes;

namespace TestGeoShapes
{
    public class TestGeoShapes
    {

        [Fact]
        public void Dreieck_345_Umfang_und_Flaeche_stimmen()
        {
            var t = new Dreieck(3, 4, 5);
            Assert.Equal(12.0, t.BerechneUmfang(), 5); 
            Assert.Equal(6.0, t.BerechneFlaeche(), 5); 
        }

        [Fact]
        public void Rechteck_2x3_Umfang_und_Flaeche_stimmen()
        {
            var r = new Rechteck(2, 3);
            Assert.Equal(10.0, r.BerechneUmfang(), 5); 
            Assert.Equal(6.0, r.BerechneFlaeche(), 5); 
        }

        [Fact]
        public void Formenbehaelter_haelt_Mengenregeln_ein()
        {
            var b = new Formenbehaelter();

            var r1 = new Rechteck(2, 3);
            var r2 = new Rechteck(4, 5);
            Assert.True(b.AddRechteck(r1));
            Assert.True(b.AddRechteck(r2));
            Assert.False(b.AddRechteck(new Rechteck(1, 1)));
            Assert.False(b.RemoveRechteck(r1));
            Assert.True(b.AddDreieck(new Dreieck(3, 4, 5)));
            Assert.True(b.AddDreieck(new Dreieck(4, 5, 6)));
            Assert.True(b.AddDreieck(new Dreieck(5, 6, 7)));
            Assert.True(b.AddDreieck(new Dreieck(6, 7, 8)));
            Assert.False(b.AddDreieck(new Dreieck(7, 8, 9)));

            var k1 = new Kreis(1);
            var k2 = new Kreis(2);
            var k3 = new Kreis(3);
            Assert.True(b.AddKreis(k1));
            Assert.False(b.RemoveKreis(k1));
            Assert.True(b.AddKreis(k2));
            Assert.True(b.AddKreis(k3));
            Assert.False(b.AddKreis(new Kreis(4)));
            Assert.True(b.RemoveKreis(k2));
            Assert.True(b.RemoveKreis(k3));
            Assert.False(b.RemoveKreis(k1));
        }
    }
}