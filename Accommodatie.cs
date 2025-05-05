namespace ReisApp;

// ABSTRACTIE: Interface definieert wat een accommodatie moet kunnen, zonder implementatie
public interface IAccommodatie
{
    int ID { get; set; } // ENCAPSULATIE: Via property, niet direct veld
    float berekenPrijs(int aantal_personen);
}

// INHERITANCE & POLYMORFISME: Klasse implementeert IAccommodatie
public class Kampeerplaats : IAccommodatie
{
    public int ID { get; set; } // ENCAPSULATIE
    public int oppervlakte;

    public float berekenPrijs(int aantal_personen)
    {
        var toeslag = 7.5 * aantal_personen;
        return oppervlakte * 5 + (float)toeslag;
    }
}

public class Hotelkamer : IAccommodatie
{
    public int ID { get; set; }
    public int aantal_bedden;
    public bool inclusief_ontbijt;

    public float berekenPrijs(int aantal_personen)
    {
        int bedprijs = 10 * aantal_bedden;

        if (inclusief_ontbijt)
        {
            return 135 * aantal_personen + bedprijs;
        }
        else
        {
            return 120 * aantal_personen + bedprijs;
        }
    }
}

public class Chalet : IAccommodatie
{
    public int ID { get; set; }
    public int aantal_slaapkamers;

    public float berekenPrijs(int aantal_personen)
    {
        // Bij 3 of meer slaapkamers is de prijs per persoon hoger
        if (aantal_slaapkamers >= 3)
        {
            return 75 * aantal_personen;
        }
        else
        {
            return 50 * aantal_personen;
        }
    }
}
