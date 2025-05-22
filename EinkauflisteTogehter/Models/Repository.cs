namespace EinkauflisteTogehter.Models;

public static class Repository
{
   private static List<Position> Positions = new();

   public static IEnumerable<Position> Postions 
   {
      get {return Positions;}
   }

   public static void AddPosition(Position position)
   {
      Positions.Add(position);
   }
}