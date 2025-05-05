using System.ComponentModel.DataAnnotations;

namespace ReisApp;

public class Reis
{
    private Catalogus catalogus; // Bevat de lijst van accommodaties
    private List<IAccommodatie> geboekteAccommodaties = new List<IAccommodatie>(); // Lijst van geboekte accommodaties
    private List<IFaciliteit> geboekteFaciliteiten = new List<IFaciliteit>(); // Lijst van geboekte faciliteiten (optioneel, niet gebruikt in deze code)
    private int aantal_personen; // Aantal personen dat de reis boekt

    // Constructor voor het instantiëren van een reis met een catalogus en aantal personen
    public Reis(Catalogus catalogusInput, int aantal_personen_Input)
    {
        catalogus = catalogusInput;
        aantal_personen = aantal_personen_Input;
    }

    // Methode om een accommodatie te boeken op basis van ID
    public void BoekAccommodaties(int ID)
    {
        // Haalt de accommodatie op uit de catalogus op basis van het meegegeven ID
        var accomodatie = catalogus.Lookup(ID); // Zoekt accommodatie via de Lookup methode in Catalogus

        // Voeg de gevonden accommodatie toe aan de lijst van geboekte accommodaties
        geboekteAccommodaties.Add(accomodatie);
    }

    // Bereken de totale prijs van de geboekte accommodaties, inclusief toeslagen voor faciliteiten
    public float BerekenTotaalPrijs()
    {
        float prijs = 0;

        // Loop door alle geboekte accommodaties en bereken de prijs
        foreach (var acco in geboekteAccommodaties)
        {
            // Prijs van de accommodatie wordt berekend voor het opgegeven aantal personen en opgeteld bij het totaal
            prijs += acco.berekenPrijs(aantal_personen); 
        }

        return prijs;
    }
}
