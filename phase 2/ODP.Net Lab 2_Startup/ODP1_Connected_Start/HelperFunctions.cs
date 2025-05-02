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
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                return Convert.ToInt32(reader["USERID"]);
            }
          
        }
        catch (OracleException ex)
        {
            MessageBox.Show($"Database error: {ex.Message}");
            return -1;
        }
        return -1;
    }

    public OracleDataReader RetrieveAllMovies(ref OracleCommand cmd) {

        cmd.CommandText = "GetAllMovies";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Clear();
        cmd.Parameters.Add("p_movies", OracleDbType.RefCursor, ParameterDirection.Output);
        
        if (cmd.Connection.State != ConnectionState.Open)
            cmd.Connection.Open();

        return cmd.ExecuteReader();
    }


    public OracleDataReader RetrieveShowsForMovie(ref OracleCommand cmd, int movieID) {

        cmd.CommandText = "GetShowsForMovie";

        cmd.CommandType = CommandType.StoredProcedure;
        
        cmd.Parameters.Clear();
        cmd.Parameters.Add("p_movie_id", OracleDbType.Int32).Value = movieID;
        cmd.Parameters.Add("p_shows_cursor", OracleDbType.RefCursor, ParameterDirection.Output);

        if (cmd.Connection.State != ConnectionState.Open)
            cmd.Connection.Open();

        return cmd.ExecuteReader();
    }

    public int getShowPrice(ref OracleCommand cmd, int showID)
    {
        cmd.CommandText = "GetPriceForShow";

        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Clear();
        cmd.Parameters.Add("show_id", OracleDbType.Int32).Value = showID;
        cmd.Parameters.Add("price", OracleDbType.Int32, ParameterDirection.Output);

        if (cmd.Connection.State != ConnectionState.Open)
            cmd.Connection.Open();

        int r = cmd.ExecuteNonQuery();

        int price = Convert.ToInt32(cmd.Parameters["price"].Value.ToString());
        
        return price;
    }

}
