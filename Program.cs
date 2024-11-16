using System;
using MySql.Data.MySqlClient; // Import MySQL library

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the DatabaseHelper class
        DatabaseHelper dbHelper = new DatabaseHelper();

        // Use the helper class to test the connection
        dbHelper.TestConnection();
        // Example: Additional methods can be called here for CRUD operations
    }
}
