namespace EinkauflisteTogehter.Models;

public static class Repository
{
   private static int lastId = 0;
   
   private static List<Position> Positions = new();

   public static IEnumerable<Position> Postions 
   {
      get {return Positions;}
   }

   public static void AddPosition(Position position)
   {
      position.Id = lastId++;
      Positions.Add(position);
   }

   public static void RemovePosition(int id)
   {
      var postition = Positions.FirstOrDefault(p => p.Id == id);
      if (postition != null)
      {
         Positions.Remove(postition);
      }
   }
}