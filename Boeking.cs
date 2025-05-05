namespace ReisApp;

// Klasse vertegenwoordigt een boeking van een accommodatie met optionele faciliteiten
public class Boeking
{
    public IAccommodatie accommodatie; // POLYMORFISME: kan elk type IAccommodatie zijn
    public List<IFaciliteit> faciliteiten; // POLYMORFISME: lijst van verschillende faciliteiten
    public int aantal_nachten;

    public float berekenPrijs(int aantal_personen)
    {
        // Basisprijs = prijs per nacht * aantal nachten
        var prijs = aantal_nachten * accommodatie.berekenPrijs(aantal_personen);
        var resultaat = prijs;

        // Tel toeslagen van faciliteiten op bij de prijs
        foreach (var faciliteit in faciliteiten)
        {
            resultaat += faciliteit.berekenToeslag(prijs); // voor elke faciliteit bereken je de toeslag
        }

        return resultaat;
    }
}
