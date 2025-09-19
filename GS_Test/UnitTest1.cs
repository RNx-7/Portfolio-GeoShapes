namespace GS_Test

public class UnitTest1
{
    [Fact]
    public void Dreieck_345()
    { var t = new Dreieck(3, 4, 5); Assert.Equal(12, t.BerechneUmfang(), 5); Assert.Equal(6, t.BerechneFlaeche(), 5); }

    [Fact]
    public void Rechteck_2x3()
    { var r = new Rechteck(2, 3); Assert.Equal(10, r.BerechneUmfang(), 5); Assert.Equal(6, r.BerechneFlaeche(), 5); }

    [Fact]
    public void Behaelter_Regeln()
    {
        var b = new Formenbehaelter();
        var r1 = new Rechteck(2, 3); var r2 = new Rechteck(4, 5);
        Assert.True(b.AddRechteck(r1)); Assert.True(b.AddRechteck(r2)); Assert.False(b.AddRechteck(new Rechteck(1, 1)));  // max 2
        var t1 = new Dreieck(3, 4, 5); var t2 = new Dreieck(4, 5, 6); var t3 = new Dreieck(5, 6, 7); var t4 = new Dreieck(6, 7, 8);
        Assert.True(b.AddDreieck(t1)); Assert.True(b.AddDreieck(t2)); Assert.True(b.AddDreieck(t3)); Assert.True(b.AddDreieck(t4)); Assert.False(b.AddDreieck(new Dreieck(7, 8, 9))); // max 4
        var k1 = new Kreis(1); var k2 = new Kreis(2); var k3 = new Kreis(3);
        Assert.True(b.AddKreis(k1)); Assert.False(b.RemoveKreis(k1));  // min 1
        Assert.True(b.AddKreis(k2)); Assert.True(b.AddKreis(k3)); Assert.False(b.AddKreis(new Kreis(4))); // max 3
        Assert.True(b.RemoveKreis(k2)); Assert.True(b.RemoveKreis(k3)); Assert.False(b.RemoveKreis(k1)); // letzter bleibt
    }
}
