using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseServiceTool
{
  class ProFossTasks : ITasks
  {
    public List<string> TaskList { get; }

    public SqlConnection Connection { get; set; }

    public ProFossTasks(SqlConnection connection)
    {
      this.Connection = connection;
      TaskList = new List<string>();
      TaskList.AddRange(new []{"Delete samples"});
    }

    public string ExecuteTask(string taskName)
    {
      switch (taskName)
      {
        case "Delete samples":
          return DeleteOldSamples();
        default:
          return "No such task";
      }
    }

    private string DeleteOldSamples()
    {
      return "Deleting samples...";
    }
  }
}
