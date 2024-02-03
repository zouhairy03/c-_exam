// DbConnector.cs
using MySql.Data.MySqlClient;

public static class DbConnector
{
    private const string ConnectionString = "Server=localhost;Port=8889;Database=BankDatabase;User=root;Password=root;";

    public static MySqlConnection GetConnection()
    {
        return new MySqlConnection(ConnectionString);
    }
}
