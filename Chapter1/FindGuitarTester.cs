namespace Chapter1;

public class FindGuitarTester
{
    public static void Main(string[] args)
    {
        //Set up Rick's guitar inventory
        var inventory = new Inventory();
        InitializeInventory(inventory);
        
        GuitarSpec whatErinLikes = new GuitarSpec(Builder.Fender, "Stratocastor", Type.Electric, Wood.Alder, Wood.Alder, 6);

        var guitars = inventory.Search(whatErinLikes);

        if (guitars is { Count: > 0 }) //if (guitars != null && guitars.Count > 0)
        {
            foreach (var guitar in guitars)
            {
                var builder = guitar.Builder;
                var model = guitar.Model;
                var type = guitar.Type;
                var backWood = guitar.BackWood;
                var topWood = guitar.TopWood;
                var price = guitar.Price;
                var numberOfStrings = guitar.NumberOfStrings;
        
                Console.WriteLine($"Erin, you might like this {numberOfStrings} strings {builder} {model} {type} guitar:");
                Console.WriteLine($"{backWood} back and sides,");
                Console.WriteLine($"{topWood} top.");
                Console.WriteLine($"You can have it for only ${price}!");
                Console.WriteLine();
            }
        }
        
        else
        {
            Console.WriteLine("Sorry, Erin, we have nothing for you.");
        }
    }

    private static void InitializeInventory(Inventory inventory)
    {
        inventory.AddGuitar("V12345", 1345.55, Builder.Fender, "Stratocastor", Type.Electric, Wood.Alder, Wood.Adirondack, 6);
        inventory.AddGuitar("X54321", 430.54, Builder.Martin, "Stratocastor Light", Type.Electric, Wood.IndianRosewood, Wood.Maple, 6);
        inventory.AddGuitar("X99876", 2000.00, Builder.PRS, "Stratocastor FeatherWeight", Type.Electric, Wood.Sitka, Wood.Cocobolo, 6);
        inventory.AddGuitar("V9512", 1549.95, Builder.Fender, "Stratocastor", Type.Electric, Wood.Alder, Wood.Alder, 6);
        inventory.AddGuitar("V95693", 1499.95, Builder.Fender, "Stratocastor", Type.Electric, Wood.Alder, Wood.Alder, 6);
        inventory.AddGuitar("A21457", 900.55, Builder.Collings, "OakTown Goove", Type.Acoustic, Wood.BrazilianRosewood, Wood.Cedar, 6);

    }
}