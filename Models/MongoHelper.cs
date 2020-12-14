using MongoDB.Driver;
using MongoDB.Bson;

namespace Commander.Models
{
    public class MongoHelper
    {
        public static IMongoClient client { get; set; }
        public static IMongoDatabase database { get; set; }
        public static string MongoConn = "mongodb+srv://crow_admin:0oDirNkF8atYnOTt@commanderapi.k3fu7.mongodb.net/<dbname>?retryWrites=true&w=majority";
        public static string MongoDb = "commander_api";
        public static BsonDocument collection = null;

        internal static void ConnectToMongoService()
        {
            try
            {
                client = new MongoClient(MongoConn);
                database = client.GetDatabase(MongoDb);
                collection = database.GetCollection<BsonDocument>("commands");

            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
    }
}