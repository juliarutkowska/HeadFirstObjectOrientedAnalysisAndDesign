using Xunit.Sdk;

namespace Chapter6;

public partial class Unit
{
    private string _type;
    private string _name;
    private List<Weapon> _weapons;
    private Dictionary<string, object> _properties;

    public Unit(int id)
    {
        Id = id;
        _properties = new Dictionary<string, object>();
    }

    public string Type
    {
        get => _type;
        set => _type = value;
    }

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public List<Weapon> Weapons => _weapons;

    public int Id { get; }

    public void AddWeapon(Weapon weapon)
    {
        if (_weapons == null)
        {
            _weapons = new List<Weapon>();
        }
        _weapons.Add(weapon);
    }

    public void SetProperty(string property, object value)
    {
        if (_properties == null)
        {
            _properties = new Dictionary<string, object>();
        }
        _properties[property] = value;
    }

    public object GetProperty(string property)
    {
        if (_properties == null)
        {
            throw new InvalidOperationException("Properties dictionary is null.");
        }

        if (!_properties.ContainsKey(property))
        {
            return null; 
        }

        var value = _properties[property];

        return value; 
    }

    // public object GetProperty(string property)
    // {
    //     if (_properties == null)
    //     {
    //         throw new InvalidOperationException("Properties dictionary is null.");
    //     }
    //
    //     if (!_properties.ContainsKey(property))
    //     {
    //         throw new KeyNotFoundException($"Property '{property}' not found.");
    //     }
    //
    //     var value = _properties[property];
    //
    //     if (value == null)
    //     {
    //         throw new InvalidOperationException($"Value for property '{property}' is null.");
    //     }
    //
    //     return value;
        // if (_properties == null || !_properties.ContainsKey(property))
        // {
        //     throw new KeyNotFoundException("No properties for this Unit");
        // }
        //
        // var value = _properties[property];
        // if (value == null)
        // {
        //     throw new KeyNotFoundException("Request for non-existent property.");
        // }
        // return value;
    
}
// public class Unit
// {
//     private string Type { get; set; }
//     private int Id { get; }
//     private string Name { get; set; }
//     private List<Weapon> weapons { get; set; }
//     private Dictionary<string, object> properties { get; set; }
//     
//     public Unit(int id)
//     {
//         Id = id;
//     }
//     
//     public void addWeapon(Weapon weapon)
//     {
//         if (weapons == null)
//         {
//             weapons = new List<Weapon>();
//         }
//         weapons.Add(weapon);
//     }
//
//     public void Property(string property, object value)
//     {
//         if (properties == null)
//         {
//             properties = new Dictionary<string, object>();
//         }
//         properties[property] = value;
//     }
//
//     public object Property(string property)
//     {
//         if (properties == null)
//         {
//             return null;
//         }
//
//         return properties[property];
//     }