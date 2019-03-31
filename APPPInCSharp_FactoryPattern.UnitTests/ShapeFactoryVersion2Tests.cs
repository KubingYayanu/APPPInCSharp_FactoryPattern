using NUnit.Framework;

namespace APPPInCSharp_FactoryPattern.UnitTests
{
    [TestFixture]
    public class ShapeFactoryVersion2Tests
    {
        private ShapeFactoryVersion2 factory = new ShapeFactoryVersion2Implementation();

        [Test]
        public void TestCreateCircle()
        {
            Shape s = factory.Make("Circle");
            Assert.IsTrue(s is Circle);
        }
    }
}