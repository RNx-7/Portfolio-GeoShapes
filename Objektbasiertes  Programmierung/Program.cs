using static GeoShapes.Formenbehaelter;

namespace GeoShapes
{
    public static class Program
    {
        public static void Main(string[] arg)
        {
            var r1 = new Rechteck(10, 18);
            var r2 = new Rechteck(5, 13);
            var d1 = new Dreieck(7, 7, 7);
            var k1 = new Kreis(1);
            var k2 = new Kreis(3);

            var beh = new FormenAddRemove();
            beh.AddRechteck(r1);
            beh.AddRechteck(r2);
            beh.AddDreieck(d1);
            beh.AddKreis(k1);
            beh.AddKreis(k2);

            Console.WriteLine("Im Formenbehälter befinden sich (2 Rechtecke, 1 Dreieck, 2 Kreise).");
        }
    }
}