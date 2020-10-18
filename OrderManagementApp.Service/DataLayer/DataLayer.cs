using OrderManagementApp.Service.Models;
using System.Data;
using System.Data.SqlClient;

namespace OrderManagementApp.Service.DataLayer
{
    public class DataLayer : IDataLayer
    {
        private readonly SqlConnection connection;
        public DataLayer()
        {
            string sqlCon = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
            @"AttachDbFilename=C:\Users\arnew\source\repos\OrderManagementApp\OrderManagementApp.Service\Database.mdf;
            Integrated Security=True;
            Connect Timeout=30";

             connection = new SqlConnection(sqlCon);
        }

        public User GetUser(string username, string password)
        {
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";
            command.Parameters.AddWithValue("Username", username);
            command.Parameters.AddWithValue("Password", password);

            // Read all the data that comes back from the database
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

            if (!reader.HasRows) {
                connection.Close();
                return null; 
            }

            reader.Read();

            User user = new User();
            user.Username = (string)reader["Username"];

            connection.Close();
            return user;
        }

        // Augment the data layer to include methods to manipulate data
        // For example add orders, delete orders etc.
    }
}
