namespace Chapter5;

using System;
using System.Collections.Generic;

class FindInstrumentTester
{
    static void Main(string[] args)
    {
        var inventory = new Inventory();
        InitializeInventory(inventory);

        var properties = new Dictionary<string, object>
        {
            { "builder", Builder.Gibson },
            { "backWood", Wood.Maple }
        };

        var whatBryanLikes = new InstrumentSpec(properties);

        var matchingInstruments = inventory.Search(whatBryanLikes);
        
        if (matchingInstruments.Count > 0)
        {
            Console.WriteLine("Bryan, you might like these instruments:");

            foreach (var instrument in matchingInstruments)
            {
                var spec = instrument.GetSpec();
                Console.WriteLine($"We have a {spec.Property("instrumentType")} with the following properties:");
                foreach (var propertyName in spec.Properties.Keys)
                {
                    if (propertyName.Equals("instrumentType", StringComparison.OrdinalIgnoreCase))
                        continue;
                    Console.WriteLine($"    {propertyName}: {spec.Property(propertyName)}");
                }

                Console.WriteLine($"  You can have this {spec.Property("instrumentType")} for ${instrument.Price} \n---");
            }
        }
        else
        {
            Console.WriteLine("Sorry, Bryan, we have nothing for you.");
        }
    }

    private static void InitializeInventory(Inventory inventory)
    {
        var properties = new Dictionary<string, object>
        {
            { "instrumentType", InstrumentType.Guitar },
            { "builder", Builder.Collings },
            { "model", "CJ" },
            { "type", Type.Acoustic },
            { "numStrings", 6 },
            { "topWood", Wood.IndianRosewood },
            { "backWood", Wood.Sitka }
        };
        inventory.AddInstrument("11277", 3999.95, new InstrumentSpec(properties));

        properties["builder"] = Builder.Martin;
        properties["model"] = "D-18";
        properties["type"] = Type.Acoustic;
        properties["numStrings"] = "6";
        properties["topWood"] = Wood.Mahogany;
        properties["backWood"] = Wood.Adirondack;
        inventory.AddInstrument("122784", 5495.95, new InstrumentSpec(properties));

        properties["builder"] = Builder.Fender;
        properties["model"] = "stratocastor";
        properties["type"] = Type.Electric;
        properties["numStrings"] = "6";
        properties["topWood"] = Wood.Alder;
        properties["backWood"] = Wood.Alder;
        inventory.AddInstrument("V95693", 1499.95, new InstrumentSpec(properties));
        inventory.AddInstrument("V9512", 1549.95, new InstrumentSpec(properties));
        
        properties["builder"] = Builder.Gibson;
        properties["model"] = "SG'61 Reissue";
        properties["type"] = Type.Electric;
        properties["numStrings"] = "6";
        properties["topWood"] = Wood.Mahogany;
        properties["backWood"] = Wood.Mahogany;
        inventory.AddInstrument("82765501", 1890.95, new InstrumentSpec(properties));
        
        properties["builder"] = Builder.Gibson;
        properties["model"] = "Les Paul";
        properties["type"] = Type.Electric;
        properties["numStrings"] = "6";
        properties["topWood"] = Wood.Maple;
        properties["backWood"] = Wood.Maple;
        inventory.AddInstrument("70108276", 2295.95, new InstrumentSpec(properties));
        
        properties["instrumentType"] = InstrumentType.Mandolin;
        properties["builder"] = Builder.Gibson;
        properties["model"] = "F5-G";
        properties["type"] = Type.Acoustic;
        properties["topWood"] = Wood.Maple;
        properties["backWood"] = Wood.Maple;
        inventory.AddInstrument("9019920", 5495.99, new InstrumentSpec(properties));
        
        properties["instrumentType"] = InstrumentType.Banjo;
        properties["builder"] = Builder.Gibson;
        properties["model"] = "RB-3";
        properties["type"] = Type.Acoustic;
        properties["numStrings"] = "5";
        properties["backWood"] = Wood.Maple;
        inventory.AddInstrument("8900231", 2945.95, new InstrumentSpec(properties));
    }
}