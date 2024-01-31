using Xunit.Sdk;

namespace Chapter6;

public class Unit
{
    private string _type;
    private int _id;
    private string _name;
    private List<Weapon> _weapons;
    private Dictionary<string, object> _properties;

    public Unit(int id)
    {
        _id = id;
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

    public int Id => _id;

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
        if (_properties == null || !_properties.ContainsKey(property))
        {
            throw new NullException("No properties for this Unit");
        }

        var value = _properties[property];
        if (value == null)
        {
            throw new NullException("Request for non-existent property.");
        }
        return value;
    }
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