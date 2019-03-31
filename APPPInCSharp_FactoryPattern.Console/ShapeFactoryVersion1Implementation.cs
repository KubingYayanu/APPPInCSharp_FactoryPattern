namespace APPPInCSharp_FactoryPattern
{
    public class ShapeFactoryVersion1Implementation : ShapeFactoryVersion1
    {
        public Shape MakeCircle() => new Circle();

        public Shape MakeSquare() => new Square();
    }
}