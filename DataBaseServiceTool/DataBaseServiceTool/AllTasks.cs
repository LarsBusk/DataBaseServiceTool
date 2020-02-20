using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseServiceTool
{
  class AllTasks : ITasks
  {
    public List<string> TaskList { get; }

    public SqlConnection Connection { get; set; }

    private CommonTasks commonTasks;

    private ITasks instrumenTasks;

    public AllTasks(SqlConnection connection, string selectedDatabase)
    {
      commonTasks = new CommonTasks(connection, selectedDatabase);

      switch (selectedDatabase)
      {
        case "ProFoss":
          instrumenTasks = new ProFossTasks(connection);
          break;
          ;
      }

      

      TaskList = new List<string>();
      TaskList.AddRange(commonTasks.TaskList);
      TaskList.AddRange(instrumenTasks.TaskList);
    }

    public string ExecuteTask(string taskName)
    {
      if (commonTasks.TaskList.Contains(taskName))
      {
        return commonTasks.ExecuteTask(taskName);
      }
      if (instrumenTasks.TaskList.Contains(taskName))
      {
        return instrumenTasks.ExecuteTask(taskName);
      }

      return "No such task";
    }
  }
}
