namespace Chapter5;

public class FindInstrumentTester
{
    public static void Main(string[] args)
    {
        var inventory = new Inventory();
        InitializeInventory(inventory);
        
        var whatErinLikes = new MandolinSpec(Builder.Fender, "Stratocastor", Type.Electric, Wood.Alder, Wood.Alder, 6);

        var instrument = inventory.Search(whatErinLikes);
    }

}