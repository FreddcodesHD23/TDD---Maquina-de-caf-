using Xunit;
using MaquinaDeCafe;

namespace MaquinaDeCafe.Tests;

public class TestAzucarero
{
    private Azucarero azucarero;

    public TestAzucarero()
    {
        azucarero = new Azucarero(10);
    }

    [Fact]
    public void DeberiaDevolverVerdaderoSiHaySuficienteAzucar()
    {
        bool resultado = azucarero.HasAzucar(5);
        Assert.True(resultado);
        
        resultado = azucarero.HasAzucar(10);
        Assert.True(resultado);
    }

    [Fact]
    public void DeberiaDevolverFalsoPorqueNoHaySuficienteAzucar()
    {
        bool resultado = azucarero.HasAzucar(15);
        Assert.False(resultado);
    }

    [Fact]
    public void DeberiaRestarAzucarAlAzucarero()
    {
        azucarero.GiveAzucar(5);
        Assert.Equal(5, azucarero.GetCantidadAzucar());
        
        azucarero.GiveAzucar(2);
        Assert.Equal(3, azucarero.GetCantidadAzucar());
    }
}