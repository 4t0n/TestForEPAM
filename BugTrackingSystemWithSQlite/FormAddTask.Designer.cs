namespace BugTrackingSystemWithSQlite
{
    partial class FormAddTask
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbPriority = new System.Windows.Forms.TextBox();
            this.tbType = new System.Windows.Forms.TextBox();
            this.tbTheme = new System.Windows.Forms.TextBox();
            this.lbTaskName = new System.Windows.Forms.Label();
            this.tbTaskName = new System.Windows.Forms.TextBox();
            this.cbProjectName = new System.Windows.Forms.ComboBox();
            this.cbUserName = new System.Windows.Forms.ComboBox();
            this.bnAddTask = new System.Windows.Forms.Button();
            this.lbProjectName = new System.Windows.Forms.Label();
            this.lbTheme = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.lbPriority = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.43321F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.56679F));
            this.tableLayoutPanel1.Controls.Add(this.lbDescription, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tbPriority, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbType, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbTheme, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbTaskName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbTaskName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbProjectName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbUserName, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbDescription, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbProjectName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbTheme, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbType, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbPriority, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbUserName, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(34, 18);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(277, 324);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tbPriority
            // 
            this.tbPriority.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbPriority.Location = new System.Drawing.Point(113, 148);
            this.tbPriority.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPriority.Name = "tbPriority";
            this.tbPriority.Size = new System.Drawing.Size(162, 20);
            this.tbPriority.TabIndex = 11;
            // 
            // tbType
            // 
            this.tbType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbType.Location = new System.Drawing.Point(113, 113);
            this.tbType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(162, 20);
            this.tbType.TabIndex = 10;
            // 
            // tbTheme
            // 
            this.tbTheme.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbTheme.Location = new System.Drawing.Point(113, 78);
            this.tbTheme.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTheme.Name = "tbTheme";
            this.tbTheme.Size = new System.Drawing.Size(162, 20);
            this.tbTheme.TabIndex = 9;
            // 
            // lbTaskName
            // 
            this.lbTaskName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTaskName.AutoSize = true;
            this.lbTaskName.Location = new System.Drawing.Point(2, 11);
            this.lbTaskName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTaskName.Name = "lbTaskName";
            this.lbTaskName.Size = new System.Drawing.Size(98, 13);
            this.lbTaskName.TabIndex = 0;
            this.lbTaskName.Text = "Название задачи:";
            // 
            // tbTaskName
            // 
            this.tbTaskName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbTaskName.Location = new System.Drawing.Point(113, 8);
            this.tbTaskName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTaskName.Name = "tbTaskName";
            this.tbTaskName.Size = new System.Drawing.Size(162, 20);
            this.tbTaskName.TabIndex = 7;
            // 
            // cbProjectName
            // 
            this.cbProjectName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbProjectName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProjectName.FormattingEnabled = true;
            this.cbProjectName.Location = new System.Drawing.Point(113, 43);
            this.cbProjectName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbProjectName.Name = "cbProjectName";
            this.cbProjectName.Size = new System.Drawing.Size(162, 21);
            this.cbProjectName.TabIndex = 8;
            // 
            // cbUserName
            // 
            this.cbUserName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbUserName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserName.FormattingEnabled = true;
            this.cbUserName.Location = new System.Drawing.Point(113, 183);
            this.cbUserName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbUserName.Name = "cbUserName";
            this.cbUserName.Size = new System.Drawing.Size(162, 21);
            this.cbUserName.TabIndex = 12;
            // 
            // bnAddTask
            // 
            this.bnAddTask.Location = new System.Drawing.Point(125, 363);
            this.bnAddTask.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bnAddTask.Name = "bnAddTask";
            this.bnAddTask.Size = new System.Drawing.Size(93, 30);
            this.bnAddTask.TabIndex = 1;
            this.bnAddTask.Text = "Добавить";
            this.bnAddTask.UseVisualStyleBackColor = true;
            this.bnAddTask.Click += new System.EventHandler(this.bnAddTask_Click);
            // 
            // lbProjectName
            // 
            this.lbProjectName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbProjectName.AutoSize = true;
            this.lbProjectName.Location = new System.Drawing.Point(2, 47);
            this.lbProjectName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbProjectName.Name = "lbProjectName";
            this.lbProjectName.Size = new System.Drawing.Size(47, 13);
            this.lbProjectName.TabIndex = 14;
            this.lbProjectName.Text = "Проект:";
            // 
            // lbTheme
            // 
            this.lbTheme.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTheme.AutoSize = true;
            this.lbTheme.Location = new System.Drawing.Point(2, 82);
            this.lbTheme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTheme.Name = "lbTheme";
            this.lbTheme.Size = new System.Drawing.Size(37, 13);
            this.lbTheme.TabIndex = 15;
            this.lbTheme.Text = "Тема:";
            // 
            // lbType
            // 
            this.lbType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(2, 117);
            this.lbType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(29, 13);
            this.lbType.TabIndex = 16;
            this.lbType.Text = "Тип:";
            // 
            // lbPriority
            // 
            this.lbPriority.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbPriority.AutoSize = true;
            this.lbPriority.Location = new System.Drawing.Point(2, 152);
            this.lbPriority.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPriority.Name = "lbPriority";
            this.lbPriority.Size = new System.Drawing.Size(64, 13);
            this.lbPriority.TabIndex = 17;
            this.lbPriority.Text = "Приоритет:";
            // 
            // lbUserName
            // 
            this.lbUserName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(2, 187);
            this.lbUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(77, 13);
            this.lbUserName.TabIndex = 18;
            this.lbUserName.Text = "Исполнитель:";
            // 
            // lbDescription
            // 
            this.lbDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(2, 261);
            this.lbDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(60, 13);
            this.lbDescription.TabIndex = 19;
            this.lbDescription.Text = "Описание:";
            // 
            // tbDescription
            // 
            this.tbDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbDescription.Location = new System.Drawing.Point(113, 222);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(2);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(162, 90);
            this.tbDescription.TabIndex = 13;
            // 
            // FormAddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 416);
            this.Controls.Add(this.bnAddTask);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAddTask";
            this.Text = "Добавить задачу";
            this.Load += new System.EventHandler(this.FormAddTask_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbPriority;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.TextBox tbTheme;
        private System.Windows.Forms.Label lbTaskName;
        private System.Windows.Forms.TextBox tbTaskName;
        private System.Windows.Forms.ComboBox cbProjectName;
        private System.Windows.Forms.ComboBox cbUserName;
        private System.Windows.Forms.Button bnAddTask;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lbProjectName;
        private System.Windows.Forms.Label lbTheme;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbPriority;
        private System.Windows.Forms.Label lbUserName;
    }
}