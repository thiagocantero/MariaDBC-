using System;
using MySql.Data.MySqlClient;

class Program
{
    static void Main()
    {
        string connectionString = "Server=localhost;Database=dotnet;User=<usuario do banco>;Password=<senha do banco>;";
        MySqlConnection connection = new MySqlConnection(connectionString);

        try
        {
            connection.Open();
            Console.WriteLine("Conectado ao MariaDB!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
        finally
        {
            connection.Close();
        }
    }
}
