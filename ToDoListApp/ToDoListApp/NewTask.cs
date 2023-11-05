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
        string nameText = null;
        string DescText = null;
        public ToDoListApp MainPage;
        public NewTask()
        {
            InitializeComponent();
            MainPage = new ToDoListApp();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (StreamReader NameList = new StreamReader("D:/github repo/ToDoListApp/ToDoListApp/ToDoListApp/ToDoNameList.txt"))
            {
                nameText = NameList.ReadToEnd();
                NameList.Close();
            }
            using (StreamWriter Name = new StreamWriter("D:/github repo/ToDoListApp/ToDoListApp/ToDoListApp/ToDoNameList.txt"))
            {
                Name.Write(nameText);
                Name.Write("\n" + TaskNameInput.Text);
            }
            using (StreamReader DescList = new StreamReader("D:/github repo/ToDoListApp/ToDoListApp/ToDoListApp/ToDoDescList.txt"))
            {
                DescText = DescList.ReadToEnd();
                DescList.Close();
            }
            using (StreamWriter Desc = new StreamWriter("D:/github repo/ToDoListApp/ToDoListApp/ToDoListApp/ToDoDescList.txt"))
            {
                Desc.Write(DescText);
                Desc.Write("\n"+TaskDescInput.Text);
            }
            MainPage.Show();
            Close();
        }
    }
}
