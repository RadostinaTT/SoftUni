using Microsoft.Data.SqlClient;
using System;
using System.Text;

namespace _03_Minion_Names
{
    class StartUp
    {
        private const string ConnectionString = @"Server=LAPTOP-0TN9PVA8;Database=MinionsDB;Integrated Security=true;";
        static void Main(string[] args)
        {
            using SqlConnection sqlConnection = new SqlConnection(ConnectionString);

            sqlConnection.Open();

            int Id = int.Parse(Console.ReadLine());

            string result = GetMinionsInfoAboutVillian(sqlConnection, Id);

            Console.WriteLine(result);
        }

        private static string GetMinionsInfoAboutVillian(SqlConnection sqlConnection, int Id)
        {
            StringBuilder sb = new StringBuilder();

            string getVillianNameQueryText = @"SELECT Name FROM Villains WHERE Id = @Id";

            using SqlCommand getVilliantNameCmd = new SqlCommand(getVillianNameQueryText, sqlConnection);

            getVilliantNameCmd.Parameters.AddWithValue("@Id", Id);

            string villianName = getVilliantNameCmd.ExecuteScalar()?.ToString();

            if (villianName == null)
            {
                sb.AppendLine($"No villain with ID {Id} exists in the database.");
            }
            else
            {
                sb.AppendLine($"Villian: {villianName}");

                string getMinionsInfoQueryText = @"SELECT m.[Name], 
                                                          m.Age
                                                        FROM Villains AS v
	                                                    LEFT OUTER JOIN MinionsVillains AS mv ON v.Id = MV.VillainId
                                                        LEFT OUTER JOIN Minions As m ON mv.MinionId = m.Id
                                                        WHERE v.[Name] = @villianName
                                                    ORDER BY m.Name;";
                SqlCommand getMinionInfoCmd = new SqlCommand(getMinionsInfoQueryText, sqlConnection);

                getMinionInfoCmd.Parameters.AddWithValue("@villianName", villianName);

                using SqlDataReader reader = getMinionInfoCmd.ExecuteReader();

                if (reader.HasRows)
                {
                    int rowNumber = 1;

                    while (reader.Read())
                    {
                        string minionName = reader["Name"]?.ToString();
                        string minionAge = reader["Age"]?.ToString();

                        if (minionAge == "" && minionName == "")
                        {
                            sb.AppendLine("(no minions)");
                            break;
                        }

                        sb.AppendLine($"{rowNumber}. {minionName} {minionAge}");

                        rowNumber++;
                    }
                }
                else
                {
                    sb.AppendLine("(no minions)");
                }
            }

            return sb.ToString().TrimEnd();
        }
    }
}
