using MarcusMedina.Units.Area;
using MarcusMedina.Units.Area.British;
using MarcusMedina.Units.Area.Metric;
using Xunit;
using FluentAssertions;

namespace MarcusMedina.Units.Area.Tests;

public class BritishAreaTests
{
    [Fact] public void Rood_ToAcres() => 1.0.Roods().ToAcres().Should().BeApproximately(0.25, 1e-6);
    [Fact] public void Acre_British_ToSquareMeters() => 1.0.Acres().ToSquareMeters().Should().BeApproximately(4046.8564224, 1e-6);
    [Fact] public void FourRoods_ToAcre() => 4.0.Roods().ToAcres().Should().BeApproximately(1, 1e-6);
    [Fact] public void SquareMile_ToAcres() => 1.0.SquareMiles().ToAcres().Should().BeApproximately(640, 1e-3);
}
