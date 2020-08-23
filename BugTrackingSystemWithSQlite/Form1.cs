using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Diagnostics;

namespace BugTrackingSystemWithSQlite
{
    public partial class Form1 : Form
    {
        public string dbFileName = DataBase.dbFileName;
        public SQLiteConnection dbConnect;
        public SQLiteCommand dbCommand;
        //Project project;
        //User user;
        //Task task;        
        Table project;
        Table user;
        Table task;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbConnect = new SQLiteConnection();
            dbCommand = new SQLiteCommand();            
            project = new Table("ProjectList", "Project");
            user = new Table("UserList", "User");
            task = new Table("TaskList", "Task", "Project", "Theme", "Type", "Priority", "User", "Description");
        }

        //Создание файла
        private void toolSpFileCreate_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            dataBase.CreateFile();
            project.CreateTable();
            project.AddColumn(project.ColumnName);
            user.CreateTable();
            user.AddColumn(user.ColumnName);
            task.CreateTable();
            task.AddColumn(task.ColumnName, task.ColumnName1, task.ColumnName2, task.ColumnName3, task.ColumnName4, task.ColumnName5, task.ColumnName6);
        }



        //Открытие файла
        private void toolSpFileOpen_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            dataBase.OpenFile();
        }

        //Кнопка добавления проекта
        private void bnAddNameProject_Click(object sender, EventArgs e)
        {
            if (File.Exists(dbFileName = DataBase.dbFileName))
            {
                if (tbProjectName.Text != "")
                {
                    project.AddItem(tbProjectName.Text,project.ColumnName);
                    tbProjectName.Clear();
                }
                else
                {
                    MessageBox.Show("Введите название проекта!");
                }
            }
            else
            {
                MessageBox.Show("Необходимо создать или открыть файл базы данных!");
            }
        }

        //Кнопка удаления проекта
        private void bnDeleteProject_Click(object sender, EventArgs e)
        {
            if (File.Exists(dbFileName = DataBase.dbFileName))
            {
                if (cbProjectName.SelectedIndex >= 0)
                {                    
                    project.DelItem(cbProjectName.SelectedItem.ToString(), project.ColumnName);
                    task.DelItem(cbProjectName.SelectedItem.ToString(), task.ColumnName5);
                    cbProjectName.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Введите название проекта!");
                }
            }
            else
            {
                MessageBox.Show("Необходимо создать или открыть файл базы данных!");
            }
        }

        //Кнопка добавления пользователя
        private void bnAddNameUser_Click(object sender, EventArgs e)
        {
            if (File.Exists(dbFileName = DataBase.dbFileName))
            {
                if (tbUserName.Text != "")
                {
                    user.AddItem(tbUserName.Text, user.ColumnName);
                    tbUserName.Clear();
                }
                else
                {
                    MessageBox.Show("Введите имя пользователя!");
                }
            }
            else
            {
                MessageBox.Show("Необходимо создать или открыть файл базы данных!");
            }
        }
        
        //Кнопка удаления пользователя
        private void bnDeleteUser_Click(object sender, EventArgs e)
        {
            if (File.Exists(dbFileName = DataBase.dbFileName))
            {
                if (cbUserName.SelectedIndex >= 0)
                {
                    user.DelItem(cbUserName.SelectedItem.ToString(), user.ColumnName);
                    task.DelItem(cbUserName.SelectedItem.ToString(), task.ColumnName1);
                    cbUserName.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Введите имя пользователя!");
                }
            }
            else
            {
                MessageBox.Show("Необходимо создать или открыть файл базы данных!");
            }
        }

        //Кнопка добавления задачи
        private void bnAddTask_Click(object sender, EventArgs e)
        {
            if (File.Exists(dbFileName = DataBase.dbFileName))
            {
                if (tbTaskName.Text != "" && tbDescriptionName.Text != "" && tbPriorityName.Text != "" && tbThemeName.Text != "" && tbTypeName.Text != "" && cbProjectNameForTask.Text != "" && cbUserNameForTask.Text != "")
                {
                    string [] array = { tbTaskName.Text, cbProjectNameForTask.SelectedItem.ToString(), tbThemeName.Text, tbTypeName.Text, tbPriorityName.Text, cbUserNameForTask.SelectedItem.ToString(), tbDescriptionName.Text};
                    string AllRow = string.Join("', '", array);
                    task.AddItem(AllRow, task.ColumnName, task.ColumnName1, task.ColumnName2, task.ColumnName3, task.ColumnName4, task.ColumnName5, task.ColumnName6);
                }
                else
                {
                    MessageBox.Show("Введите информацию о задаче!");
                }
            }
            else
            {
                MessageBox.Show("Необходимо создать или открыть файл базы данных!");
            }
        }

        //Кнопка удаления задачи
        private void bnDeleteTask_Click(object sender, EventArgs e)
        {
            if (File.Exists(dbFileName = DataBase.dbFileName))
            {
                if (cbTaskName.SelectedIndex >= 0)
                {
                    task.DelItem(cbTaskName.SelectedItem.ToString(),task.ColumnName);                    
                    cbTaskName.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Введите название задачи!");
                }
            }
            else
            {
                MessageBox.Show("Необходимо создать или открыть файл базы данных!");
            }
        }

        //Показать список проектов
        private void bnShowProjects_Click(object sender, EventArgs e)
        {            
            if (File.Exists(dbFileName = DataBase.dbFileName))
            {                               
                DataGridViewTextBoxColumn dgvProject = new DataGridViewTextBoxColumn();
                try
                {
                    dgvViewer.Rows.Clear();
                    dgvViewer.Columns.Clear();
                    dgvProject.Name = "Project";
                    dgvProject.HeaderText = "Название проекта";
                    dgvViewer.Columns.Add(dgvProject);
                    dgvViewer.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    dgvViewer.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    for (int i = 0; i < project.SelectColumn().Rows.Count; i++)
                        dgvViewer.Rows.Add(project.SelectColumn().Rows[i].ItemArray);
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Необходимо создать или открыть файл базы данных!");
            }                
        }

        //Показать список пользователей
        private void bnShowUsers_Click(object sender, EventArgs e)
        {
            if (File.Exists(dbFileName = DataBase.dbFileName))
            {
                DataGridViewTextBoxColumn dgvUser = new DataGridViewTextBoxColumn();
                try
                {
                    dgvViewer.Rows.Clear();
                    dgvViewer.Columns.Clear();
                    dgvUser.Name = "User";
                    dgvUser.HeaderText = "Имя пользователя";
                    dgvViewer.Columns.Add(dgvUser);
                    dgvViewer.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    dgvViewer.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    for (int i = 0; i < user.SelectColumn().Rows.Count; i++)
                        dgvViewer.Rows.Add(user.SelectColumn().Rows[i].ItemArray);
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Необходимо создать или открыть файл базы данных!");
            }
        }

        //Показать список задач в проекте
        private void bnShowTasksInProject_Click(object sender, EventArgs e)
        {
            if (File.Exists(dbFileName = DataBase.dbFileName))
            {
                DataGridViewTextBoxColumn dgvIdTask = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn dgvTask = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn dgvProject = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn dgvTheme = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn dgvType = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn dgvPriority = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn dgvUser = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn dgvDescription = new DataGridViewTextBoxColumn();
                try
                {
                    dgvViewer.Rows.Clear();
                    dgvViewer.Columns.Clear();
                    dgvIdTask.Name = "idTask";
                    dgvIdTask.HeaderText = "Порядковый номер";
                    dgvTask.Name = "Task";
                    dgvTask.HeaderText = "Название задачи";
                    dgvProject.Name = "Project";
                    dgvProject.HeaderText = "Проект";
                    dgvTheme.Name = "Theme";
                    dgvTheme.HeaderText = "Тема";
                    dgvType.Name = "Type";
                    dgvType.HeaderText = "Тип";
                    dgvPriority.Name = "Priority";
                    dgvPriority.HeaderText = "Приоритет";
                    dgvUser.Name = "User";
                    dgvUser.HeaderText = "Исполнитель";
                    dgvDescription.Name = "Description";
                    dgvDescription.HeaderText = "Описание";
                    dgvIdTask.Visible = false;
                    dgvViewer.Columns.Add(dgvIdTask);
                    dgvViewer.Columns.Add(dgvTask);
                    dgvViewer.Columns.Add(dgvProject);
                    dgvViewer.Columns.Add(dgvTheme);
                    dgvViewer.Columns.Add(dgvType);
                    dgvViewer.Columns.Add(dgvPriority);
                    dgvViewer.Columns.Add(dgvUser);
                    dgvViewer.Columns.Add(dgvDescription);
                    dgvViewer.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    dgvViewer.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    for (int i = 0; i < task.SelectTableWhere("Project",cbTasksInProject.SelectedItem.ToString()).Rows.Count; i++)
                        dgvViewer.Rows.Add(task.SelectTableWhere("Project", cbTasksInProject.SelectedItem.ToString()).Rows[i].ItemArray);
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Необходимо создать или открыть файл базы данных!");
            }
        }

        //Показать список задач на исполнителе
        private void bnShowTasksOnUser_Click(object sender, EventArgs e)
        {
            if (File.Exists(dbFileName = DataBase.dbFileName))
            {
                DataGridViewTextBoxColumn dgvIdTask = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn dgvTask = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn dgvProject = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn dgvTheme = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn dgvType = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn dgvPriority = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn dgvUser = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn dgvDescription = new DataGridViewTextBoxColumn();
                try
                {
                    dgvViewer.Rows.Clear();
                    dgvViewer.Columns.Clear();
                    dgvIdTask.Name = "idTask";
                    dgvIdTask.HeaderText = "Порядковый номер";
                    dgvTask.Name = "Task";
                    dgvTask.HeaderText = "Название задачи";
                    dgvProject.Name = "Project";
                    dgvProject.HeaderText = "Проект";
                    dgvTheme.Name = "Theme";
                    dgvTheme.HeaderText = "Тема";
                    dgvType.Name = "Type";
                    dgvType.HeaderText = "Тип";
                    dgvPriority.Name = "Priority";
                    dgvPriority.HeaderText = "Приоритет";
                    dgvUser.Name = "User";
                    dgvUser.HeaderText = "Исполнитель";
                    dgvDescription.Name = "Description";
                    dgvDescription.HeaderText = "Описание";
                    dgvIdTask.Visible = false;
                    dgvViewer.Columns.Add(dgvIdTask);
                    dgvViewer.Columns.Add(dgvTask);
                    dgvViewer.Columns.Add(dgvProject);
                    dgvViewer.Columns.Add(dgvTheme);
                    dgvViewer.Columns.Add(dgvType);
                    dgvViewer.Columns.Add(dgvPriority);
                    dgvViewer.Columns.Add(dgvUser);
                    dgvViewer.Columns.Add(dgvDescription);
                    dgvViewer.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    dgvViewer.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    for (int i = 0; i < task.SelectTableWhere("User", cbTasksOnUser.SelectedItem.ToString()).Rows.Count; i++)
                        dgvViewer.Rows.Add(task.SelectTableWhere("User", cbTasksOnUser.SelectedItem.ToString()).Rows[i].ItemArray);
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Необходимо создать или открыть файл базы данных!");
            }
        }

        
        //Заполнение списка проектов в ComboBoxы
        private void fillCbTasksInProject()
        {            
            cbTasksInProject.Items.Clear();
            cbProjectName.Items.Clear();
            cbProjectNameForTask.Items.Clear();
            for (int i = 0; i < project.SelectColumn().Rows.Count; i++)
            {
                cbTasksInProject.Items.AddRange(project.SelectColumn().Rows[i].ItemArray);
                cbProjectName.Items.AddRange(project.SelectColumn().Rows[i].ItemArray);
                cbProjectNameForTask.Items.AddRange(project.SelectColumn().Rows[i].ItemArray);
            }
        }

        private void cbProjectName_DropDown(object sender, EventArgs e)
        {
            if (File.Exists(dbFileName = DataBase.dbFileName))
            {
                fillCbTasksInProject();
            }
        }

        private void cbProjectNameForTask_DropDown(object sender, EventArgs e)
        {
            if (File.Exists(dbFileName = DataBase.dbFileName))
            {
                fillCbTasksInProject();
            }
        }

        private void cbTasksInProject_DropDown(object sender, EventArgs e)
        {
            if (File.Exists(dbFileName = DataBase.dbFileName))
            {
                fillCbTasksInProject();
            }
        }

        //Заполнение списка пользователей в ComboBoxы
        private void fillCbTasksOnUser()
        {            
            cbTasksOnUser.Items.Clear();
            cbUserName.Items.Clear();
            cbUserNameForTask.Items.Clear();
            for (int i = 0; i < user.SelectColumn().Rows.Count; i++)
            {
                cbTasksOnUser.Items.AddRange(user.SelectColumn().Rows[i].ItemArray);
                cbUserName.Items.AddRange(user.SelectColumn().Rows[i].ItemArray);
                cbUserNameForTask.Items.AddRange(user.SelectColumn().Rows[i].ItemArray);
            }
        }
        private void cbUserName_DropDown(object sender, EventArgs e)
        {
            if (File.Exists(dbFileName = DataBase.dbFileName))
            {
                fillCbTasksOnUser();
            }
        }

        private void cbUserNameForTask_DropDown(object sender, EventArgs e)
        {
            if (File.Exists(dbFileName = DataBase.dbFileName))
            {
                fillCbTasksOnUser();
            }
        }

        private void cbTasksOnUser_DropDown(object sender, EventArgs e)
        {
            if (File.Exists(dbFileName = DataBase.dbFileName))
            {
                fillCbTasksOnUser();
            }
        }

        //Заполнение списка задач в ComboBox
        private void fillCbTasks()
        {            
            cbTaskName.Items.Clear();            
            for (int i = 0; i < task.SelectColumn().Rows.Count; i++)
            {
                cbTaskName.Items.AddRange(task.SelectColumn().Rows[i].ItemArray);                
            }
        }

        private void cbTaskName_DropDown(object sender, EventArgs e)
        {
            if (File.Exists(dbFileName = DataBase.dbFileName))
            {
                fillCbTasks();
            }
        }

        //Показать логи
        private void bnShowLogs_Click(object sender, EventArgs e)
        {
            if (File.Exists(dbFileName))
            {
                string sqlQuery;
                DataTable dTable = new DataTable();
                DataGridViewTextBoxColumn dgvTrigger = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn dgvIdTrigger = new DataGridViewTextBoxColumn();
                try
                {
                    sqlQuery = "SELECT * FROM TriggerList";
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, dbConnect);
                    adapter.Fill(dTable);
                    dgvViewer.Rows.Clear();
                    dgvViewer.Columns.Clear();
                    dgvIdTrigger.Name = "IdTrigger";
                    dgvIdTrigger.HeaderText = "№";
                    dgvViewer.Columns.Add(dgvIdTrigger);
                    dgvTrigger.Name = "Trigger";
                    dgvTrigger.HeaderText = "Операция";                    
                    dgvViewer.Columns.Add(dgvTrigger);                    
                    dgvViewer.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    dgvViewer.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    for (int i = 0; i < dTable.Rows.Count; i++)
                        dgvViewer.Rows.Add(dTable.Rows[i].ItemArray);
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Необходимо создать или открыть файл базы данных!");
            }
        }

        
    }    
}
