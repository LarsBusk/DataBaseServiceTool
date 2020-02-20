using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseServiceTool
{
  class SqlServerHelper
  {
    public SqlConnection Connection => SqlExpressConnection(ServerName);

    public string ServerName { get; set; }
    private SqlConnection SqlExpressConnection(string serverName = "mst-win10")
    {
      SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
      builder.DataSource = $"{serverName}\\SqlExpress";
      builder.IntegratedSecurity = true;
      builder.InitialCatalog = "master";

      string connectionString = builder.ToString();

      return new SqlConnection(connectionString);
    }

    public List<string> GetDataBaseNames()
    {
      string query = "Select Name From sys.Databases";

      List<string> names = new List<string>();

      SqlConnection connection = SqlExpressConnection(ServerName);
      connection.Open();
      SqlCommand command = new SqlCommand(query, connection);

      SqlDataReader reader = command.ExecuteReader();

      while (reader.Read())
      {
        names.Add(reader.GetString(0));
      }

      connection.Close();

      return names;
    }
  }
}
