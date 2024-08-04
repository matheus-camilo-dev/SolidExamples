namespace SolidExamples._05_DIP.GoodExample
{
    internal class User;
    internal interface IDatabaseConnection
    {
        void Open();
        void Add(User user);
        void Close();
    }
    internal class SqlServerConnection : IDatabaseConnection
    {
        public void Open() { /* Some Code */ }
        public void Add(User user) { /* Some Code */ }
        public void Close() { /* Some Code */ }
    };
    internal class UserSystem
    {
        private readonly IDatabaseConnection _databaseConnection;
        public UserSystem(IDatabaseConnection databaseConnection)
        {
            _databaseConnection = databaseConnection;
        }

        public void SaveNew(User user)
        {
            _databaseConnection.Open();
            _databaseConnection.Add(user);
            _databaseConnection.Close();
        }
    }
}
