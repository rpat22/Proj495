using System;
using MySql.Data.MySqlClient;

public class DatabaseHelper
{
    // Step 1: Create the connection string
    private string connectionString = "Server=localhost;Database=physiodynamikdb;User ID=root;Password=AQW@lol123/;SslMode=None;";


    // Step 2: Create a method to get the MySQL connection
    public MySqlConnection GetConnection()
    {
        return new MySqlConnection(connectionString);
    }

    // Step 3: Create a method to test the connection
    public void TestConnection()
    {
        using (var connection = GetConnection())
        {
            try
            {
                connection.Open();
                Console.WriteLine("Successfully connected to the database.");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Connection error: {ex.Message}");
            }
        }
    }
}
