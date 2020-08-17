namespace BugTrackingSystemWithSQlite
{
    partial class FormDeleteUser
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
            this.cbUserNameForDelete = new System.Windows.Forms.ComboBox();
            this.bnDeleteUser = new System.Windows.Forms.Button();
            this.lbTitleUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbUserNameForDelete
            // 
            this.cbUserNameForDelete.FormattingEnabled = true;
            this.cbUserNameForDelete.Location = new System.Drawing.Point(22, 140);
            this.cbUserNameForDelete.Name = "cbUserNameForDelete";
            this.cbUserNameForDelete.Size = new System.Drawing.Size(416, 28);
            this.cbUserNameForDelete.TabIndex = 1;
            // 
            // bnDeleteUser
            // 
            this.bnDeleteUser.Location = new System.Drawing.Point(170, 225);
            this.bnDeleteUser.Name = "bnDeleteUser";
            this.bnDeleteUser.Size = new System.Drawing.Size(112, 35);
            this.bnDeleteUser.TabIndex = 2;
            this.bnDeleteUser.Text = "Удалить";
            this.bnDeleteUser.UseVisualStyleBackColor = true;
            this.bnDeleteUser.Click += new System.EventHandler(this.bnDeleteUser_Click);
            // 
            // lbTitleUser
            // 
            this.lbTitleUser.Location = new System.Drawing.Point(18, 75);
            this.lbTitleUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitleUser.Name = "lbTitleUser";
            this.lbTitleUser.Size = new System.Drawing.Size(420, 20);
            this.lbTitleUser.TabIndex = 3;
            this.lbTitleUser.Text = "Выберите пользователя, которого нужно удалить.";
            this.lbTitleUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormDeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 304);
            this.Controls.Add(this.lbTitleUser);
            this.Controls.Add(this.bnDeleteUser);
            this.Controls.Add(this.cbUserNameForDelete);
            this.Name = "FormDeleteUser";
            this.Text = "Удаление пользователя";
            this.Load += new System.EventHandler(this.FormDeleteUser_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbUserNameForDelete;
        private System.Windows.Forms.Button bnDeleteUser;
        private System.Windows.Forms.Label lbTitleUser;
    }
}