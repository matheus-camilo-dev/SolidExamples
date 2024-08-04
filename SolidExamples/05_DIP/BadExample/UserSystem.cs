namespace SolidExamples._05_DIP.BadExample
{
    internal class User;
    internal class SqlServerConnection
    {
        public void OpenSqlConnection() { /* Some Code */ }
        public void Add(User user) { /* Some Code */ }
        public void CloseSqlConnection() { /* Some Code */ }
    };
    internal class UserSystem
    {
        public void SaveNew(User user)
        {
            // SqlServer is now a System Dependence
            var connection = new SqlServerConnection();
            connection.OpenSqlConnection();
            connection.Add(user);
            connection.CloseSqlConnection();
        }
    }
}
