namespace Chapter10;

public class Station
{
    private string Name { get; set; }

    public Station(string name)
    {
        Name = name;
    }
    
    public override bool Equals(object obj)
    {
        if (obj is Station)
        {
            var otherStation = (Station)obj;
            if (otherStation.Name.Equals(Name, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
        }
        return false;
    }
    
    public override int GetHashCode()
    {
        return Name.ToLower().GetHashCode();
    }
    
}