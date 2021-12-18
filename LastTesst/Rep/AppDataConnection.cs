using LinqToDB;
using LinqToDB.Configuration;
using LastTesst.Models;

namespace LastTesst.DataConnection
{
    // Custom Data Connection
    public class AppDataConnection : LinqToDB.Data.DataConnection
    {
        public ITable<User> User => GetTable<User>();
        public ITable<Product> Product => GetTable<Product>();

        public AppDataConnection(LinqToDbConnectionOptions<AppDataConnection> options)
            : base(options)
        {

        }
    }
}