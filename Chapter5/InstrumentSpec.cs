namespace Chapter5;

using System.Collections.Generic;

public class InstrumentSpec
{
    private Dictionary<string, object> _properties;
    public Dictionary<string, object> Properties { get; set; }

    public InstrumentSpec(Dictionary<string, object> properties)
    {
        _properties = properties != null
            ? new Dictionary<string, object>(properties)
            : new Dictionary<string, object>();
    }

    public object Property(string propertyName)
    {
        if (_properties.TryGetValue(propertyName, out var property))
        {
            return property;
        }

        return null;
    }
    
    public bool Matches(InstrumentSpec otherSpec)
    {
        if (otherSpec == null || otherSpec.Properties == null || _properties == null)
        {
            return false;
        }

        return otherSpec.Properties.Keys.All(propertyName =>
            _properties.TryGetValue(propertyName, out var thisPropertyValue)
            && otherSpec.Properties.TryGetValue(propertyName, out var otherPropertyValue)
            && thisPropertyValue?.Equals(otherPropertyValue) == true);
    }
}
