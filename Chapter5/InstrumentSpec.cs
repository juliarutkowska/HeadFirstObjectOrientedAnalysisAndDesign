namespace chapter5_new;

using System;
using System.Collections.Generic;

public class InstrumentSpec
{
    private Dictionary<string, object> _properties;

    public InstrumentSpec(Dictionary<string, object> properties)
    {
        _properties = properties != null ? new Dictionary<string, object>(properties) : new Dictionary<string, object>();
    }

    public object GetProperty(string propertyName)
    {
        return _properties.ContainsKey(propertyName) ? _properties[propertyName] : null;
    }

    public Dictionary<string, object> GetProperties()
    {
        return _properties;
    }

    public bool Matches(InstrumentSpec otherSpec)
    {
        foreach (var propertyName in otherSpec.GetProperties().Keys)
        {
            if (!_properties.ContainsKey(propertyName) ||
                !_properties[propertyName].Equals(otherSpec.GetProperty(propertyName)))
            {
                return false;
            }
        }
        return true;
    }
}