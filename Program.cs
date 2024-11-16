using System;
using MySql.Data.MySqlClient; // Import MySQL library
using PhysioDynamik_Prototype_1;
class Program
{
    static void Main(string[] args)
    {
        // Your test code here
        DatabaseHelper dbHelper = new DatabaseHelper();
        dbHelper.TestConnection();

        Manager manager = new Manager();
        DateTime reportDate = new DateTime(2024, 10, 1);
        manager.ReviewMonthlyPerformanceReport(reportDate);
    }
}
