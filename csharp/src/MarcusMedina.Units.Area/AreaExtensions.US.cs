namespace MarcusMedina.Units.Area.US;

/// <summary>
/// Amerikanska ytenheter (US customary).
/// <code>
/// 1.Acres().ToHectares()       // ≈ 0.4047
/// 1.SquareMiles().ToAcres()    // 640
/// </code>
/// </summary>
public static class USAreaExtensions
{
    public static Area SquareInches(this int v)    => new(v * 0.00064516);
    public static Area SquareInches(this double v) => new(v * 0.00064516);
    public static Area SquareFeet(this int v)      => new(v * 0.09290304);
    public static Area SquareFeet(this double v)   => new(v * 0.09290304);
    public static Area SquareYards(this int v)     => new(v * 0.83612736);
    public static Area SquareYards(this double v)  => new(v * 0.83612736);
    /// <summary>1 acre = 4 046.8564224 m²</summary>
    public static Area Acres(this int v)           => new(v * 4_046.8564224);
    public static Area Acres(this double v)        => new(v * 4_046.8564224);
    /// <summary>1 square mile = 2 589 988.110336 m²</summary>
    public static Area SquareMiles(this int v)     => new(v * 2_589_988.110336);
    public static Area SquareMiles(this double v)  => new(v * 2_589_988.110336);

    public static double ToSquareInches(this Area a) => a.SquareMeters / 0.00064516;
    public static double ToSquareFeet(this Area a)   => a.SquareMeters / 0.09290304;
    public static double ToSquareYards(this Area a)  => a.SquareMeters / 0.83612736;
    public static double ToAcres(this Area a)        => a.SquareMeters / 4_046.8564224;
    public static double ToSquareMiles(this Area a)  => a.SquareMeters / 2_589_988.110336;
}
