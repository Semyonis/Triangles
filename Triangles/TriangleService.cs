using System;

namespace Triangles;

public sealed class TriangleService :
    ITriangleService
{

    public TriangleType GetType(
        double sideA,
        double sideB,
        double sideC,
        double accuracy = Constants.Accuracy
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

        if (hypotenuse < sumOfLegs -  accuracy)
            return TriangleType.Acute;

        if (hypotenuse > sumOfLegs + accuracy)
            return TriangleType.Obtuse;
        
        return TriangleType.Right;
    }
}