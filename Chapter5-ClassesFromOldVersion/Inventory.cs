using System.Diagnostics.Metrics;

namespace Chapter5_ClassesFromOldVersion;

public class Inventory
{
public List<Guitar> Search(GuitarSpec searchSpec)
    {
        List<Guitar> matchingGuitars = new List<Guitar>();
        foreach (Instrument? instrument in _inventory)
        {
            if (instrument is Guitar guitar && guitar.GetSpec().Matches(searchSpec))
            {
                matchingGuitars.Add(guitar);
            }
        }
        return matchingGuitars;
    }

    public List<Guitar> Search(GuitarSpec searchSpec)
    {
        return _guitars.Where(
            guitar => searchSpec.GuitarFulfillsSpec(guitar)).ToList();
    }
        
    public List<Mandolin> Search(MandolinSpec searchSpec)
    {
        List<Mandolin> matchingMandolins = new List<Mandolin>();
        foreach (var instrument in _inventory)
        {
            if (instrument is Mandolin mandolin && mandolin.GetSpec().Matches(searchSpec))
            {
                matchingMandolins.Add(mandolin);
            }
        }
        return matchingMandolins;
    }
}
//old version:
    // public Guitar Guitar(string serialNumber)
    // {
    //     foreach (var guitar in _guitars)
    //     {
    //         if (guitar.SerialNumber.Equals(serialNumber))
    //         {
    //             return guitar;
    //         }
    //     }
    //
    //     return null!;
    // }

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
