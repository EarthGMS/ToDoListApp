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
        public ToDoListApp()
        {
            InitializeComponent();
            // Create a new button
            Button dynamicButton = new Button();
            dynamicButton.Text = "Dynamic Button";
            dynamicButton.Location = new System.Drawing.Point(100, 100);
            dynamicButton.Size = new System.Drawing.Size(100, 30);

            // Add the button to the form's controls
            this.Controls.Add(dynamicButton);

        }

        private void ToDoListApp_Load(object sender, EventArgs e)
        {

        }
    }
}
