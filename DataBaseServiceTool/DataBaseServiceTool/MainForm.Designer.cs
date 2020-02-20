namespace DataBaseServiceTool
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.connectButton = new System.Windows.Forms.Button();
      this.richTextBox1 = new System.Windows.Forms.RichTextBox();
      this.serverNameTextBox = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.dataBaseCombo = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.TaskListBox = new System.Windows.Forms.ListBox();
      this.ExecuteButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // connectButton
      // 
      this.connectButton.Location = new System.Drawing.Point(628, 69);
      this.connectButton.Name = "connectButton";
      this.connectButton.Size = new System.Drawing.Size(113, 23);
      this.connectButton.TabIndex = 0;
      this.connectButton.Text = "Connect to server";
      this.connectButton.UseVisualStyleBackColor = true;
      this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
      // 
      // richTextBox1
      // 
      this.richTextBox1.Location = new System.Drawing.Point(46, 32);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.Size = new System.Drawing.Size(398, 350);
      this.richTextBox1.TabIndex = 1;
      this.richTextBox1.Text = "";
      // 
      // serverNameTextBox
      // 
      this.serverNameTextBox.Location = new System.Drawing.Point(628, 43);
      this.serverNameTextBox.Name = "serverNameTextBox";
      this.serverNameTextBox.Size = new System.Drawing.Size(160, 20);
      this.serverNameTextBox.TabIndex = 2;
      this.serverNameTextBox.Text = "mst-win10";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(551, 46);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(67, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Server name";
      // 
      // dataBaseCombo
      // 
      this.dataBaseCombo.Enabled = false;
      this.dataBaseCombo.FormattingEnabled = true;
      this.dataBaseCombo.Location = new System.Drawing.Point(626, 107);
      this.dataBaseCombo.Name = "dataBaseCombo";
      this.dataBaseCombo.Size = new System.Drawing.Size(121, 21);
      this.dataBaseCombo.TabIndex = 4;
      this.dataBaseCombo.SelectedIndexChanged += new System.EventHandler(this.dataBaseCombo_SelectedIndexChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(562, 110);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(53, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Database";
      // 
      // TaskListBox
      // 
      this.TaskListBox.Enabled = false;
      this.TaskListBox.FormattingEnabled = true;
      this.TaskListBox.Location = new System.Drawing.Point(596, 167);
      this.TaskListBox.Name = "TaskListBox";
      this.TaskListBox.Size = new System.Drawing.Size(120, 95);
      this.TaskListBox.TabIndex = 6;
      // 
      // ExecuteButton
      // 
      this.ExecuteButton.Location = new System.Drawing.Point(601, 278);
      this.ExecuteButton.Name = "ExecuteButton";
      this.ExecuteButton.Size = new System.Drawing.Size(75, 23);
      this.ExecuteButton.TabIndex = 7;
      this.ExecuteButton.Text = "Execute";
      this.ExecuteButton.UseVisualStyleBackColor = true;
      this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.ExecuteButton);
      this.Controls.Add(this.TaskListBox);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.dataBaseCombo);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.serverNameTextBox);
      this.Controls.Add(this.richTextBox1);
      this.Controls.Add(this.connectButton);
      this.Name = "MainForm";
      this.Text = "Foss Nova Database service tool";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button connectButton;
    private System.Windows.Forms.RichTextBox richTextBox1;
    private System.Windows.Forms.TextBox serverNameTextBox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox dataBaseCombo;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ListBox TaskListBox;
    private System.Windows.Forms.Button ExecuteButton;
  }
}

