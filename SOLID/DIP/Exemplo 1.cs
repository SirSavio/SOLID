using System.Data.Common;

namespace SOLID.DIP
{
    public class DB
    {
        //Errado pacas
        //Criando a instancia da conexão no met
        public static void Connect()
        {
            var db = new DbConnection();
            db.Connect();
        }
    }

    public class DB
    {
        //Errado
        //Fera o principio pois está dependendo da implementação
        public static void Connect(DbConnection db)
        {
            db.Connect();
        }
    }

    public class DB
    {
        //Ideal
        public static void Connect(IDbConnection db)
        {
            db.Connect();
        }
    }

}
