using FluentAssertions;
using Triangles;
using Xunit;

namespace TrianglesTests;

public sealed class RightTriangleAccuracyTests
{
    [Theory]
    [InlineData(5, 2.99999, 4)]
    public void AcuteTriangleTest(
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