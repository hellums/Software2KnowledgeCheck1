using Software2KnowledgeCheck1;

City Louisville = new City();

Apartment TheShambles = new Apartment() {
    Street = "Main St.",
    StreetNumber = 205,
    HasParking = false,
    NumberOfUnits = 40,
    NumberOfOpenUnits = 40
    };

TheShambles.CreateApartment(TheShambles);
Louisville.Buildings.Add(TheShambles);

Console.WriteLine("{0} building(s) in Louisville", Louisville.Buildings.Count);
foreach (Apartment apartment in Louisville.Buildings)
{
    Console.WriteLine(apartment.StreetNumber.ToString() + " " + apartment.Street);
    if (apartment.HasParking) {
        Console.WriteLine("Apartment has parking");
    } else Console.WriteLine("Apartment does not have parking");
    Console.WriteLine("Apartment has {0} units of {1} available.", apartment.NumberOfOpenUnits, apartment.NumberOfUnits);
}


