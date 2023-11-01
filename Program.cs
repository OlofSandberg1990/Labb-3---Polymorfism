namespace Labb_3___Polymorfism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometry circle = new Circle();
            Geometry square = new Square();
            Geometry rectangle = new Rectangle();
            
            circle.Area();
            square.Area();
            rectangle.Area();
                            

            Console.ReadKey();
        }

    }

}


