namespace GST;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        using System;
        using GeoShapes;
        using Xunit;

public class FormenTests
    {
        [Fact]
        public void Dreieck_345_hat_Umfang_12_und_Flaeche_6()
        {
            var t = new Dreieck(new Linie(3), new Linie(4), new Linie(5));
            Assert.Equal(12.0, t.BerechneUmfang(), 5);
            Assert.Equal(6.0, t.BerechneFlaeche(), 5);
        }

        [Fact]
        public void Rechteck_2x3_hat_Umfang_10_und_Flaeche_6()
        {
            var r = new Rechteck(new Linie(2), new Linie(3), new Linie(2), new Linie(3));
            Assert.Equal(10.0, r.BerechneUmfang(), 5);
            Assert.Equal(6.0, r.BerechneFlaeche(), 5);
        }

        [Fact]
        public void Behaelter_Regeln_werden_eingehalten()
        {
            var b = new Formenbehaelter();

            Assert.True(b.AddRechteck(new Rechteck(new Linie(1), new Linie(2), new Linie(1), new Linie(2))));
            Assert.True(b.AddRechteck(new Rechteck(new Linie(3), new Linie(4), new Linie(3), new Linie(4))));
            Assert.False(b.AddRechteck(new Rechteck(new Linie(5), new Linie(6), new Linie(5), new Linie(6)))); 

            var k1 = new Kreis(new Linie(2 * Math.PI * 1));
            Assert.True(b.AddKreis(k1));
            Assert.False(b.RemoveKreis(k1));
        }
    }
}
}