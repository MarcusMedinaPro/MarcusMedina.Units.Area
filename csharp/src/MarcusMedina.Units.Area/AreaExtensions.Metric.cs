namespace MarcusMedina.Units.Area.Metric;

/// <summary>
/// Metriska ytenheter — SI-standard.
/// <code>
/// 1.Hectares().ToSquareMeters()    // 10 000
/// 5.SquareKilometers().ToHectares() // 500
/// </code>
/// </summary>
public static class MetricAreaExtensions
{
    public static Area SquareMillimeters(this int v) => new(v * 0.000_001);
    public static Area SquareMillimeters(this double v) => new(v * 0.000_001);
    public static Area SquareCentimeters(this int v) => new(v * 0.000_1);
    public static Area SquareCentimeters(this double v) => new(v * 0.000_1);
    public static Area SquareDecimeters(this int v) => new(v * 0.01);
    public static Area SquareDecimeters(this double v) => new(v * 0.01);
    public static Area SquareMeters(this int v) => new(v);
    public static Area SquareMeters(this double v) => new(v);
    /// <summary>1 are = 100 m²</summary>
    public static Area Ares(this int v) => new(v * 100.0);
    public static Area Ares(this double v) => new(v * 100.0);
    /// <summary>1 hektar = 10 000 m²</summary>
    public static Area Hectares(this int v) => new(v * 10_000.0);
    public static Area Hectares(this double v) => new(v * 10_000.0);
    public static Area SquareKilometers(this int v) => new(v * 1_000_000.0);
    public static Area SquareKilometers(this double v) => new(v * 1_000_000.0);

    public static double ToSquareMillimeters(this Area a) => a.SquareMeters / 0.000_001;
    public static double ToSquareCentimeters(this Area a) => a.SquareMeters / 0.000_1;
    public static double ToSquareDecimeters(this Area a) => a.SquareMeters / 0.01;
    public static double ToSquareMeters(this Area a) => a.SquareMeters;
    public static double ToAres(this Area a) => a.SquareMeters / 100.0;
    public static double ToHectares(this Area a) => a.SquareMeters / 10_000.0;
    public static double ToSquareKilometers(this Area a) => a.SquareMeters / 1_000_000.0;
}
