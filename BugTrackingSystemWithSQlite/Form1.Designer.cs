namespace BugTrackingSystemWithSQlite
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvViewer = new System.Windows.Forms.DataGridView();
            this.bnAddNameProject = new System.Windows.Forms.Button();
            this.tbProjectName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolSpFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSpFileCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSpFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.gbProjects = new System.Windows.Forms.GroupBox();
            this.cbProjectName = new System.Windows.Forms.ComboBox();
            this.bnDeleteProject = new System.Windows.Forms.Button();
            this.lbProjectName = new System.Windows.Forms.Label();
            this.gbUsers = new System.Windows.Forms.GroupBox();
            this.cbUserName = new System.Windows.Forms.ComboBox();
            this.bnDeleteUser = new System.Windows.Forms.Button();
            this.lbUserName = new System.Windows.Forms.Label();
            this.bnAddNameUser = new System.Windows.Forms.Button();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.gbTasks = new System.Windows.Forms.GroupBox();
            this.bnDeleteTask = new System.Windows.Forms.Button();
            this.cbTaskName = new System.Windows.Forms.ComboBox();
            this.tbDescriptionName = new System.Windows.Forms.TextBox();
            this.lbDescriptionName = new System.Windows.Forms.Label();
            this.cbUserNameForTask = new System.Windows.Forms.ComboBox();
            this.lbUserNameForTask = new System.Windows.Forms.Label();
            this.tbPriorityName = new System.Windows.Forms.TextBox();
            this.lbPriorityName = new System.Windows.Forms.Label();
            this.tbTypeName = new System.Windows.Forms.TextBox();
            this.lbTypeName = new System.Windows.Forms.Label();
            this.tbThemeName = new System.Windows.Forms.TextBox();
            this.lbThemeName = new System.Windows.Forms.Label();
            this.cbProjectNameForTask = new System.Windows.Forms.ComboBox();
            this.lbProjectNameForTask = new System.Windows.Forms.Label();
            this.tbTaskName = new System.Windows.Forms.TextBox();
            this.lbTaskName = new System.Windows.Forms.Label();
            this.bnAddTask = new System.Windows.Forms.Button();
            this.bnShowProjects = new System.Windows.Forms.Button();
            this.bnShowUsers = new System.Windows.Forms.Button();
            this.bnShowTasksInProject = new System.Windows.Forms.Button();
            this.bnShowTasksOnUser = new System.Windows.Forms.Button();
            this.cbTasksInProject = new System.Windows.Forms.ComboBox();
            this.cbTasksOnUser = new System.Windows.Forms.ComboBox();
            this.lbProjectInTask = new System.Windows.Forms.Label();
            this.lbUserOnTask = new System.Windows.Forms.Label();
            this.bnShowLogs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewer)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gbProjects.SuspendLayout();
            this.gbUsers.SuspendLayout();
            this.gbTasks.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvViewer
            // 
            this.dgvViewer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvViewer.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewer.Location = new System.Drawing.Point(12, 444);
            this.dgvViewer.Name = "dgvViewer";
            this.dgvViewer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvViewer.Size = new System.Drawing.Size(924, 234);
            this.dgvViewer.TabIndex = 4;
            // 
            // bnAddNameProject
            // 
            this.bnAddNameProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bnAddNameProject.Location = new System.Drawing.Point(6, 113);
            this.bnAddNameProject.Name = "bnAddNameProject";
            this.bnAddNameProject.Size = new System.Drawing.Size(85, 35);
            this.bnAddNameProject.TabIndex = 6;
            this.bnAddNameProject.Text = "Добавить проект";
            this.bnAddNameProject.UseVisualStyleBackColor = true;
            this.bnAddNameProject.Click += new System.EventHandler(this.bnAddNameProject_Click);
            // 
            // tbProjectName
            // 
            this.tbProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbProjectName.Location = new System.Drawing.Point(6, 76);
            this.tbProjectName.Name = "tbProjectName";
            this.tbProjectName.Size = new System.Drawing.Size(188, 20);
            this.tbProjectName.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSpFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(948, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolSpFile
            // 
            this.toolSpFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSpFileCreate,
            this.toolSpFileOpen});
            this.toolSpFile.Name = "toolSpFile";
            this.toolSpFile.Size = new System.Drawing.Size(48, 22);
            this.toolSpFile.Text = "Файл";
            // 
            // toolSpFileCreate
            // 
            this.toolSpFileCreate.Name = "toolSpFileCreate";
            this.toolSpFileCreate.Size = new System.Drawing.Size(121, 22);
            this.toolSpFileCreate.Text = "Создать";
            this.toolSpFileCreate.Click += new System.EventHandler(this.toolSpFileCreate_Click);
            // 
            // toolSpFileOpen
            // 
            this.toolSpFileOpen.Name = "toolSpFileOpen";
            this.toolSpFileOpen.Size = new System.Drawing.Size(121, 22);
            this.toolSpFileOpen.Text = "Открыть";
            this.toolSpFileOpen.Click += new System.EventHandler(this.toolSpFileOpen_Click);
            // 
            // gbProjects
            // 
            this.gbProjects.Controls.Add(this.cbProjectName);
            this.gbProjects.Controls.Add(this.bnDeleteProject);
            this.gbProjects.Controls.Add(this.lbProjectName);
            this.gbProjects.Controls.Add(this.bnAddNameProject);
            this.gbProjects.Controls.Add(this.tbProjectName);
            this.gbProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbProjects.Location = new System.Drawing.Point(12, 45);
            this.gbProjects.Name = "gbProjects";
            this.gbProjects.Size = new System.Drawing.Size(200, 372);
            this.gbProjects.TabIndex = 11;
            this.gbProjects.TabStop = false;
            this.gbProjects.Text = "ПРОЕКТЫ";
            // 
            // cbProjectName
            // 
            this.cbProjectName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbProjectName.FormattingEnabled = true;
            this.cbProjectName.Location = new System.Drawing.Point(6, 176);
            this.cbProjectName.Name = "cbProjectName";
            this.cbProjectName.Size = new System.Drawing.Size(188, 21);
            this.cbProjectName.TabIndex = 10;
            this.cbProjectName.DropDown += new System.EventHandler(this.cbProjectName_DropDown);
            // 
            // bnDeleteProject
            // 
            this.bnDeleteProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bnDeleteProject.Location = new System.Drawing.Point(6, 216);
            this.bnDeleteProject.Name = "bnDeleteProject";
            this.bnDeleteProject.Size = new System.Drawing.Size(85, 35);
            this.bnDeleteProject.TabIndex = 9;
            this.bnDeleteProject.Text = "Удалить проект";
            this.bnDeleteProject.UseVisualStyleBackColor = true;
            this.bnDeleteProject.Click += new System.EventHandler(this.bnDeleteProject_Click);
            // 
            // lbProjectName
            // 
            this.lbProjectName.AutoSize = true;
            this.lbProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbProjectName.Location = new System.Drawing.Point(7, 45);
            this.lbProjectName.Name = "lbProjectName";
            this.lbProjectName.Size = new System.Drawing.Size(101, 13);
            this.lbProjectName.TabIndex = 8;
            this.lbProjectName.Text = "Название проекта";
            // 
            // gbUsers
            // 
            this.gbUsers.Controls.Add(this.cbUserName);
            this.gbUsers.Controls.Add(this.bnDeleteUser);
            this.gbUsers.Controls.Add(this.lbUserName);
            this.gbUsers.Controls.Add(this.bnAddNameUser);
            this.gbUsers.Controls.Add(this.tbUserName);
            this.gbUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbUsers.Location = new System.Drawing.Point(218, 45);
            this.gbUsers.Name = "gbUsers";
            this.gbUsers.Size = new System.Drawing.Size(200, 372);
            this.gbUsers.TabIndex = 12;
            this.gbUsers.TabStop = false;
            this.gbUsers.Text = "ПОЛЬЗОВАТЕЛИ";
            // 
            // cbUserName
            // 
            this.cbUserName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbUserName.FormattingEnabled = true;
            this.cbUserName.Location = new System.Drawing.Point(6, 176);
            this.cbUserName.Name = "cbUserName";
            this.cbUserName.Size = new System.Drawing.Size(188, 21);
            this.cbUserName.TabIndex = 11;
            this.cbUserName.DropDown += new System.EventHandler(this.cbUserName_DropDown);
            // 
            // bnDeleteUser
            // 
            this.bnDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bnDeleteUser.Location = new System.Drawing.Point(6, 216);
            this.bnDeleteUser.Name = "bnDeleteUser";
            this.bnDeleteUser.Size = new System.Drawing.Size(93, 35);
            this.bnDeleteUser.TabIndex = 12;
            this.bnDeleteUser.Text = "Удалить пользователя";
            this.bnDeleteUser.UseVisualStyleBackColor = true;
            this.bnDeleteUser.Click += new System.EventHandler(this.bnDeleteUser_Click);
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUserName.Location = new System.Drawing.Point(7, 45);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(103, 13);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "Имя пользователя";
            // 
            // bnAddNameUser
            // 
            this.bnAddNameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bnAddNameUser.Location = new System.Drawing.Point(3, 117);
            this.bnAddNameUser.Name = "bnAddNameUser";
            this.bnAddNameUser.Size = new System.Drawing.Size(95, 35);
            this.bnAddNameUser.TabIndex = 10;
            this.bnAddNameUser.Text = "Добавить пользователя";
            this.bnAddNameUser.UseVisualStyleBackColor = true;
            this.bnAddNameUser.Click += new System.EventHandler(this.bnAddNameUser_Click);
            // 
            // tbUserName
            // 
            this.tbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUserName.Location = new System.Drawing.Point(6, 76);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(188, 20);
            this.tbUserName.TabIndex = 11;
            // 
            // gbTasks
            // 
            this.gbTasks.Controls.Add(this.bnDeleteTask);
            this.gbTasks.Controls.Add(this.cbTaskName);
            this.gbTasks.Controls.Add(this.tbDescriptionName);
            this.gbTasks.Controls.Add(this.lbDescriptionName);
            this.gbTasks.Controls.Add(this.cbUserNameForTask);
            this.gbTasks.Controls.Add(this.lbUserNameForTask);
            this.gbTasks.Controls.Add(this.tbPriorityName);
            this.gbTasks.Controls.Add(this.lbPriorityName);
            this.gbTasks.Controls.Add(this.tbTypeName);
            this.gbTasks.Controls.Add(this.lbTypeName);
            this.gbTasks.Controls.Add(this.tbThemeName);
            this.gbTasks.Controls.Add(this.lbThemeName);
            this.gbTasks.Controls.Add(this.cbProjectNameForTask);
            this.gbTasks.Controls.Add(this.lbProjectNameForTask);
            this.gbTasks.Controls.Add(this.tbTaskName);
            this.gbTasks.Controls.Add(this.lbTaskName);
            this.gbTasks.Controls.Add(this.bnAddTask);
            this.gbTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbTasks.Location = new System.Drawing.Point(424, 45);
            this.gbTasks.Name = "gbTasks";
            this.gbTasks.Size = new System.Drawing.Size(349, 372);
            this.gbTasks.TabIndex = 13;
            this.gbTasks.TabStop = false;
            this.gbTasks.Text = "ЗАДАЧИ";
            // 
            // bnDeleteTask
            // 
            this.bnDeleteTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bnDeleteTask.Location = new System.Drawing.Point(190, 331);
            this.bnDeleteTask.Name = "bnDeleteTask";
            this.bnDeleteTask.Size = new System.Drawing.Size(153, 35);
            this.bnDeleteTask.TabIndex = 13;
            this.bnDeleteTask.Text = "Удалить задачу";
            this.bnDeleteTask.UseVisualStyleBackColor = true;
            this.bnDeleteTask.Click += new System.EventHandler(this.bnDeleteTask_Click);
            // 
            // cbTaskName
            // 
            this.cbTaskName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbTaskName.FormattingEnabled = true;
            this.cbTaskName.Location = new System.Drawing.Point(190, 298);
            this.cbTaskName.Name = "cbTaskName";
            this.cbTaskName.Size = new System.Drawing.Size(153, 21);
            this.cbTaskName.TabIndex = 25;
            this.cbTaskName.DropDown += new System.EventHandler(this.cbTaskName_DropDown);
            // 
            // tbDescriptionName
            // 
            this.tbDescriptionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDescriptionName.Location = new System.Drawing.Point(4, 298);
            this.tbDescriptionName.Name = "tbDescriptionName";
            this.tbDescriptionName.Size = new System.Drawing.Size(160, 20);
            this.tbDescriptionName.TabIndex = 24;
            // 
            // lbDescriptionName
            // 
            this.lbDescriptionName.AutoSize = true;
            this.lbDescriptionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDescriptionName.Location = new System.Drawing.Point(1, 280);
            this.lbDescriptionName.Name = "lbDescriptionName";
            this.lbDescriptionName.Size = new System.Drawing.Size(60, 13);
            this.lbDescriptionName.TabIndex = 23;
            this.lbDescriptionName.Text = "Описание:";
            // 
            // cbUserNameForTask
            // 
            this.cbUserNameForTask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserNameForTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbUserNameForTask.FormattingEnabled = true;
            this.cbUserNameForTask.Location = new System.Drawing.Point(4, 254);
            this.cbUserNameForTask.Name = "cbUserNameForTask";
            this.cbUserNameForTask.Size = new System.Drawing.Size(160, 21);
            this.cbUserNameForTask.TabIndex = 22;
            this.cbUserNameForTask.DropDown += new System.EventHandler(this.cbUserNameForTask_DropDown);
            // 
            // lbUserNameForTask
            // 
            this.lbUserNameForTask.AutoSize = true;
            this.lbUserNameForTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUserNameForTask.Location = new System.Drawing.Point(1, 236);
            this.lbUserNameForTask.Name = "lbUserNameForTask";
            this.lbUserNameForTask.Size = new System.Drawing.Size(83, 13);
            this.lbUserNameForTask.TabIndex = 21;
            this.lbUserNameForTask.Text = "Пользователи:";
            // 
            // tbPriorityName
            // 
            this.tbPriorityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPriorityName.Location = new System.Drawing.Point(4, 212);
            this.tbPriorityName.Name = "tbPriorityName";
            this.tbPriorityName.Size = new System.Drawing.Size(160, 20);
            this.tbPriorityName.TabIndex = 20;
            // 
            // lbPriorityName
            // 
            this.lbPriorityName.AutoSize = true;
            this.lbPriorityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPriorityName.Location = new System.Drawing.Point(1, 194);
            this.lbPriorityName.Name = "lbPriorityName";
            this.lbPriorityName.Size = new System.Drawing.Size(64, 13);
            this.lbPriorityName.TabIndex = 19;
            this.lbPriorityName.Text = "Приоритет:";
            // 
            // tbTypeName
            // 
            this.tbTypeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTypeName.Location = new System.Drawing.Point(4, 170);
            this.tbTypeName.Name = "tbTypeName";
            this.tbTypeName.Size = new System.Drawing.Size(160, 20);
            this.tbTypeName.TabIndex = 18;
            // 
            // lbTypeName
            // 
            this.lbTypeName.AutoSize = true;
            this.lbTypeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTypeName.Location = new System.Drawing.Point(1, 151);
            this.lbTypeName.Name = "lbTypeName";
            this.lbTypeName.Size = new System.Drawing.Size(29, 13);
            this.lbTypeName.TabIndex = 17;
            this.lbTypeName.Text = "Тип:";
            // 
            // tbThemeName
            // 
            this.tbThemeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbThemeName.Location = new System.Drawing.Point(4, 127);
            this.tbThemeName.Name = "tbThemeName";
            this.tbThemeName.Size = new System.Drawing.Size(160, 20);
            this.tbThemeName.TabIndex = 16;
            // 
            // lbThemeName
            // 
            this.lbThemeName.AutoSize = true;
            this.lbThemeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbThemeName.Location = new System.Drawing.Point(1, 109);
            this.lbThemeName.Name = "lbThemeName";
            this.lbThemeName.Size = new System.Drawing.Size(37, 13);
            this.lbThemeName.TabIndex = 15;
            this.lbThemeName.Text = "Тема:";
            // 
            // cbProjectNameForTask
            // 
            this.cbProjectNameForTask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProjectNameForTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbProjectNameForTask.FormattingEnabled = true;
            this.cbProjectNameForTask.Location = new System.Drawing.Point(4, 83);
            this.cbProjectNameForTask.Name = "cbProjectNameForTask";
            this.cbProjectNameForTask.Size = new System.Drawing.Size(160, 21);
            this.cbProjectNameForTask.TabIndex = 14;
            this.cbProjectNameForTask.DropDown += new System.EventHandler(this.cbProjectNameForTask_DropDown);
            // 
            // lbProjectNameForTask
            // 
            this.lbProjectNameForTask.AutoSize = true;
            this.lbProjectNameForTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbProjectNameForTask.Location = new System.Drawing.Point(1, 64);
            this.lbProjectNameForTask.Name = "lbProjectNameForTask";
            this.lbProjectNameForTask.Size = new System.Drawing.Size(47, 13);
            this.lbProjectNameForTask.TabIndex = 13;
            this.lbProjectNameForTask.Text = "Проект:";
            // 
            // tbTaskName
            // 
            this.tbTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTaskName.Location = new System.Drawing.Point(4, 40);
            this.tbTaskName.Name = "tbTaskName";
            this.tbTaskName.Size = new System.Drawing.Size(160, 20);
            this.tbTaskName.TabIndex = 12;
            // 
            // lbTaskName
            // 
            this.lbTaskName.AutoSize = true;
            this.lbTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTaskName.Location = new System.Drawing.Point(1, 21);
            this.lbTaskName.Name = "lbTaskName";
            this.lbTaskName.Size = new System.Drawing.Size(98, 13);
            this.lbTaskName.TabIndex = 11;
            this.lbTaskName.Text = "Название задачи:";
            // 
            // bnAddTask
            // 
            this.bnAddTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bnAddTask.Location = new System.Drawing.Point(6, 331);
            this.bnAddTask.Name = "bnAddTask";
            this.bnAddTask.Size = new System.Drawing.Size(158, 35);
            this.bnAddTask.TabIndex = 10;
            this.bnAddTask.Text = "Добавить задачу";
            this.bnAddTask.UseVisualStyleBackColor = true;
            this.bnAddTask.Click += new System.EventHandler(this.bnAddTask_Click);
            // 
            // bnShowProjects
            // 
            this.bnShowProjects.Location = new System.Drawing.Point(782, 137);
            this.bnShowProjects.Margin = new System.Windows.Forms.Padding(2);
            this.bnShowProjects.Name = "bnShowProjects";
            this.bnShowProjects.Size = new System.Drawing.Size(154, 42);
            this.bnShowProjects.TabIndex = 14;
            this.bnShowProjects.Text = "Показать список проектов";
            this.bnShowProjects.UseVisualStyleBackColor = true;
            this.bnShowProjects.Click += new System.EventHandler(this.bnShowProjects_Click);
            // 
            // bnShowUsers
            // 
            this.bnShowUsers.Location = new System.Drawing.Point(782, 183);
            this.bnShowUsers.Margin = new System.Windows.Forms.Padding(2);
            this.bnShowUsers.Name = "bnShowUsers";
            this.bnShowUsers.Size = new System.Drawing.Size(154, 42);
            this.bnShowUsers.TabIndex = 15;
            this.bnShowUsers.Text = "Показать список пользователей";
            this.bnShowUsers.UseVisualStyleBackColor = true;
            this.bnShowUsers.Click += new System.EventHandler(this.bnShowUsers_Click);
            // 
            // bnShowTasksInProject
            // 
            this.bnShowTasksInProject.Location = new System.Drawing.Point(782, 367);
            this.bnShowTasksInProject.Margin = new System.Windows.Forms.Padding(2);
            this.bnShowTasksInProject.Name = "bnShowTasksInProject";
            this.bnShowTasksInProject.Size = new System.Drawing.Size(154, 42);
            this.bnShowTasksInProject.TabIndex = 16;
            this.bnShowTasksInProject.Text = "Показать список задач в проекте";
            this.bnShowTasksInProject.UseVisualStyleBackColor = true;
            this.bnShowTasksInProject.Click += new System.EventHandler(this.bnShowTasksInProject_Click);
            // 
            // bnShowTasksOnUser
            // 
            this.bnShowTasksOnUser.Location = new System.Drawing.Point(782, 276);
            this.bnShowTasksOnUser.Margin = new System.Windows.Forms.Padding(2);
            this.bnShowTasksOnUser.Name = "bnShowTasksOnUser";
            this.bnShowTasksOnUser.Size = new System.Drawing.Size(154, 42);
            this.bnShowTasksOnUser.TabIndex = 17;
            this.bnShowTasksOnUser.Text = "Показать список задач на исполнителе";
            this.bnShowTasksOnUser.UseVisualStyleBackColor = true;
            this.bnShowTasksOnUser.Click += new System.EventHandler(this.bnShowTasksOnUser_Click);
            // 
            // cbTasksInProject
            // 
            this.cbTasksInProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTasksInProject.FormattingEnabled = true;
            this.cbTasksInProject.Location = new System.Drawing.Point(782, 341);
            this.cbTasksInProject.Name = "cbTasksInProject";
            this.cbTasksInProject.Size = new System.Drawing.Size(154, 21);
            this.cbTasksInProject.TabIndex = 18;
            this.cbTasksInProject.DropDown += new System.EventHandler(this.cbTasksInProject_DropDown);
            // 
            // cbTasksOnUser
            // 
            this.cbTasksOnUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTasksOnUser.FormattingEnabled = true;
            this.cbTasksOnUser.Location = new System.Drawing.Point(782, 250);
            this.cbTasksOnUser.Name = "cbTasksOnUser";
            this.cbTasksOnUser.Size = new System.Drawing.Size(154, 21);
            this.cbTasksOnUser.TabIndex = 19;
            this.cbTasksOnUser.DropDown += new System.EventHandler(this.cbTasksOnUser_DropDown);
            // 
            // lbProjectInTask
            // 
            this.lbProjectInTask.AutoSize = true;
            this.lbProjectInTask.Location = new System.Drawing.Point(779, 320);
            this.lbProjectInTask.Name = "lbProjectInTask";
            this.lbProjectInTask.Size = new System.Drawing.Size(104, 13);
            this.lbProjectInTask.TabIndex = 20;
            this.lbProjectInTask.Text = "Название проекта:";
            // 
            // lbUserOnTask
            // 
            this.lbUserOnTask.AutoSize = true;
            this.lbUserOnTask.Location = new System.Drawing.Point(779, 229);
            this.lbUserOnTask.Name = "lbUserOnTask";
            this.lbUserOnTask.Size = new System.Drawing.Size(100, 13);
            this.lbUserOnTask.TabIndex = 21;
            this.lbUserOnTask.Text = "Имя исполнителя:";
            // 
            // bnShowLogs
            // 
            this.bnShowLogs.Location = new System.Drawing.Point(782, 45);
            this.bnShowLogs.Name = "bnShowLogs";
            this.bnShowLogs.Size = new System.Drawing.Size(154, 42);
            this.bnShowLogs.TabIndex = 22;
            this.bnShowLogs.Text = "Показать историю";
            this.bnShowLogs.UseVisualStyleBackColor = true;
            this.bnShowLogs.Click += new System.EventHandler(this.bnShowLogs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 690);
            this.Controls.Add(this.bnShowLogs);
            this.Controls.Add(this.lbUserOnTask);
            this.Controls.Add(this.lbProjectInTask);
            this.Controls.Add(this.cbTasksOnUser);
            this.Controls.Add(this.cbTasksInProject);
            this.Controls.Add(this.bnShowTasksOnUser);
            this.Controls.Add(this.bnShowTasksInProject);
            this.Controls.Add(this.bnShowUsers);
            this.Controls.Add(this.bnShowProjects);
            this.Controls.Add(this.gbTasks);
            this.Controls.Add(this.gbUsers);
            this.Controls.Add(this.gbProjects);
            this.Controls.Add(this.dgvViewer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Система отслеживания задач/ошибок";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewer)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbProjects.ResumeLayout(false);
            this.gbProjects.PerformLayout();
            this.gbUsers.ResumeLayout(false);
            this.gbUsers.PerformLayout();
            this.gbTasks.ResumeLayout(false);
            this.gbTasks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvViewer;
        private System.Windows.Forms.Button bnAddNameProject;
        private System.Windows.Forms.TextBox tbProjectName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolSpFile;
        private System.Windows.Forms.ToolStripMenuItem toolSpFileCreate;
        private System.Windows.Forms.ToolStripMenuItem toolSpFileOpen;
        private System.Windows.Forms.GroupBox gbProjects;
        private System.Windows.Forms.Button bnDeleteProject;
        private System.Windows.Forms.Label lbProjectName;
        private System.Windows.Forms.GroupBox gbUsers;
        private System.Windows.Forms.GroupBox gbTasks;
        private System.Windows.Forms.Button bnDeleteUser;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Button bnAddNameUser;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Button bnShowProjects;
        private System.Windows.Forms.Button bnShowUsers;
        private System.Windows.Forms.Button bnShowTasksInProject;
        private System.Windows.Forms.Button bnShowTasksOnUser;
        private System.Windows.Forms.Button bnDeleteTask;
        private System.Windows.Forms.Button bnAddTask;
        private System.Windows.Forms.ComboBox cbTasksInProject;
        private System.Windows.Forms.ComboBox cbTasksOnUser;
        private System.Windows.Forms.Label lbProjectInTask;
        private System.Windows.Forms.Label lbUserOnTask;
        private System.Windows.Forms.Button bnShowLogs;
        private System.Windows.Forms.ComboBox cbProjectName;
        private System.Windows.Forms.ComboBox cbUserName;
        private System.Windows.Forms.ComboBox cbProjectNameForTask;
        private System.Windows.Forms.Label lbProjectNameForTask;
        private System.Windows.Forms.TextBox tbTaskName;
        private System.Windows.Forms.Label lbTaskName;
        private System.Windows.Forms.ComboBox cbTaskName;
        private System.Windows.Forms.TextBox tbDescriptionName;
        private System.Windows.Forms.Label lbDescriptionName;
        private System.Windows.Forms.ComboBox cbUserNameForTask;
        private System.Windows.Forms.Label lbUserNameForTask;
        private System.Windows.Forms.TextBox tbPriorityName;
        private System.Windows.Forms.Label lbPriorityName;
        private System.Windows.Forms.TextBox tbTypeName;
        private System.Windows.Forms.Label lbTypeName;
        private System.Windows.Forms.TextBox tbThemeName;
        private System.Windows.Forms.Label lbThemeName;
    }
}

