using System;

namespace singleton.Services
{
    public class DbService
    {
        private DbService()
        {
            openConnection();
        }

        #region Instance methods
        private void openConnection() => Console.WriteLine($"Openning connection for {GetType().Name}");
        private void closeConnection() => Console.WriteLine($"Closing connection for {GetType().Name}");
        public void Save<T>(T obj) => Console.WriteLine($"Saving object of type: {obj.GetType().Name}");
        #endregion

        #region Static methods
        private static DbService dbService;

        public static DbService Get()
        {
            if (dbService == null) dbService = new DbService();
            return dbService;
        }

        public static void Close()
        {
            if (dbService == null) return;
            dbService.closeConnection();
            dbService = null;
        }
        #endregion
    }
}
