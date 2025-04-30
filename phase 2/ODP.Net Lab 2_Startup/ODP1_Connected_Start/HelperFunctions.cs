using Oracle.DataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;
public class HelperFunctions
{
    public HelperFunctions()
    {

    }

    public int UserExists(string username, string password, ref OracleCommand cmd)
    {
        try
        {
            string query = @"
            SELECT USERID 
            FROM Users 
            WHERE TRIM(LOWER(userName)) = TRIM(LOWER(:username)) 
              AND TRIM(LOWER(AccountPassword)) = TRIM(LOWER(:password))";

            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Clear();
            cmd.Parameters.Add(new OracleParameter("username", username));
            cmd.Parameters.Add(new OracleParameter("password", password));

            if (cmd.Connection == null || cmd.Connection.State != ConnectionState.Open)
            {
                MessageBox.Show("Database connection is not available.");
                return -1;
            }
            //Console.WriteLine(query);
            //MessageBox.Show(username);
            //MessageBox.Show(password);
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                return Convert.ToInt32(reader["USERID"]);
            }
            //using ()
            //{
            //    return reader.HasRows ? Convert.ToInt32(reader["USERID"]) : -1;
            //}
        }
        catch (OracleException ex)
        {
            MessageBox.Show($"Database error: {ex.Message}");
            return -1;
        }
        return -1;
    }
}
