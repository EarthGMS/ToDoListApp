
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
            this.TaskDropdown = new System.Windows.Forms.ComboBox();
            this.ResetTaskButton = new System.Windows.Forms.Button();
            this.TaskCount = new System.Windows.Forms.Label();
            this.TaskChooseLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AppLabel
            // 
            this.AppLabel.AutoSize = true;
            this.AppLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AppLabel.Location = new System.Drawing.Point(22, 20);
            this.AppLabel.Name = "AppLabel";
            this.AppLabel.Size = new System.Drawing.Size(170, 24);
            this.AppLabel.TabIndex = 0;
            this.AppLabel.Text = "TO-DO LIST APP";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(26, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 294);
            this.panel1.TabIndex = 1;
            // 
            // TaskDropdown
            // 
            this.TaskDropdown.FormattingEnabled = true;
            this.TaskDropdown.Location = new System.Drawing.Point(167, 84);
            this.TaskDropdown.Name = "TaskDropdown";
            this.TaskDropdown.Size = new System.Drawing.Size(150, 21);
            this.TaskDropdown.TabIndex = 0;
            // 
            // ResetTaskButton
            // 
            this.ResetTaskButton.Location = new System.Drawing.Point(355, 76);
            this.ResetTaskButton.Name = "ResetTaskButton";
            this.ResetTaskButton.Size = new System.Drawing.Size(143, 34);
            this.ResetTaskButton.TabIndex = 2;
            this.ResetTaskButton.Text = "Reset task count";
            this.ResetTaskButton.UseVisualStyleBackColor = true;
            // 
            // TaskCount
            // 
            this.TaskCount.AutoSize = true;
            this.TaskCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.TaskCount.Location = new System.Drawing.Point(541, 85);
            this.TaskCount.Name = "TaskCount";
            this.TaskCount.Size = new System.Drawing.Size(113, 20);
            this.TaskCount.TabIndex = 3;
            this.TaskCount.Text = "TASK COUNT:";
            // 
            // TaskChooseLabel
            // 
            this.TaskChooseLabel.AutoSize = true;
            this.TaskChooseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.TaskChooseLabel.Location = new System.Drawing.Point(22, 82);
            this.TaskChooseLabel.Name = "TaskChooseLabel";
            this.TaskChooseLabel.Size = new System.Drawing.Size(120, 20);
            this.TaskChooseLabel.TabIndex = 4;
            this.TaskChooseLabel.Text = "SELECT TASK:";
            // 
            // ToDoListApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TaskChooseLabel);
            this.Controls.Add(this.TaskCount);
            this.Controls.Add(this.ResetTaskButton);
            this.Controls.Add(this.TaskDropdown);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AppLabel);
            this.Name = "ToDoListApp";
            this.Text = "To-do List";
            this.Load += new System.EventHandler(this.ToDoListApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AppLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox TaskDropdown;
        private System.Windows.Forms.Button ResetTaskButton;
        private System.Windows.Forms.Label TaskCount;
        private System.Windows.Forms.Label TaskChooseLabel;
    }
}

