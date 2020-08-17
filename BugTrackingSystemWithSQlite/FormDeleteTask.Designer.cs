namespace BugTrackingSystemWithSQlite
{
    partial class FormDeleteTask
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
            this.bnDeleteTask = new System.Windows.Forms.Button();
            this.cbTaskNameForDelete = new System.Windows.Forms.ComboBox();
            this.lbTitleTask = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bnDeleteTask
            // 
            this.bnDeleteTask.Location = new System.Drawing.Point(113, 136);
            this.bnDeleteTask.Name = "bnDeleteTask";
            this.bnDeleteTask.Size = new System.Drawing.Size(75, 23);
            this.bnDeleteTask.TabIndex = 5;
            this.bnDeleteTask.Text = "Удалить";
            this.bnDeleteTask.UseVisualStyleBackColor = true;
            this.bnDeleteTask.Click += new System.EventHandler(this.bnDeleteTask_Click);
            // 
            // cbTaskNameForDelete
            // 
            this.cbTaskNameForDelete.FormattingEnabled = true;
            this.cbTaskNameForDelete.Location = new System.Drawing.Point(15, 81);
            this.cbTaskNameForDelete.Name = "cbTaskNameForDelete";
            this.cbTaskNameForDelete.Size = new System.Drawing.Size(277, 21);
            this.cbTaskNameForDelete.TabIndex = 4;
            // 
            // lbTitleTask
            // 
            this.lbTitleTask.Location = new System.Drawing.Point(12, 39);
            this.lbTitleTask.Name = "lbTitleTask";
            this.lbTitleTask.Size = new System.Drawing.Size(280, 13);
            this.lbTitleTask.TabIndex = 3;
            this.lbTitleTask.Text = "Выберите задачу, которую нужно удалить.";
            this.lbTitleTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormDeleteTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 198);
            this.Controls.Add(this.bnDeleteTask);
            this.Controls.Add(this.cbTaskNameForDelete);
            this.Controls.Add(this.lbTitleTask);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormDeleteTask";
            this.Text = "Удаление задачи";
            this.Load += new System.EventHandler(this.FormDeleteTask_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bnDeleteTask;
        private System.Windows.Forms.ComboBox cbTaskNameForDelete;
        private System.Windows.Forms.Label lbTitleTask;
    }
}