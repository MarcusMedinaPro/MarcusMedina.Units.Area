using MarcusMedina.Units.Area;
using Xunit;
using FluentAssertions;

namespace MarcusMedina.Units.Area.Tests;

public class AreaStructTests
{
    [Fact] public void Area_StoresSquareMeters() => new Area(100).SquareMeters.Should().Be(100);
    [Fact] public void Area_Addition() => (new Area(100) + new Area(50)).SquareMeters.Should().Be(150);
    [Fact] public void Area_Subtraction() => (new Area(100) - new Area(30)).SquareMeters.Should().Be(70);
    [Fact] public void Area_Multiplication() => (new Area(100) * 3).SquareMeters.Should().Be(300);
    [Fact] public void Area_Comparison() => new Area(100).Should().BeGreaterThan(new Area(50));
}
