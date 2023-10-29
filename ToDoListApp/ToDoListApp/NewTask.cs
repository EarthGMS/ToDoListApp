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
            //MainPage.TaskNameList.Add(MainPage.TaskNameInput1.Text);
            //MainPage.TaskDescList.Add(MainPage.TaskDesc1.Text);
            //MainPage.TaskDropdown.Items.AddRange(MainPage.TaskNameList.ToArray());
        }
    }
}
