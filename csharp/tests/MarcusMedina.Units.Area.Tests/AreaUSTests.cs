using MarcusMedina.Units.Area;
using MarcusMedina.Units.Area.US;
using MarcusMedina.Units.Area.Metric;
using Xunit;
using FluentAssertions;

namespace MarcusMedina.Units.Area.Tests;

public class USAreaTests
{
    [Fact] public void Acre_ToHectares() => 1.0.Acres().ToHectares().Should().BeApproximately(0.404686, 1e-5);
    [Fact] public void SquareMile_ToAcres() => 1.0.SquareMiles().ToAcres().Should().BeApproximately(640, 1e-3);
    [Fact] public void SquareFoot_ToSquareMeters() => 1.0.SquareFeet().ToSquareMeters().Should().BeApproximately(0.09290304, 1e-9);
    [Fact] public void SquareYard_ToSquareFeet() => 1.0.SquareYards().ToSquareFeet().Should().BeApproximately(9, 1e-5);
    [Fact] public void SquareInch_ToSquareFeet() => 144.0.SquareInches().ToSquareFeet().Should().BeApproximately(1, 1e-5);
}
