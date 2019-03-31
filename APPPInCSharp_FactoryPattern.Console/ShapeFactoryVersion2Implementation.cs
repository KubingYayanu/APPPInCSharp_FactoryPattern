using System;

namespace APPPInCSharp_FactoryPattern
{
    public class ShapeFactoryVersion2Implementation : ShapeFactoryVersion2
    {
        public Shape Make(string name)
        {
            if (name.Equals("Circle"))
            {
                return new Circle();
            }
            else if (name.Equals("Square"))
            {
                return new Square();
            }
            else
            {
                throw new Exception($"ShapeFactory cannot create: {name}");
            }
        }
    }
}