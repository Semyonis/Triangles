using FluentAssertions;
using Triangles;
using Xunit;

namespace TrianglesTests;

public sealed class ObtuseTriangleTests
{
    [Theory]
    [InlineData(9, 6, 5)]
    [InlineData(5, 9, 6)]
    [InlineData(6, 5, 9)]
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