namespace CodingChallenge.Data.Interfaces
{
    public interface IShape
    {
        string ShapeName { get; }
        decimal GetArea();
        decimal GetPerimetro();
    }
}