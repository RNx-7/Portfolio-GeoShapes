using static Portfolio_GeoShapes.Formenbehaelter;

namespace Portfolio_GeoShapes
{
    public static class Program
    {
        public static void Main()
        {
            var r1 = new Rechteck(10, 18);
            var r2 = new Rechteck(5, 13);
            var d1 = new Dreieck(7, 7, 7);
            var k1 = new Kreis(1);
            var k2 = new Kreis(3);

            var fb = new FormenAddRemove();
            fb.AddRechteck(r1);
            fb.AddRechteck(r2);
            fb.AddDreieck(d1);
            fb.AddKreis(k1);
            fb.AddKreis(k2);

            Console.WriteLine("Im Formenbehälter befinden sich: \n2 Rechtecke, 1 Dreieck, 2 Kreise");
        }
    }
}