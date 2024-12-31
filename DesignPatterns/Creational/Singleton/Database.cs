namespace DesignPatterns.Creational.Singleton;

public class Database
{
   private static Database? _instance;
   private string _query;

   private Database()
   {
      
   }

   public static Database Instance()
   {
      if (_instance == null)
      {
         lock (typeof(Database))
         {
            _instance = new Database();
         }
      }
      return _instance;
   }

   public void Query(string query)
   {
      _query = query;
   }

   public string Execute()
   {
      if(_query == null)
         throw new Exception("No query provided");
      return "PRODUCT RESULT";
   }
   
   
}