namespace Einkaufsliste.Models;

public static class Repository
{
    public static List<Position> Positions = new();

    public static void AddPosition(Position position)
    {
        Positions.Add(position);
    }

    public static List<Position> GetPositions()
    {
        return Positions;
    }
}