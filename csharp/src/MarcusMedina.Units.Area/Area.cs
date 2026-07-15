using System.Globalization;

namespace MarcusMedina.Units.Area;

/// <summary>
/// Representerar en yta med kvadratmeter som basenhet.
/// Alla konverteringar sker genom att multiplicera/dividera m²-värdet.
/// </summary>
public readonly struct Area : IComparable<Area>, IEquatable<Area>
{
    /// <summary>Värdet i kvadratmeter (basenhet).</summary>
    public double SquareMeters { get; }

    public Area(double squareMeters) { SquareMeters = squareMeters; }

    public int CompareTo(Area other) => SquareMeters.CompareTo(other.SquareMeters);
    public bool Equals(Area other) => SquareMeters.Equals(other.SquareMeters);
    public override bool Equals(object? obj) => obj is Area a && Equals(a);
    public override int GetHashCode() => HashCode.Combine(SquareMeters);
    public override string ToString() => $"{SquareMeters.ToString("G", CultureInfo.InvariantCulture)} m²";

    public static bool operator ==(Area a, Area b) => a.Equals(b);
    public static bool operator !=(Area a, Area b) => !(a == b);
    public static bool operator <(Area a, Area b) => a.SquareMeters < b.SquareMeters;
    public static bool operator >(Area a, Area b) => a.SquareMeters > b.SquareMeters;
    public static bool operator <=(Area a, Area b) => a.SquareMeters <= b.SquareMeters;
    public static bool operator >=(Area a, Area b) => a.SquareMeters >= b.SquareMeters;
    public static Area operator +(Area a, Area b) => new(a.SquareMeters + b.SquareMeters);
    public static Area operator -(Area a, Area b) => new(a.SquareMeters - b.SquareMeters);
    public static Area operator *(Area a, double factor) => new(a.SquareMeters * factor);
    public static Area operator /(Area a, double divisor) => new(a.SquareMeters / divisor);
    public static double operator /(Area a, Area b) => a.SquareMeters / b.SquareMeters;
}
