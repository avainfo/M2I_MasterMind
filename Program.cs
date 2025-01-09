using System.Data;
using MySql.Data.MySqlClient;

namespace MasterMind;

public class Program
{
	public static void Main(string[] args)
	{
		const string connectionString = "Server=localhost;Port=3306;Database=cours;User=root;Password=root";
		MySqlConnection con = new MySqlConnection(connectionString);

		con.Open();
		
		if (con.State == ConnectionState.Open) Console.WriteLine(@"Connexion réussie !");

		MySqlCommand query = new MySqlCommand("SELECT * FROM Clients", con);

		using (MySqlDataReader reader = query.ExecuteReader())
		{
			while (reader.Read())
			{
				Console.WriteLine($@"{reader["firstname"]} {reader["lastname"]}:		{reader["email"]}");
			}
		}

		MySqlCommand query2 = new MySqlCommand(
			"insert into Clients (lastname, firstname, email) value ('xxx', 'xxx', 'xxx@xxx.xxx')",
			con
		);

		int y = query2.ExecuteNonQuery();
		Console.WriteLine(y);
	}
}