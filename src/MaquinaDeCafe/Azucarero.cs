namespace MaquinaDeCafe;

public class Azucarero
{
    private int cantidadDeAzucar;

    public Azucarero(int cantidadDeAzucar)
    {
        this.cantidadDeAzucar = cantidadDeAzucar;
    }

    public void SetCantidadDeAzucar(int cantidadDeAzucar)
    {
        this.cantidadDeAzucar = cantidadDeAzucar;
    }

    public int GetCantidadAzucar()
    {
        return cantidadDeAzucar;
    }

    public bool HasAzucar(int cantidadDeAzucar)
    {
        return this.cantidadDeAzucar >= cantidadDeAzucar;
    }

    public void GiveAzucar(int cantidadDeAzucar)
    {
        this.cantidadDeAzucar -= cantidadDeAzucar;
    }
}