using System.Runtime.InteropServices.ComTypes;

namespace DataAccess
{
    public class DBConfiguration
    {
        public string Address { get; set; }

        public  string Port { get; set; }

        public string DBUser { get; set; }

        public string Password { get; set; }

    }

    public class DBConfigurator
    {
        private static readonly DBConfiguration DbConfiguration = new DBConfiguration()
        {
            Address = "localhost",
            Port = "27017",
            DBUser = "ApiUser",
            Password = "Library"
        };

        public static string GetConnectionString()
        {
            var connectionString = $"mongodb://{DbConfiguration.DBUser}:{DbConfiguration.Password}@" +
                                   $"{DbConfiguration.Address}/LibraryManagementDB";

            return connectionString;
        }
    }
}