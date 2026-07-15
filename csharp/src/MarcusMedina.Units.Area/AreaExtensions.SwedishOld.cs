namespace MarcusMedina.Units.Area.SwedishOld;

/// <summary>
/// Historiska svenska ytenheter — åker- och markmätning före 1889.
/// <code>
/// 1.Tunnland().ToHectares()   // ≈ 0.4937
/// 32.Kappland().ToTunnland()  // 1
/// </code>
/// </summary>
public static class SwedishOldAreaExtensions
{
    /// <summary>1 kvadrattum = (0.026154 m)² ≈ 0.000684 m²</summary>
    public static Area KvadratTum(this int v) => new(v * 0.000684);
    public static Area KvadratTum(this double v) => new(v * 0.000684);
    /// <summary>1 kvadratfot = (0.31385 m)² ≈ 0.098501 m²</summary>
    public static Area KvadratFot(this int v) => new(v * 0.098501);
    public static Area KvadratFot(this double v) => new(v * 0.098501);
    /// <summary>1 kvadrataln = (0.6277 m)² ≈ 0.394007 m²</summary>
    public static Area KvadratAln(this int v) => new(v * 0.394007);
    public static Area KvadratAln(this double v) => new(v * 0.394007);
    /// <summary>1 kappland = 154.26 m² (historisk åkerenhet)</summary>
    public static Area Kappland(this int v) => new(v * 154.26);
    public static Area Kappland(this double v) => new(v * 154.26);
    /// <summary>1 tunnland = 32 kappland = 4 936.32 m²</summary>
    public static Area Tunnland(this int v) => new(v * 4_936.32);
    public static Area Tunnland(this double v) => new(v * 4_936.32);

    public static double ToKvadratTum(this Area a) => a.SquareMeters / 0.000684;
    public static double ToKvadratFot(this Area a) => a.SquareMeters / 0.098501;
    public static double ToKvadratAln(this Area a) => a.SquareMeters / 0.394007;
    public static double ToKappland(this Area a) => a.SquareMeters / 154.26;
    public static double ToTunnland(this Area a) => a.SquareMeters / 4_936.32;
}
