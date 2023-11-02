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
            TaskDescList = new List<string>();
            
            TaskNameList = File.ReadAllLines("D:/github repo/ToDoListApp/ToDoListApp/ToDoListApp/ToDoNameList.txt").ToList();
            TaskDropdown.Items.AddRange(TaskNameList.ToArray());
            TaskDescList = File.ReadAllLines("D:/github repo/ToDoListApp/ToDoListApp/ToDoListApp/ToDoDescList.txt").ToList();
        }

        private void ToDoListApp_Load(object sender, EventArgs e)
        {

        }

        private void SaveTextButton_Click(object sender, EventArgs e)
        {
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

        private void DeleteTaskButton_Click(object sender, EventArgs e)
        {

            //ON PROGRESS, CAN CAUSE ERROR
            using (StreamReader NameListRead = new StreamReader("D:/github repo/ToDoListApp/ToDoListApp/ToDoListApp/ToDoNameList.txt"))
            {
                using (StreamWriter NameList = new StreamWriter("D:/github repo/ToDoListApp/ToDoListApp/ToDoListApp/ToDoNameList.txt"))
                {
                    string line;
                    string lineFill = null;
                    while ((line = NameListRead.ReadLine()) != null)
                    {
                        if (String.Compare(line, TaskNameList[TaskDropdown.SelectedIndex]) == 0)
                        {
                            NameList.WriteLine(lineFill);
                        }
                    }
                }
            }
        }
    }
}
