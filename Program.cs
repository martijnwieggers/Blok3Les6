using Blok3Les6;

List<Auto> Autos = new List<Auto>();

//Maak 5 auto's aan en gebruik de constructor zodat direct die eigenschappen zijn gevuld.
//Voeg deze auto's toe aan de lijst met auto's

//Voeg ook 1 auto toe waarbij je de auto aanmaakt en vervolgens de methode VraagInformatie() van de Auto class aanroept.

List<Persoon> Personen = new List<Persoon>();

Persoon persoon1 = new Persoon();
persoon1.VraagInfo();

Personen.Add(persoon1);

foreach(var dePersoon in Personen)
{
    dePersoon.ToonInfo();
}    
