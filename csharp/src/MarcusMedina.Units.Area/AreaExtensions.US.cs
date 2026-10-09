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
    extension(int v)
    {
        public Area SquareInches() => new(v * 0.00064516);
        public Area SquareFeet() => new(v * 0.09290304);
        public Area SquareYards() => new(v * 0.83612736);
        /// <summary>1 acre = 4 046.8564224 m²</summary>
        public Area Acres() => new(v * 4_046.8564224);
        /// <summary>1 square mile = 2 589 988.110336 m²</summary>
        public Area SquareMiles() => new(v * 2_589_988.110336);
    }

    extension(double v)
    {
        public Area SquareInches() => new(v * 0.00064516);
        public Area SquareFeet() => new(v * 0.09290304);
        public Area SquareYards() => new(v * 0.83612736);
        public Area Acres() => new(v * 4_046.8564224);
        public Area SquareMiles() => new(v * 2_589_988.110336);
    }

    extension(Area a)
    {
        public double ToSquareInches() => a.SquareMeters / 0.00064516;
        public double ToSquareFeet() => a.SquareMeters / 0.09290304;
        public double ToSquareYards() => a.SquareMeters / 0.83612736;
        public double ToAcres() => a.SquareMeters / 4_046.8564224;
        public double ToSquareMiles() => a.SquareMeters / 2_589_988.110336;
    }
}
