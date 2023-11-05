
namespace ToDoListApp
{
    partial class ToDoListApp
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
            this.AppLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NewTaskButton = new System.Windows.Forms.Button();
            this.SaveTextButton = new System.Windows.Forms.Button();
            this.FinishTask = new System.Windows.Forms.Button();
            this.TaskDesc1 = new System.Windows.Forms.TextBox();
            this.TaskDescLabel = new System.Windows.Forms.Label();
            this.TaskName1 = new System.Windows.Forms.Label();
            this.TaskNameInput1 = new System.Windows.Forms.TextBox();
            this.TaskDropdown = new System.Windows.Forms.ComboBox();
            this.TaskChooseLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AppLabel
            // 
            this.AppLabel.AutoSize = true;
            this.AppLabel.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppLabel.Location = new System.Drawing.Point(276, 9);
            this.AppLabel.Name = "AppLabel";
            this.AppLabel.Size = new System.Drawing.Size(236, 39);
            this.AppLabel.TabIndex = 0;
            this.AppLabel.Text = "TO-DO LIST APP";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NewTaskButton);
            this.panel1.Controls.Add(this.SaveTextButton);
            this.panel1.Controls.Add(this.FinishTask);
            this.panel1.Controls.Add(this.TaskDesc1);
            this.panel1.Controls.Add(this.TaskDescLabel);
            this.panel1.Controls.Add(this.TaskName1);
            this.panel1.Controls.Add(this.TaskNameInput1);
            this.panel1.Location = new System.Drawing.Point(26, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 294);
            this.panel1.TabIndex = 1;
            // 
            // NewTaskButton
            // 
            this.NewTaskButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.NewTaskButton.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewTaskButton.Location = new System.Drawing.Point(502, 189);
            this.NewTaskButton.Name = "NewTaskButton";
            this.NewTaskButton.Size = new System.Drawing.Size(143, 34);
            this.NewTaskButton.TabIndex = 10;
            this.NewTaskButton.Text = "New task";
            this.NewTaskButton.UseVisualStyleBackColor = false;
            this.NewTaskButton.Click += new System.EventHandler(this.NewTaskButton_Click);
            // 
            // SaveTextButton
            // 
            this.SaveTextButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SaveTextButton.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveTextButton.Location = new System.Drawing.Point(502, 137);
            this.SaveTextButton.Name = "SaveTextButton";
            this.SaveTextButton.Size = new System.Drawing.Size(143, 34);
            this.SaveTextButton.TabIndex = 9;
            this.SaveTextButton.Text = "Save text";
            this.SaveTextButton.UseVisualStyleBackColor = false;
            this.SaveTextButton.Click += new System.EventHandler(this.SaveTextButton_Click);
            // 
            // FinishTask
            // 
            this.FinishTask.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.FinishTask.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishTask.Location = new System.Drawing.Point(502, 19);
            this.FinishTask.Name = "FinishTask";
            this.FinishTask.Size = new System.Drawing.Size(143, 34);
            this.FinishTask.TabIndex = 5;
            this.FinishTask.Text = "Finish task";
            this.FinishTask.UseVisualStyleBackColor = false;
            this.FinishTask.Click += new System.EventHandler(this.FinishTask_Click);
            // 
            // TaskDesc1
            // 
            this.TaskDesc1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskDesc1.Location = new System.Drawing.Point(16, 101);
            this.TaskDesc1.Multiline = true;
            this.TaskDesc1.Name = "TaskDesc1";
            this.TaskDesc1.ReadOnly = true;
            this.TaskDesc1.Size = new System.Drawing.Size(388, 175);
            this.TaskDesc1.TabIndex = 7;
            // 
            // TaskDescLabel
            // 
            this.TaskDescLabel.AutoSize = true;
            this.TaskDescLabel.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskDescLabel.Location = new System.Drawing.Point(12, 69);
            this.TaskDescLabel.Name = "TaskDescLabel";
            this.TaskDescLabel.Size = new System.Drawing.Size(173, 23);
            this.TaskDescLabel.TabIndex = 6;
            this.TaskDescLabel.Text = "TASK DESCRIPTION:";
            // 
            // TaskName1
            // 
            this.TaskName1.AutoSize = true;
            this.TaskName1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskName1.Location = new System.Drawing.Point(12, 24);
            this.TaskName1.Name = "TaskName1";
            this.TaskName1.Size = new System.Drawing.Size(113, 23);
            this.TaskName1.TabIndex = 5;
            this.TaskName1.Text = "TASK NAME:";
            // 
            // TaskNameInput1
            // 
            this.TaskNameInput1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskNameInput1.Location = new System.Drawing.Point(141, 21);
            this.TaskNameInput1.Name = "TaskNameInput1";
            this.TaskNameInput1.ReadOnly = true;
            this.TaskNameInput1.Size = new System.Drawing.Size(263, 31);
            this.TaskNameInput1.TabIndex = 5;
            // 
            // TaskDropdown
            // 
            this.TaskDropdown.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskDropdown.FormattingEnabled = true;
            this.TaskDropdown.Location = new System.Drawing.Point(167, 79);
            this.TaskDropdown.Name = "TaskDropdown";
            this.TaskDropdown.Size = new System.Drawing.Size(150, 31);
            this.TaskDropdown.TabIndex = 0;
            this.TaskDropdown.SelectedIndexChanged += new System.EventHandler(this.TaskDropdown_SelectedIndexChanged);
            // 
            // TaskChooseLabel
            // 
            this.TaskChooseLabel.AutoSize = true;
            this.TaskChooseLabel.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskChooseLabel.Location = new System.Drawing.Point(22, 82);
            this.TaskChooseLabel.Name = "TaskChooseLabel";
            this.TaskChooseLabel.Size = new System.Drawing.Size(122, 23);
            this.TaskChooseLabel.TabIndex = 4;
            this.TaskChooseLabel.Text = "SELECT TASK:";
            // 
            // ToDoListApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TaskChooseLabel);
            this.Controls.Add(this.TaskDropdown);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AppLabel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "ToDoListApp";
            this.Text = "To-do List";
            this.Load += new System.EventHandler(this.ToDoListApp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AppLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TaskChooseLabel;
        private System.Windows.Forms.Label TaskName1;
        private System.Windows.Forms.Label TaskDescLabel;
        private System.Windows.Forms.Button FinishTask;
        private System.Windows.Forms.Button SaveTextButton;
        private System.Windows.Forms.Button NewTaskButton;
        public System.Windows.Forms.TextBox TaskNameInput1;
        public System.Windows.Forms.TextBox TaskDesc1;
        public System.Windows.Forms.ComboBox TaskDropdown;
    }
}

