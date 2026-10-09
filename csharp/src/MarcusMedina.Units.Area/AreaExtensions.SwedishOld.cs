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
    extension(int v)
    {
        /// <summary>1 kvadrattum = (0.026154 m)² ≈ 0.000684 m²</summary>
        public Area KvadratTum() => new(v * 0.000684);
        /// <summary>1 kvadratfot = (0.31385 m)² ≈ 0.098501 m²</summary>
        public Area KvadratFot() => new(v * 0.098501);
        /// <summary>1 kvadrataln = (0.6277 m)² ≈ 0.394007 m²</summary>
        public Area KvadratAln() => new(v * 0.394007);
        /// <summary>1 kappland = 154.26 m² (historisk åkerenhet)</summary>
        public Area Kappland() => new(v * 154.26);
        /// <summary>1 tunnland = 32 kappland = 4 936.32 m²</summary>
        public Area Tunnland() => new(v * 4_936.32);
    }

    extension(double v)
    {
        public Area KvadratTum() => new(v * 0.000684);
        public Area KvadratFot() => new(v * 0.098501);
        public Area KvadratAln() => new(v * 0.394007);
        public Area Kappland() => new(v * 154.26);
        public Area Tunnland() => new(v * 4_936.32);
    }

    extension(Area a)
    {
        public double ToKvadratTum() => a.SquareMeters / 0.000684;
        public double ToKvadratFot() => a.SquareMeters / 0.098501;
        public double ToKvadratAln() => a.SquareMeters / 0.394007;
        public double ToKappland() => a.SquareMeters / 154.26;
        public double ToTunnland() => a.SquareMeters / 4_936.32;
    }
}
