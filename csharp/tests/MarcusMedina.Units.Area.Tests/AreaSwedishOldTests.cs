using MarcusMedina.Units.Area;
using MarcusMedina.Units.Area.SwedishOld;
using MarcusMedina.Units.Area.US;
using Xunit;
using FluentAssertions;

namespace MarcusMedina.Units.Area.Tests;

public class SwedishOldAreaTests
{
    [Fact] public void Tunnland_SquareMeters() => 1.0.Tunnland().SquareMeters.Should().BeApproximately(4936.32, 1e-2);
    [Fact] public void Kappland_32_ToTunnland() => 32.0.Kappland().ToTunnland().Should().BeApproximately(1, 1e-5);
    [Fact] public void KvadratAln_SquareMeters() => 1.0.KvadratAln().SquareMeters.Should().BeApproximately(0.394007, 1e-5);
    [Fact] public void KvadratFot_SquareMeters() => 1.0.KvadratFot().SquareMeters.Should().BeApproximately(0.098501, 1e-5);
    [Fact] public void Tunnland_ToAcres() => 1.0.Tunnland().ToAcres().Should().BeApproximately(1.2207, 1e-3);
}
