using System;

namespace ReisApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Boeking 1:
            //2 personen
            //Hotelkamer met ontbijt
            //Zicht op zee
            int aantal_personen = 2;
            var acco1 = new Hotelkamer() { aantal_bedden = 1, inclusief_ontbijt = true };
            var faci1 = new ZichtOpZee();
            var faciList = new List<IFaciliteit>() { faci1 };
            var boeking1 = new Boeking() { aantal_nachten = 5, accommodatie = acco1, faciliteiten = faciList };
            var prijsVanBoeking = boeking1.berekenPrijs(aantal_personen);
            Console.WriteLine("Hewwoo, de prijs voor je boeking is: ", prijsVanBoeking);

            //Boeking 2:
            //4 personen
            //Chalet met 3 slaapkamers
            //Zwembad van 120m³
            //Buitenkeuken(elektrisch)
            int aantal_personen2 = 4;
            var chacha = new Chalet() { aantal_slaapkamers = 2 };
            var facist1 = new Zwembad() { breedte = 2, diepte = 6, lengte = 10 };
            var facist2 = new Buitenkeuken() { elektrisch = true };
            var faciList2 = new List<IFaciliteit>() { facist1, facist2 };
            var boeking2 = new Boeking() { aantal_nachten = 9, accommodatie = chacha, faciliteiten = faciList2 };
            var prijsVanBoeking2 = boeking2.berekenPrijs(aantal_personen2);
            Console.WriteLine($"chicken jocky chalet prijs: {prijsVanBoeking2}");

            //Boeking 3:
            //5 personen
            //Kampeerplaats(50m²)
            //Tuin van 500m²
            var accommodatie3 = new Kampeerplaats() { ID = 3, oppervlakte = 50 };
            var faci3 = new Tuin() { oppervlakte = 500 };
            var lijst = new List<IFaciliteit> { faci3};
            var boeking3 = new Boeking() { aantal_nachten = 10, accommodatie = accommodatie3, faciliteiten = lijst };
            var boeie = boeking3.berekenPrijs(5);
            Console.WriteLine("De totaalprijs is: " + boeie);

            var lijstAcco = new List<IAccommodatie> { acco1, accommodatie3, chacha };
            Catalogus catalogus = new Catalogus() { accommodaties = lijstAcco };
            int aantal = 3;

            var reis = new Reis(catalogus, aantal);
        }
    }
}