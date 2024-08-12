using FluentAssertions;
using Triangles;
using Xunit;

namespace TrianglesTests;

public sealed class RightTriangleTests
{
    [Theory]
    [InlineData(5, 3, 4)]
    [InlineData(4, 5, 3)]
    [InlineData(3, 4, 5)]
    public void RightTriangleTest(
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
            .Be(TriangleType.Right);
    }
}