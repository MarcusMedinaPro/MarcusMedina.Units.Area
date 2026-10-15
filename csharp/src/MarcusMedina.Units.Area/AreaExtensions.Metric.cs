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
    extension(int v)
    {
        public Area SquareMillimeters() => new(v * 0.000_001);
        public Area SquareCentimeters() => new(v * 0.000_1);
        public Area SquareDecimeters() => new(v * 0.01);
        public Area SquareMeters() => new(v);
        /// <summary>1 are = 100 m²</summary>
        public Area Ares() => new(v * 100.0);
        /// <summary>1 hektar = 10 000 m²</summary>
        public Area Hectares() => new(v * 10_000.0);
        public Area SquareKilometers() => new(v * 1_000_000.0);
    }

    extension(double v)
    {
        public Area SquareMillimeters() => new(v * 0.000_001);
        public Area SquareCentimeters() => new(v * 0.000_1);
        public Area SquareDecimeters() => new(v * 0.01);
        public Area SquareMeters() => new(v);
        public Area Ares() => new(v * 100.0);
        public Area Hectares() => new(v * 10_000.0);
        public Area SquareKilometers() => new(v * 1_000_000.0);
    }

    extension(Area a)
    {
        public double ToSquareMillimeters() => a.SquareMeters / 0.000_001;
        public double ToSquareCentimeters() => a.SquareMeters / 0.000_1;
        public double ToSquareDecimeters() => a.SquareMeters / 0.01;
        public double ToSquareMeters() => a.SquareMeters;
        public double ToAres() => a.SquareMeters / 100.0;
        public double ToHectares() => a.SquareMeters / 10_000.0;
        public double ToSquareKilometers() => a.SquareMeters / 1_000_000.0;
    }
}
