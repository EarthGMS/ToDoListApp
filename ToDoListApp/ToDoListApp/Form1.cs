using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoListApp
{
    public partial class ToDoListApp : Form
    {
        Dictionary<string, string> TaskDictionary;
        public ToDoListApp()
        {
            InitializeComponent();
            TaskDictionary = new Dictionary<string, string>();
        }

        private void ToDoListApp_Load(object sender, EventArgs e)
        {

        }

        private void SaveTextButton_Click(object sender, EventArgs e)
        {
            TaskDictionary.Add(TaskNameInput1.Text, TaskDesc1.Text);
            TaskDropdown.Items.AddRange(TaskDictionary.Keys.ToArray());
        }

        private void TaskDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaskNameInput1.Text = TaskDictionary.Keys.ToString();
        }
    }
}
