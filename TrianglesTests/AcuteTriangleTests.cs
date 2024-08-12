using FluentAssertions;
using Triangles;
using Xunit;

namespace TrianglesTests;

public sealed class AcuteTriangleTests
{
    [Theory]
    [InlineData(1, 1, 1)]
    [InlineData(3, 3, 2)]
    [InlineData(2, 3, 3)]
    [InlineData(3, 2, 3)]
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
            .Be(TriangleType.Acute);
    }
}