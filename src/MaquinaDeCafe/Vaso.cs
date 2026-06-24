namespace MaquinaDeCafe;

public class Vaso
{
    private int cantidadVasos;
    private int contenido;

    public Vaso(int cantidadVasos, int contenido)
    {
        this.cantidadVasos = cantidadVasos;
        this.contenido = contenido;
    }

    public void SetCantidadVasos(int cantidadVasos)
    {
        this.cantidadVasos = cantidadVasos;
    }

    public int GetCantidadVasos()
    {
        return cantidadVasos;
    }

    public void SetContenido(int contenido)
    {
        this.contenido = contenido;
    }

    public int GetContenido()
    {
        return contenido;
    }

    public bool HasVasos(int cantidadVasos)
    {
        return this.cantidadVasos >= cantidadVasos;
    }

    public void GiveVasos(int cantidadVasos)
    {
        this.cantidadVasos -= cantidadVasos;
    }
}