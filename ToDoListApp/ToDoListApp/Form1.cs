using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ToDoListApp
{
    public partial class ToDoListApp : Form
    {
        public List<string> TaskNameList;
        public List<string> TaskDescList;

        public NewTask NewTaskPage;
        public ToDoListApp()
        {
            InitializeComponent();
            TaskNameList = new List<string>();
            using (StreamReader reader = new StreamReader("D:/github repo/ToDoListApp/ToDoListApp/ToDoListApp/ToDoNameList.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    TaskNameList.Add(line);
                }
            }
            TaskDescList = new List<string>();
            TaskNameInput1.Text = TaskNameList[1];
        }

        private void ToDoListApp_Load(object sender, EventArgs e)
        {

        }

        private void SaveTextButton_Click(object sender, EventArgs e)
        {
            StreamWriter NameList = new StreamWriter("D:/github repo/ToDoListApp/ToDoListApp/ToDoListApp/ToDoNameList.txt");
            foreach(string item in TaskNameList)
            {
                NameList.WriteLine(item);
            }
            NameList.Close();
            if (TaskNameInput1.Text == "" || TaskDesc1.Text == "")
            {
                MessageBox.Show("Please put text in both boxes");
                return;
            }
            else
            {
                TaskNameList.Add(TaskNameInput1.Text);
                TaskDescList.Add(TaskDesc1.Text);
                TaskDropdown.Items.AddRange(TaskNameList.ToArray());
            }
        }

        private void TaskDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaskNameInput1.Text = TaskNameList[TaskDropdown.SelectedIndex];
            TaskDesc1.Text = TaskDescList[TaskDropdown.SelectedIndex];
        }

        private void NewTaskButton_Click(object sender, EventArgs e)
        {
            NewTaskPage = new NewTask();
            NewTaskPage.Show();
        }
    }
}
