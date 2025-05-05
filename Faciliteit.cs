namespace ReisApp;

// ABSTRACTIE: Interface definieert een algemene structuur voor alle faciliteiten
public interface IFaciliteit
{
    float berekenToeslag(float prijs); // POLYMORFISME: Elke faciliteit implementeert deze op eigen manier
}

// Voorbeeld van een faciliteit: zwembad
public class Zwembad : IFaciliteit
{
    public int lengte;
    public int breedte;
    public int diepte;

    public float berekenToeslag(float prijs)
    {
        // Bereken het volume van het zwembad in m³
        var kubiekeMeters = lengte * breedte * diepte;

        // Toeslag is 5% van de prijs bij klein zwembad, 10% bij groot zwembad
        if (kubiekeMeters > 100)
        {
            return prijs * 1.1f; // 10% toeslag
        }
        else
        {
            return prijs * 1.05f; // 5% toeslag
        }
    }
}

// Buitenkeuken als faciliteit
public class Buitenkeuken : IFaciliteit
{
    public bool elektrisch;

    public float berekenToeslag(float prijs)
    {
        // Standaard toeslag is 10%
        float toeslag = prijs * 1.1f;

        // Elektrische buitenkeuken krijgt 30% korting op die toeslag
        if (elektrisch)
        {
            return toeslag * 0.7f;
        }
        else
        {
            return toeslag;
        }
    }
}

// Tuin als faciliteit
public class Tuin : IFaciliteit
{
    public int oppervlakte;

    public float berekenToeslag(float prijs)
    {
        // Basis is 5% toeslag op prijs
        float basis = prijs * 1.05f;

        // Extra toeslag: 1% van de prijs per m² (let op: dit wordt erg groot bij grote oppervlaktes)
        float eenProcent = prijs * 0.01f;
        float extra = oppervlakte * eenProcent;

        return basis + extra;
    }
}

// Eenvoudige faciliteit met vaste toeslag
public class ZichtOpZee : IFaciliteit
{
    public float berekenToeslag(float prijs)
    {
        // Altijd 7.5% toeslag op de prijs
        return prijs * 1.075f;
    }
}
