namespace MaquinaDeCafe;

public class Cafetera
{
    private int cantidadCafe;

    public Cafetera(int cantidadCafe)
    {
        this.cantidadCafe = cantidadCafe;
    }

    public void SetCantidadDeCafe(int cantidadCafe)
    {
        this.cantidadCafe = cantidadCafe;
    }

    public int GetCantidadCafe()
    {
        return cantidadCafe;
    }

    public bool HasCafe(int cantidadCafe)
    {
        return this.cantidadCafe >= cantidadCafe;
    }

    public void GiveCafe(int cantidadCafe)
    {
        this.cantidadCafe -= cantidadCafe;
    }
}