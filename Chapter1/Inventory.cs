namespace Chapter1;

public class Inventory
{
    private readonly List<Guitar> _guitars;

    public Inventory()
    {
        _guitars = new List<Guitar>();
    }

    public void AddGuitar(string serialNumber, double price, Builder builder, string model, Type type, Wood backWood,
        Wood topWood, int numberOfStrings)
    {
        var guitarSpec = new GuitarSpec(builder, model, type, backWood, topWood, numberOfStrings);
        var guitar = new Guitar(serialNumber, price, guitarSpec);
        guitar.NumberOfStrings = numberOfStrings;
        _guitars.Add(guitar);
    }

    public Guitar Guitar(string serialNumber)
    {
        foreach (var guitar in _guitars)
        {
            if (guitar.SerialNumber.Equals(serialNumber))
            {
                return guitar;
            }
        }

        return null!;
    }


    public List<Guitar> Search(GuitarSpec searchSpec)
    {
        return _guitars.Where(
            guitar => searchSpec.GuitarFulfillsSpec(guitar)).ToList();
    }
}

// return _guitars.Where(
        //     guitar => 
        //         guitar.Builder == searchSpec.Builder
        //         && guitar.Model.Equals(searchSpec.Model, StringComparison.InvariantCultureIgnoreCase)
        //         && guitar.Type == searchSpec.Type
        //         && guitar.BackWood == searchSpec.BackWood
        //         && guitar.TopWood == searchSpec.TopWood).ToList();

        // foreach (Guitar guitar in _guitars)
        // {
        //     // Ignore serial number since that's unique
        //     // Ignore price since that's unique
        //     
        //     var builder = searchGuitar.GetBuilder();
        //     if (builder != guitar.GetBuilder())
        //     {
        //         continue;
        //     }
        //
        //     var model = searchGuitar.GetModel().ToLower();
        //     if (!string.IsNullOrEmpty(model) && model != guitar.GetModel().ToLower())
        //     {
        //         continue;
        //     }
        //
        //     if (searchGuitar.Type != guitar.Type)
        //     {
        //         continue;
        //     }
        //
        //     var backWood = searchGuitar.GetBackWood();
        //     if (backWood != guitar.GetBackWood())
        //     {
        //         continue;
        //     }
        //
        //     var topWood = searchGuitar.GetTopWood();
        //     if (topWood != guitar.GetTopWood())
        //     {
        //         continue;
        //     }
        //
        //     return guitar;
        // }
        //
        // return null!;
