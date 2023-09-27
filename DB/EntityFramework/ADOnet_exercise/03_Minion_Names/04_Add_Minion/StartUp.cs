using Microsoft.Data.SqlClient;
using System;
using System.Linq;
using System.Text;

namespace _04_Add_Minion
{
    class StartUp
    {
        private const string ConnectionString = @"Server=LAPTOP-0TN9PVA8;Database=MinionsDB;Integrated Security=true;";
        static void Main(string[] args)
        {
            using SqlConnection sqlConnection = new SqlConnection(ConnectionString);

            sqlConnection.Open();

            string[] minionInput = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] minionInfo = minionInput[1].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            string[] villainInput = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] villainInfo = villainInput[1].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            string result = AddMinionToDB(sqlConnection, minionInfo, villainInfo);

            Console.WriteLine(result);
        }

        private static string AddMinionToDB(SqlConnection sqlConnection, string[] minionInfo, string[] villainInfo)
        {
            StringBuilder sb = new StringBuilder();

            string minionName = minionInfo[0];
            string minionAge = minionInfo[1];
            string minionTown = minionInfo[2];

            string villainName = villainInfo[0];

            string townId = EnsureTownExists(sqlConnection, minionTown, sb);
            string villainId = EnsureVillainExists(sqlConnection, villainName, sb);

            string insertMinionText = @"INSERT INTO Minions ([Name], Age, TownId) VALUES (@name, @age, @townId)";

            using SqlCommand insertMinionCmd = new SqlCommand(insertMinionText, sqlConnection);

            insertMinionCmd.Parameters.AddWithValue("@name", minionName);
            insertMinionCmd.Parameters.AddWithValue("@age", minionAge);
            insertMinionCmd.Parameters.AddWithValue("@townId", townId);

            insertMinionCmd.ExecuteNonQuery();

            string getMinionIdQuery = @"SELECT Id FROM Minions WHERE [Name] = @Name";

            using SqlCommand getMinionIdCmd = new SqlCommand(getMinionIdQuery, sqlConnection);

            getMinionIdCmd.Parameters.AddWithValue("@Name", minionName);

            string minionId = getMinionIdCmd.ExecuteScalar().ToString();

            string addMinionToVillainText = @"INSERT INTO MinionsVillains (MinionId, VillainId) VALUES (@minionId, @villainId)";

            using SqlCommand insertMinionToVillainCmd = new SqlCommand(addMinionToVillainText, sqlConnection);

            insertMinionToVillainCmd.Parameters.AddWithValue("@villainId", villainId);
            insertMinionToVillainCmd.Parameters.AddWithValue("@minionId", minionId);

            insertMinionToVillainCmd.ExecuteNonQuery();

            sb.AppendLine($"Successfully added {minionName} to be minion of {villainName}.");

            return sb.ToString().TrimEnd();
        }

        private static string EnsureVillainExists(SqlConnection sqlConnection, string villainName, StringBuilder sb)
        {
            string getVillainIdQueryText = @"SELECT Id FROM Villains WHERE Name = @Name";

            using SqlCommand getVillainIdCmd = new SqlCommand(getVillainIdQueryText, sqlConnection);

            getVillainIdCmd.Parameters.AddWithValue("@Name", villainName);

            string villainId = getVillainIdCmd.ExecuteScalar()?.ToString();

            if (villainId == null)
            {
                string evilFactorQueryText = @"SELECT Id FROM EvilnessFactors WHERE [Name] = 'Evil'";

                using SqlCommand getEvilFactorCmd = new SqlCommand(evilFactorQueryText,sqlConnection);

                //getEvilFactorCmd.Parameters.AddWithValue("@Name", villainName);

                string evilFactor = getEvilFactorCmd.ExecuteScalar()?.ToString();

                string insertVillainQueryText = @"INSERT INTO Villains (Name, EvilnessFactorId)  VALUES (@villainName, @evilFactor)";

                using SqlCommand insertVillainCmd = new SqlCommand(insertVillainQueryText, sqlConnection);

                insertVillainCmd.Parameters.AddWithValue("@villainName", villainName);
                insertVillainCmd.Parameters.AddWithValue("@evilFactor", evilFactor);

                insertVillainCmd.ExecuteNonQuery();

                villainId = getVillainIdCmd.ExecuteScalar().ToString();

                sb.AppendLine($"Villain {villainName} was added to the database.");
            }

            return villainId;
        }

        private static string EnsureTownExists(SqlConnection sqlConnection, string minionTown, StringBuilder sb)
        {
            string getTownIdQueryText = @"SELECT Id FROM Towns WHERE Name = @townName";

            using SqlCommand getTownIdCmd = new SqlCommand(getTownIdQueryText, sqlConnection);

            getTownIdCmd.Parameters.AddWithValue("@townName", minionTown);

            string townId = getTownIdCmd.ExecuteScalar()?.ToString();

            if (townId == null)
            {
                string insertTownQueryText = @"INSERT INTO Towns ([Name], CountryCode) VALUES (@townName, 1)";

                using SqlCommand insertTownCmd = new SqlCommand(insertTownQueryText, sqlConnection);

                insertTownCmd.Parameters.AddWithValue("@townName", minionTown);

                insertTownCmd.ExecuteNonQuery();

                townId = getTownIdCmd.ExecuteScalar().ToString();

                sb.AppendLine($"Town {minionTown} was added to the database.");
            }

            return townId;
        }
    }
}
