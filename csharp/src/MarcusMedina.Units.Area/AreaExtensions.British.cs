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
    extension(int v)
    {
        public Area SquareInches() => new(v * 0.00064516);
        public Area SquareFeet() => new(v * 0.09290304);
        public Area SquareYards() => new(v * 0.83612736);
        /// <summary>1 rood = 1/4 acre = 1 011.7141056 m²</summary>
        public Area Roods() => new(v * 1_011.7141056);
        public Area Acres() => new(v * 4_046.8564224);
        public Area SquareMiles() => new(v * 2_589_988.110336);
    }

    extension(double v)
    {
        public Area SquareInches() => new(v * 0.00064516);
        public Area SquareFeet() => new(v * 0.09290304);
        public Area SquareYards() => new(v * 0.83612736);
        public Area Roods() => new(v * 1_011.7141056);
        public Area Acres() => new(v * 4_046.8564224);
        public Area SquareMiles() => new(v * 2_589_988.110336);
    }

    extension(Area a)
    {
        public double ToSquareInches() => a.SquareMeters / 0.00064516;
        public double ToSquareFeet() => a.SquareMeters / 0.09290304;
        public double ToSquareYards() => a.SquareMeters / 0.83612736;
        public double ToRoods() => a.SquareMeters / 1_011.7141056;
        public double ToAcres() => a.SquareMeters / 4_046.8564224;
        public double ToSquareMiles() => a.SquareMeters / 2_589_988.110336;
    }
}
