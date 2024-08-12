namespace Triangles;

public interface ITriangleService
{
    TriangleType GetType(double sideA,
        double sideB,
        double sideC, double accuracy);
}