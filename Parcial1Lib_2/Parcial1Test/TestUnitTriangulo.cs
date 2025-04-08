using Parcial1Lib_2;

namespace Parcial1Test;

[TestClass]
public class TestUnitTriangulo
{
    [TestMethod]
    public void TestAreaTriangulo()
    {
        decimal base_ = 5;
        decimal altura = 10;
        Triangulo triangulo = new Triangulo(base_, altura);

        decimal area = triangulo.area();

        decimal areaEsperada = 25;
        Assert.AreEqual(areaEsperada, area);
    }

    public void TestPerimetroTriangulo()
    {
        decimal base_ = 5;
        decimal altura = 10;
        Triangulo triangulo = new Triangulo(base_, altura);
        decimal perimetro = triangulo.perimetro();
        decimal perimetroEsperado = 25.0m;
        Assert.AreEqual(perimetroEsperado, perimetro);
    }
}
