using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace StudentEnrollment
{
	class Program
	{
		static void Main()
		{
			string connStr = "server=localhost;user=root;database=world;port=3306;password=heidelberg";
			MySqlConnection conn = new MySqlConnection(connStr);
			try
			{
				Console.WriteLine("Connecting to MySQL...");
				conn.Open();

				string sql = "SELECT * FROM Classes";
				MySqlCommand cmd = new MySqlCommand(sql, conn);
				MySqlDataReader rdr = cmd.ExecuteReader();

				while (rdr.Read())
				{
					Console.WriteLine(rdr[0] + " -- " + rdr[1]);
				}
				rdr.Close();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
			conn.Close();
			Console.WriteLine("Done.");
		}
	}
}
