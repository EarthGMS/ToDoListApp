
namespace ToDoListApp
{
    partial class NewTask
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
            this.NewTaskText = new System.Windows.Forms.Label();
            this.TaskName = new System.Windows.Forms.Label();
            this.TaskDesc = new System.Windows.Forms.Label();
            this.TaskNameInput = new System.Windows.Forms.TextBox();
            this.TaskDescInput = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewTaskText
            // 
            this.NewTaskText.AutoSize = true;
            this.NewTaskText.Font = new System.Drawing.Font("Candara", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewTaskText.Location = new System.Drawing.Point(276, 25);
            this.NewTaskText.Name = "NewTaskText";
            this.NewTaskText.Size = new System.Drawing.Size(243, 59);
            this.NewTaskText.TabIndex = 0;
            this.NewTaskText.Text = "NEW TASK";
            // 
            // TaskName
            // 
            this.TaskName.AutoSize = true;
            this.TaskName.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskName.Location = new System.Drawing.Point(22, 103);
            this.TaskName.Name = "TaskName";
            this.TaskName.Size = new System.Drawing.Size(104, 23);
            this.TaskName.TabIndex = 1;
            this.TaskName.Text = "Task name :";
            // 
            // TaskDesc
            // 
            this.TaskDesc.AutoSize = true;
            this.TaskDesc.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskDesc.Location = new System.Drawing.Point(22, 151);
            this.TaskDesc.Name = "TaskDesc";
            this.TaskDesc.Size = new System.Drawing.Size(151, 23);
            this.TaskDesc.TabIndex = 2;
            this.TaskDesc.Text = "Task description :";
            // 
            // TaskNameInput
            // 
            this.TaskNameInput.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskNameInput.Location = new System.Drawing.Point(197, 100);
            this.TaskNameInput.Name = "TaskNameInput";
            this.TaskNameInput.Size = new System.Drawing.Size(542, 31);
            this.TaskNameInput.TabIndex = 3;
            // 
            // TaskDescInput
            // 
            this.TaskDescInput.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskDescInput.Location = new System.Drawing.Point(197, 148);
            this.TaskDescInput.Multiline = true;
            this.TaskDescInput.Name = "TaskDescInput";
            this.TaskDescInput.Size = new System.Drawing.Size(542, 229);
            this.TaskDescInput.TabIndex = 4;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SaveButton.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(170, 394);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(135, 44);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "SAVE";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CancelButton.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(499, 394);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(135, 44);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "CANCEL";
            this.CancelButton.UseVisualStyleBackColor = false;
            // 
            // NewTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.TaskDescInput);
            this.Controls.Add(this.TaskNameInput);
            this.Controls.Add(this.TaskDesc);
            this.Controls.Add(this.TaskName);
            this.Controls.Add(this.NewTaskText);
            this.Name = "NewTask";
            this.Text = "NewTask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NewTaskText;
        private System.Windows.Forms.Label TaskName;
        private System.Windows.Forms.Label TaskDesc;
        private System.Windows.Forms.TextBox TaskNameInput;
        private System.Windows.Forms.TextBox TaskDescInput;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
    }
}