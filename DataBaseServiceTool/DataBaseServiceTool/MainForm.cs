using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseServiceTool
{
  public partial class MainForm : Form
  {
    private SqlServerHelper helper;

    private ITasks allTasks;

    public MainForm()
    {
      InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      helper = new SqlServerHelper();
    }

    private void connectButton_Click(object sender, EventArgs e)
    {
      helper.ServerName = serverNameTextBox.Text;

      foreach (var dataBaseName in helper.GetDataBaseNames())
      {
        richTextBox1.AppendText($"{dataBaseName}\n");
        dataBaseCombo.Items.Add(dataBaseName);
        dataBaseCombo.Enabled = true;
      }
    }

    private void dataBaseCombo_SelectedIndexChanged(object sender, EventArgs e)
    {
      allTasks = new AllTasks(helper.Connection, dataBaseCombo.Text);

      TaskListBox.Items.Clear();
      TaskListBox.Items.AddRange(allTasks.TaskList.ToArray());
      TaskListBox.Enabled = true;
    }

    private void ExecuteButton_Click(object sender, EventArgs e)
    {
      string result = allTasks.ExecuteTask(TaskListBox.Text);
      richTextBox1.AppendText($"{result}\n");
    }
  }
}
