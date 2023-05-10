
using Microsoft.Data.SqlClient;

SqlConnection connection; // stores information about connection to database

SqlCommand command; // store sql commands

SqlDataReader reader; //reading data from database


string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=(localdb)\\mssqllocaldb;Integrated Security=True;Pooling=False";
connection = new SqlConnection(connectionString);

command = new SqlCommand("Select * from players", connection);

connection.Open();

reader = command.ExecuteReader();


while (reader.Read())
{
    string resoult = reader.GetValue(2) + " " + reader.GetValue(3);
    Console.WriteLine(resoult);
}    

connection.Close(); 