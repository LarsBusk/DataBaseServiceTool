using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseServiceTool
{
  class CommonTasks : ITasks
  {
    public List<string> TaskList { get; }

    public SqlConnection Connection { get; set; }

    private string selectedDatabase;

    public CommonTasks(SqlConnection connection, string selectedDatabase)
    {
      TaskList = new List<string>();
      TaskList.AddRange(new[] {"Backup", "Restore"});
      this.selectedDatabase = selectedDatabase;
      this.Connection = connection;
    }

    public string ExecuteTask(string taskName)
    {
      switch (taskName)
      {
        case "Restore":
          return RestoreDataBase(selectedDatabase);
        case "Backup":
          return BackupDatabase(selectedDatabase);
        default:
          return string.Empty;
      }
    }

    private string BackupDatabase(string database)
    {
      SaveFileDialog dialog = new SaveFileDialog();
      dialog.DefaultExt = "bak";

      if (dialog.ShowDialog() != DialogResult.Cancel)
      {
        string query = $"Backup Database {database} to disk='{dialog.FileName}'";
        Connection.Open();
        SqlCommand command = new SqlCommand(query, Connection);
        command.ExecuteReader();
      }
      
      return "BackingUp";
    }

    private string RestoreDataBase(string database)
    {
      return "Restoring";
    }
  }
}
