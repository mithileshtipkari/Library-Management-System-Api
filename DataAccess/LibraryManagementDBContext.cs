using MongoDB.Driver;

namespace DataAccess
{
    public class LibraryManagementDBContext
    {
        private readonly IMongoDatabase _database = null;

        #region MyRegion

        private static readonly LibraryManagementDBContext _instance = new LibraryManagementDBContext();

        public static LibraryManagementDBContext Instance
        {
            get
            {
                return _instance;
            }
        }

        public LibraryManagementDBContext()
        {
            var connectionString = "";
        }
        #endregion

    }
}
