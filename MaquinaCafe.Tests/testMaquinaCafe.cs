using Xunit;
using MaquinaDeCafe;

namespace MaquinaDeCafe.Tests;

public class TestMaquinaDeCafe
{
    private Cafetera cafetera;
    private Vaso vasosPequeno;
    private Vaso vasosMediano;
    private Vaso vasosGrande;
    private Azucarero azucarero;
    private MaquinaDeCafe maquinaDeCafe;

    public TestMaquinaDeCafe()
    {
        cafetera = new Cafetera(50);
        vasosPequeno = new Vaso(5, 10);
        vasosMediano = new Vaso(5, 20);
        vasosGrande = new Vaso(5, 30);
        azucarero = new Azucarero(20);

        maquinaDeCafe = new MaquinaDeCafe();
        maquinaDeCafe.SetCafetera(cafetera);
        maquinaDeCafe.SetVasosPequeno(vasosPequeno);
        maquinaDeCafe.SetVasosMediano(vasosMediano);
        maquinaDeCafe.SetVasosGrande(vasosGrande);
        maquinaDeCafe.SetAzucarero(azucarero);
    }

    [Fact]
    public void DeberiaDevolverUnVasoPequeno()
    {
        Vaso vaso = maquinaDeCafe.GetTipoDeVaso("pequeno");
        Assert.Equal(maquinaDeCafe.GetVasosPequeno(), vaso);
    }

    [Fact]
    public void DeberiaDevolverUnVasoMediano()
    {
        Vaso vaso = maquinaDeCafe.GetTipoDeVaso("mediano");
        Assert.Equal(maquinaDeCafe.GetVasosMediano(), vaso);
    }

    [Fact]
    public void DeberiaDevolverUnVasoGrande()
    {
        Vaso vaso = maquinaDeCafe.GetTipoDeVaso("grande");
        Assert.Equal(maquinaDeCafe.GetVasosGrande(), vaso);
    }

    [Fact]
    public void DeberiaDevolverNoHayCafe()
    {
        cafetera = new Cafetera(5);
        maquinaDeCafe.SetCafetera(cafetera);

        Vaso vaso = maquinaDeCafe.GetTipoDeVaso("pequeno");
        string resultado = maquinaDeCafe.GetVasoDeCafe(vaso, 1, 2);
        Assert.Equal("No hay Cafe", resultado);
    }

    [Fact]
    public void DeberiaDevolverNoHayAzucar()
    {
        azucarero = new Azucarero(2);
        maquinaDeCafe.SetAzucarero(azucarero);

        Vaso vaso = maquinaDeCafe.GetTipoDeVaso("pequeno");
        string resultado = maquinaDeCafe.GetVasoDeCafe(vaso, 1, 3);
        Assert.Equal("No hay Azucar", resultado);
    }

    [Fact]
    public void DeberiaDevolverNoHayVasos()
    {
        Vaso vaso = maquinaDeCafe.GetTipoDeVaso("pequeno");
        string resultado = maquinaDeCafe.GetVasoDeCafe(vaso, 6, 2);
        Assert.Equal("No hay Vasos", resultado);
    }

    [Fact]
    public void DeberiaDevolverFelicitaciones()
    {
        Vaso vaso = maquinaDeCafe.GetTipoDeVaso("pequeno");
        string resultado = maquinaDeCafe.GetVasoDeCafe(vaso, 1, 2);
        Assert.Equal("Felicitaciones", resultado);
    }

    [Fact]
    public void DeberiaRestarCafe()
    {
        Vaso vaso = maquinaDeCafe.GetTipoDeVaso("pequeno");
        maquinaDeCafe.GetVasoDeCafe(vaso, 1, 3);
        int resultado = maquinaDeCafe.GetCafetera().GetCantidadCafe();
        Assert.Equal(40, resultado);
    }

    [Fact]
    public void DeberiaRestarVaso()
    {
        Vaso vaso = maquinaDeCafe.GetTipoDeVaso("pequeno");
        maquinaDeCafe.GetVasoDeCafe(vaso, 1, 3);
        int resultado = maquinaDeCafe.GetVasosPequeno().GetCantidadVasos();
        Assert.Equal(4, resultado);
    }

    [Fact]
    public void DeberiaRestarAzucar()
    {
        Vaso vaso = maquinaDeCafe.GetTipoDeVaso("pequeno");
        maquinaDeCafe.GetVasoDeCafe(vaso, 1, 3);
        int resultado = maquinaDeCafe.GetAzucarero().GetCantidadAzucar();
        Assert.Equal(17, resultado);
    }
}