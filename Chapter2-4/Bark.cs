namespace Chapter2;

public class Bark
{
    public BarkType Type { get; }

    public Bark(BarkType type)
    {
        Type = type;
    }
    
    private readonly string _sound;
    public string Sound { get; set; }

    public Bark(string sound)
    {
        _sound = sound;
    }

    public override bool Equals(object obj)
    {
        return obj is Bark otherBark && _sound.Equals(otherBark._sound, StringComparison.OrdinalIgnoreCase);
    }

    protected bool Equals(Bark other)
    {
        return _sound == other._sound && Sound == other.Sound;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(_sound, Sound);
    }
}

