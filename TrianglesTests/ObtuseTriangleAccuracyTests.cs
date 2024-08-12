using FluentAssertions;
using Triangles;
using Xunit;

namespace TrianglesTests;

public sealed class ObtuseTriangleAccuracyTests
{
    [Theory]
    [InlineData(5, 2.9999, 4.00001)]
    public void ObtuseTriangleTest(
        double sideA,
        double sideB,
        double sideC
    )
    {
        var triangleService =
            new TriangleService();

        var type =
            triangleService
                .GetType(
                    sideA,
                    sideB,
                    sideC
                );

        type
            .Should()
            .Be(TriangleType.Obtuse);
    }
}