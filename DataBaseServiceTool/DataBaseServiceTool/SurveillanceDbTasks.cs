using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseServiceTool
{
  class SurveillanceDbTasks : ITasks
  {
    List<string> ITasks.TaskList => throw new NotImplementedException();

    public SqlConnection Connection { get; set; }

    string ITasks.ExecuteTask(string taskName)
    {
      throw new NotImplementedException();
    }
  }
}
