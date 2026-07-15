namespace MarcusMedina.Units.Area.British;

/// <summary>
/// Brittiska ytenheter (imperial). Delar de flesta enheter med US, men lägger till Rood.
/// <code>
/// 1.Roods().ToAcres()     // 0.25
/// 4.Roods().ToHectares()  // ≈ 0.4047
/// </code>
/// </summary>
public static class BritishAreaExtensions
{
    public static Area SquareInches(this int v) => new(v * 0.00064516);
    public static Area SquareInches(this double v) => new(v * 0.00064516);
    public static Area SquareFeet(this int v) => new(v * 0.09290304);
    public static Area SquareFeet(this double v) => new(v * 0.09290304);
    public static Area SquareYards(this int v) => new(v * 0.83612736);
    public static Area SquareYards(this double v) => new(v * 0.83612736);
    /// <summary>1 rood = 1/4 acre = 1 011.7141056 m²</summary>
    public static Area Roods(this int v) => new(v * 1_011.7141056);
    public static Area Roods(this double v) => new(v * 1_011.7141056);
    public static Area Acres(this int v) => new(v * 4_046.8564224);
    public static Area Acres(this double v) => new(v * 4_046.8564224);
    public static Area SquareMiles(this int v) => new(v * 2_589_988.110336);
    public static Area SquareMiles(this double v) => new(v * 2_589_988.110336);

    public static double ToSquareInches(this Area a) => a.SquareMeters / 0.00064516;
    public static double ToSquareFeet(this Area a) => a.SquareMeters / 0.09290304;
    public static double ToSquareYards(this Area a) => a.SquareMeters / 0.83612736;
    public static double ToRoods(this Area a) => a.SquareMeters / 1_011.7141056;
    public static double ToAcres(this Area a) => a.SquareMeters / 4_046.8564224;
    public static double ToSquareMiles(this Area a) => a.SquareMeters / 2_589_988.110336;
}
