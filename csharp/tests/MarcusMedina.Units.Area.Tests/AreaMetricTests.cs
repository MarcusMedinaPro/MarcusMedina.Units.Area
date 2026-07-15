using MarcusMedina.Units.Area;
using MarcusMedina.Units.Area.Metric;
using Xunit;
using FluentAssertions;

namespace MarcusMedina.Units.Area.Tests;

public class MetricAreaTests
{
    [Fact] public void Hectare_ToSquareMeters() => 1.Hectares().ToSquareMeters().Should().BeApproximately(10_000, 1e-6);
    [Fact] public void SquareKilometer_ToHectares() => 1.SquareKilometers().ToHectares().Should().BeApproximately(100, 1e-6);
    [Fact] public void SquareCentimeter_ToSquareMeters() => 10_000.0.SquareCentimeters().ToSquareMeters().Should().BeApproximately(1, 1e-6);
    [Fact] public void Are_ToSquareMeters() => 1.Ares().ToSquareMeters().Should().BeApproximately(100, 1e-9);
    [Fact] public void SquareMillimeter_ToSquareCentimeters() => 100.0.SquareMillimeters().ToSquareCentimeters().Should().BeApproximately(1, 1e-6);
}
