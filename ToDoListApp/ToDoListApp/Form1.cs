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

        List<string> TaskNameLine;
        List<string> TaskDescLine;

        public NewTask NewTaskPage;
        public ToDoListApp()
        {
            InitializeComponent();
            TaskNameList = new List<string>();
            TaskDescList = new List<string>();

            TaskNameLine = new List<string>();
            TaskDescLine = new List<string>();

            using (StreamReader NameList = new StreamReader("D:/github repo/ToDoListApp/ToDoListApp/ToDoListApp/ToDoNameList.txt"))
            {
                TaskNameLine.Add(NameList.ReadLine());
                NameList.Close();
            }
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

        private void FinishTask_Click(object sender, EventArgs e)
        {
            int LineToRemove = TaskDropdown.SelectedIndex;
            TaskNameList.RemoveAt(LineToRemove);
            TaskDescList.RemoveAt(LineToRemove);
            
            using (StreamWriter Name = new StreamWriter("D:/github repo/ToDoListApp/ToDoListApp/ToDoListApp/ToDoNameList.txt"))
            {
               for (int i = 0; i <= TaskNameList.Count - 1; i++)
                {
                    Name.Write(TaskNameList[i] + "\n");
                }
            }

            using (StreamWriter Desc = new StreamWriter("D:/github repo/ToDoListApp/ToDoListApp/ToDoListApp/ToDoDescList.txt"))
            {
                for (int i = 0; i <= TaskDescList.Count - 1; i++)
                {
                    Desc.Write(TaskDescList[i] + "\n");
                }
            }
        }
    }
}
