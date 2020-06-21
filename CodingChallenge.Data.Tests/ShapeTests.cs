using CodingChallenge.Data.Classes.Shapes;
using CodingChallenge.Data.Interfaces;
using NUnit.Framework;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    class ShapeTests
    {

        [TestCase]
        public void TestAreaCirculo()
        {
            //Arrenge
            IShape circulo = new Circulo(10);

            //Act
            decimal area = circulo.GetArea();

            //Assert
            Assert.AreEqual(78.54, area);
        }

        [TestCase]
        public void TestPerimetroCirculo()
        {
            //Arrenge
            IShape circulo = new Circulo(10);

            //Act
            decimal perimetro = circulo.GetPerimetro();

            //Assert
            Assert.AreEqual(31.42, perimetro);
        }


        [TestCase]
        public void TestAreaCuadrado()
        {
            //Arrenge
            IShape cuadrado = new Cuadrado(5);

            //Act
            decimal area = cuadrado.GetArea();

            //Assert
            Assert.AreEqual(25, area);
        }

        [TestCase]
        public void TestPerimetroCuadrado()
        {
            //Arrenge
            IShape cuadrado = new Cuadrado(5);

            //Act
            decimal perimetro = cuadrado.GetPerimetro();

            //Assert
            Assert.AreEqual(20, perimetro);
        }


        [TestCase]
        public void TestAreaTrianguloEquilatero()
        {
            //Arrenge
            IShape trianguloEquilatero = new TrianguloEquilatero(8);

            //Act
            decimal area = trianguloEquilatero.GetArea();

            //Assert
            Assert.AreEqual(27.71, area);
        }

        [TestCase]
        public void TestPerimetroTrianguloEquilatero()
        {
            //Arrenge
            IShape trianguloEquilatero = new TrianguloEquilatero(8);

            //Act
            decimal perimetro = trianguloEquilatero.GetPerimetro();

            //Assert
            Assert.AreEqual(24.00, perimetro);
        }


        [TestCase]
        public void TestAreaTrapecioRectangulo()
        {
            //Arrenge
            IShape trapecio = new TrapecioRectangulo(5, 4, 3, 3.2m);

            //Act
            decimal area = trapecio.GetArea();

            //Assert
            Assert.AreEqual(13.5, area);
        }

        [TestCase]
        public void TestPerimetroTrapecioRectangulo()
        {
            //Arrenge
            IShape trapecio = new TrapecioRectangulo(5, 4, 3, 3.2m);

            //Act
            decimal perimetro = trapecio.GetPerimetro();

            //Assert
            Assert.AreEqual(15.2, perimetro);
        }
    }
}
