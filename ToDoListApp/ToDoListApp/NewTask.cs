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
    public partial class NewTask : Form
    {
        public ToDoListApp MainPage;
        public NewTask()
        {
            InitializeComponent();
            MainPage = new ToDoListApp();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter NameList = new StreamWriter("D:/github repo/ToDoListApp/ToDoListApp/ToDoListApp/ToDoNameList.txt"))
            {
                NameList.WriteLine(TaskNameInput.Text);
            }
            using (StreamWriter DescList = new StreamWriter("D:/github repo/ToDoListApp/ToDoListApp/ToDoListApp/ToDoDescList.txt"))
            {
                DescList.WriteLine(TaskDescInput.Text);
            }
            MainPage.Show();
            Close();
        }
    }
}
