namespace ReisApp;

// Beheert een lijst van accommodaties
public class Catalogus
{
    public List<IAccommodatie> accommodaties = new List<IAccommodatie>(); // POLYMORFISME: lijst van objecten die IAccommodatie implementeren

    public IAccommodatie Lookup(int ID)
    {
        // Lookup zoekt in de lijst van accommodaties naar een matchend ID.
        // Find() doorloopt automatisch elk item in de lijst.
        // De lambda 'acco => acco.ID == ID' geeft de voorwaarde: selecteer het eerste object waarvan het ID overeenkomt met de meegegeven waarde.
        // Als er geen match is, geeft Find() null terug.
        return accommodaties.Find(acco => acco.ID == ID);
    }
}
