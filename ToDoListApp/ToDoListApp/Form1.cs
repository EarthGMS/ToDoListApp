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
        public List<string> TaskNameList;
        public List<string> TaskDescList;
        public ToDoListApp()
        {
            InitializeComponent();
            TaskNameList = new List<string>();
            TaskDescList = new List<string>();
        }

        private void ToDoListApp_Load(object sender, EventArgs e)
        {

        }

        private void SaveTextButton_Click(object sender, EventArgs e)
        {
            TaskNameList.Add(TaskNameInput1.Text);
            TaskDescList.Add(TaskDesc1.Text);
            TaskDropdown.Items.AddRange(TaskNameList.ToArray());
        }

        private void TaskDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaskNameInput1.Text = TaskNameList[TaskDropdown.SelectedIndex];
            TaskDesc1.Text = TaskDescList[TaskDropdown.SelectedIndex];
        }
    }
}
