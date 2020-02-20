using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseServiceTool
{
  interface ITasks
  {
    SqlConnection Connection
    {
      get; set;
    }
    List<string> TaskList { get; }

    string ExecuteTask(string taskName);
  }
}
