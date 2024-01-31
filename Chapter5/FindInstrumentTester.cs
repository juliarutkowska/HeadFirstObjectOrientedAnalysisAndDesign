namespace chapter5_new;

using System;
using System.Collections.Generic;

class FindInstrumentTester
{
    static void Main(string[] args)
    {
        var inventory = new Inventory();
        InitializeInventory(inventory);

        var properties = new Dictionary<string, object>();
        properties["builder"] = Builder.Gibson;
        properties["backWood"] = Wood.Maple;
        
        var whatBryanLikes = new InstrumentSpec(properties);
        var matchingInstruments = inventory.Search(whatBryanLikes);
        
        if (matchingInstruments.Count > 0)
        {
            Console.WriteLine("Bryan, you might like these instruments:");

            foreach (var instrument in matchingInstruments)
            {
                var spec = instrument.Spec;
                Console.WriteLine($"We have a {spec.GetProperty("instrumentType")} with the following properties:");
                foreach (var propertyName in spec.GetProperties().Keys)
                {
                    if (propertyName.Equals("instrumentType", StringComparison.OrdinalIgnoreCase))
                        continue;
                    Console.WriteLine($"    {propertyName}: {spec.GetProperty(propertyName)}");
                }
                
                Console.WriteLine($"  You can have this {spec.GetProperty("instrumentType")} for ${instrument.Price} \n---");
            }
        }
        else
        {
            Console.WriteLine("Sorry, Bryan, we have nothing for you.");
        }
    }
    
    private static void InitializeInventory(Inventory inventory)
    {
        Dictionary<string, object> properties = new Dictionary<string, object>();
        properties["instrumentType"] = InstrumentType.Guitar;
        properties["builder"] = Builder.Collings;
        properties["model"] = "CJ";
        properties["type"] = Type.Acoustic;
        properties["numStrings"] = 6;
        properties["topWood"] = Wood.IndianRosewood;
        properties["backWood"] = Wood.Sitka;
        inventory.AddInstrument("11277", 3999.95, new InstrumentSpec(properties));
        
        properties = new Dictionary<string, object>();
        properties["instrumentType"] = InstrumentType.Guitar;
        properties["builder"] = Builder.Martin;
        properties["model"] = "D-18";
        properties["type"] = Type.Acoustic;
        properties["numStrings"] = 6;
        properties["topWood"] = Wood.Mahogany;
        properties["backWood"] = Wood.Adirondack;
        inventory.AddInstrument("122784", 5495.95, new InstrumentSpec(properties));
        
        properties = new Dictionary<string, object>();
        properties["instrumentType"] = InstrumentType.Guitar;
        properties["builder"] = Builder.Fender;
        properties["model"] = "Stratocastor";
        properties["type"] = Type.Electric;
        properties["numStrings"] = 6;
        properties["topWood"] = Wood.Alder;
        properties["backWood"] = Wood.Alder;
        inventory.AddInstrument("V95693", 1499.95, new InstrumentSpec(properties));
        inventory.AddInstrument("V9512", 1549.95, new InstrumentSpec(properties));
        
        properties = new Dictionary<string, object>();
        properties["instrumentType"] = InstrumentType.Guitar;
        properties["builder"] = Builder.Gibson;
        properties["model"] = "Les Paul";
        properties["type"] = Type.Electric;
        properties["numStrings"] = 6;
        properties["topWood"] = Wood.Maple;
        properties["backWood"] = Wood.Maple;
        inventory.AddInstrument("70108276", 2295.95, new InstrumentSpec(properties));
        
        properties = new Dictionary<string, object>();
        properties["instrumentType"] = InstrumentType.Guitar;
        properties["builder"] = Builder.Gibson;
        properties["model"] = "SG'61 Reissue";
        properties["type"] = Type.Electric;
        properties["numStrings"] = 6;
        properties["topWood"] = Wood.Mahogany;
        properties["backWood"] = Wood.Mahogany;
        inventory.AddInstrument("82765501", 1890.95, new InstrumentSpec(properties));
        
        properties = new Dictionary<string, object>();
        properties["instrumentType"] = InstrumentType.Mandolin;
        properties["builder"] = Builder.Gibson;
        properties["model"] = "F-5G";
        properties["type"] = Type.Acoustic;
        properties.Remove("numStrings");
        properties["topWood"] = Wood.Maple;
        properties["backWood"] = Wood.Maple;
        inventory.AddInstrument("9019920", 5495.99, new InstrumentSpec(properties));
        
        properties = new Dictionary<string, object>();
        properties["instrumentType"] = InstrumentType.Banjo;
        properties["builder"] = Builder.Gibson;
        properties["model"] = "RB-3 Wreath";
        properties["type"] = Type.Acoustic;
        properties["numStrings"] = 5;
        properties["backWood"] = Wood.Maple;
        properties.Remove("topWood");
        inventory.AddInstrument("8900231", 2945.95, new InstrumentSpec(properties));
    }
}