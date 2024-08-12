namespace Triangles;

public sealed class TriangleService :
    ITriangleService
{
    public TriangleType GetType(
        double sideA,
        double sideB,
        double sideC
    )
    {
        double[] sides =
            [sideA, sideB, sideC];

        Array.Sort(sides);

        var firstLeg =
            sides[0] * sides[0];

        var secondLeg =
            sides[1] * sides[1];

        var hypotenuse =
            sides[2] * sides[2];

        var sumOfLegs =
            firstLeg + secondLeg;
        
        if (hypotenuse < sumOfLegs)
            return TriangleType.Acute;

        if (hypotenuse > sumOfLegs)
            return TriangleType.Obtuse;
        
        return TriangleType.Right;
    }
}