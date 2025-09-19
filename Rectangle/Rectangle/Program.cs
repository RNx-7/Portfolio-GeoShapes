using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }


        public class Rectangle
        {
            public string name = "rectangle";
            private readonly int width;
            private readonly int height;
            private  int length = 12;
            public string color = "red";
            

        }

        Rectangle rectangle = new Rectangle();
        Rectangle rectangle1 = new Rectangle();
        Rectangle rectangle2 = new Rectangle();


        
        
        
    }
}





internal class Vater
{
    private Kind kind;


    public void SetKind(Kind kind)
    {
        this.kind = kind;
    }
}






internal class Kind
{
    private Vater vater;


    public void  SetVater(Vater vater)
    {
        this.vater = vater;
    }
}

