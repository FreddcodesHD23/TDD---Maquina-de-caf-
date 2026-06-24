namespace MaquinaDeCafe;

public class MaquinaDeCafe
{
    private Cafetera cafetera;
    private Vaso vasosPequeno;
    private Vaso vasosMediano;
    private Vaso vasosGrande;
    private Azucarero azucarero;

    // Getters y Setters
    public Cafetera GetCafetera()
    {
        return cafetera;
    }

    public void SetCafetera(Cafetera cafetera)
    {
        this.cafetera = cafetera;
    }

    public Vaso GetVasosPequeno()
    {
        return vasosPequeno;
    }

    public void SetVasosPequeno(Vaso vasosPequeno)
    {
        this.vasosPequeno = vasosPequeno;
    }

    public Vaso GetVasosMediano()
    {
        return vasosMediano;
    }

    public void SetVasosMediano(Vaso vasosMediano)
    {
        this.vasosMediano = vasosMediano;
    }

    public Vaso GetVasosGrande()
    {
        return vasosGrande;
    }

    public void SetVasosGrande(Vaso vasosGrande)
    {
        this.vasosGrande = vasosGrande;
    }

    public Azucarero GetAzucarero()
    {
        return azucarero;
    }

    public void SetAzucarero(Azucarero azucarero)
    {
        this.azucarero = azucarero;
    }

    public Vaso GetTipoDeVaso(string tipoDeVaso)
    {
        switch (tipoDeVaso.ToLower())
        {
            case "pequeno":
                return vasosPequeno;
            case "mediano":
                return vasosMediano;
            case "grande":
                return vasosGrande;
            default:
                return null;
        }
    }

    public string GetVasoDeCafe(Vaso vaso, int cantidadDeVasos, int cantidadDeAzucar)
    {
        // Verificar si hay suficientes vasos
        if (!vaso.HasVasos(cantidadDeVasos))
        {
            return "No hay Vasos";
        }

        // Verificar si hay suficiente café
        int cafeNecesario = vaso.GetContenido() * cantidadDeVasos;
        if (!cafetera.HasCafe(cafeNecesario))
        {
            return "No hay Cafe";
        }

        // Verificar si hay suficiente azúcar
        if (!azucarero.HasAzucar(cantidadDeAzucar))
        {
            return "No hay Azucar";
        }

        // Entregar el café (restar recursos)
        vaso.GiveVasos(cantidadDeVasos);
        cafetera.GiveCafe(cafeNecesario);
        azucarero.GiveAzucar(cantidadDeAzucar);

        return "Felicitaciones";
    }
}