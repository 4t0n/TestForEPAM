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
        public string dbFileName;
        public SQLiteConnection dbConnect;
        public SQLiteCommand dbCommand;        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbConnect = new SQLiteConnection();
            dbCommand = new SQLiteCommand();
            
        }

        //Создание файла
        private void toolSpFileCreate_Click(object sender, EventArgs e)
        {            
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            saveFileDialog1.Filter = "DataBase Files(*.db;*.sdb;*.sqlite;*.db3;*.s3db;*.sqlite3;*.sl3;)|*.db*;.sdb;*.sqlite;*.db3;*.s3db;*.sqlite3;*.sl3;";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.DefaultExt = "db";
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    myStream.Close();
                    dbFileName = saveFileDialog1.FileName;
                    try
                    {
                        dbConnect = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
                        dbConnect.Open();
                        dbCommand.Connection = dbConnect;
                        dbCommand.CommandText = "CREATE TABLE IF NOT EXISTS ProjectList (idProject INTEGER PRIMARY KEY AUTOINCREMENT, Project TEXT);CREATE TABLE IF NOT EXISTS UserList (idProject INTEGER PRIMARY KEY AUTOINCREMENT, User TEXT);CREATE TABLE IF NOT EXISTS TaskList (idTask INTEGER PRIMARY KEY AUTOINCREMENT, Task TEXT, Project TEXT, Theme TEXT, Type TEXT, Priority TEXT, User TEXT, Description TEXT);CREATE TABLE IF NOT EXISTS TriggerList (idTrigger INTEGER PRIMARY KEY AUTOINCREMENT, Trigger TEXT)";
                        dbCommand.ExecuteNonQuery();
                        dbCommand.CommandText = "CREATE TRIGGER IF NOT EXISTS ProjectAddTrigger AFTER INSERT ON ProjectList BEGIN INSERT INTO TriggerList('Trigger') VALUES ('Добавлен проект.'); END";
                        dbCommand.ExecuteNonQuery();
                        dbCommand.CommandText = "CREATE TRIGGER IF NOT EXISTS ProjectDelTrigger AFTER DELETE ON ProjectList BEGIN INSERT INTO TriggerList('Trigger') VALUES ('Удалён проект.'); END";
                        dbCommand.ExecuteNonQuery();
                        dbCommand.CommandText = "CREATE TRIGGER IF NOT EXISTS UserAddTrigger AFTER INSERT ON UserList BEGIN INSERT INTO TriggerList('Trigger') VALUES ('Добавлен пользователь.'); END";
                        dbCommand.ExecuteNonQuery();
                        dbCommand.CommandText = "CREATE TRIGGER IF NOT EXISTS UserDelTrigger AFTER DELETE ON USerList BEGIN INSERT INTO TriggerList('Trigger') VALUES ('Удалён пользователь.'); END";
                        dbCommand.ExecuteNonQuery();
                        dbCommand.CommandText = "CREATE TRIGGER IF NOT EXISTS TaskAddTrigger AFTER INSERT ON TaskList BEGIN INSERT INTO TriggerList('Trigger') VALUES ('Добавлена задача.'); END";
                        dbCommand.ExecuteNonQuery();
                        dbCommand.CommandText = "CREATE TRIGGER IF NOT EXISTS TaskDelTrigger AFTER DELETE ON TaskList BEGIN INSERT INTO TriggerList('Trigger') VALUES ('Удалена задача.'); END";
                        dbCommand.ExecuteNonQuery();
                    }
                    catch (SQLiteException ex)
                    {
                        MessageBox.Show("Ошибка: " + ex.Message);
                    }                    
                }                
                dgvViewer.Rows.Clear();
                dgvViewer.Columns.Clear();
            }            
        }

        //Открытие файла
        private void toolSpFileOpen_Click(object sender, EventArgs e)
        {            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            openFileDialog.Filter = "DataBase Files(*.db;*.sdb;*.sqlite;*.db3;*.s3db;*.sqlite3;*.sl3;)|*.db*;.sdb;*.sqlite;*.db3;*.s3db;*.sqlite3;*.sl3;";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {                   
                dbFileName = openFileDialog.FileName;
                try
                {
                    dbConnect = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
                    dbConnect.Open();
                    dbCommand.Connection = dbConnect;
                    dbCommand.CommandText = "CREATE TABLE IF NOT EXISTS ProjectList (idProject INTEGER PRIMARY KEY AUTOINCREMENT, Project TEXT);CREATE TABLE IF NOT EXISTS UserList (idProject INTEGER PRIMARY KEY AUTOINCREMENT, User TEXT);CREATE TABLE IF NOT EXISTS TaskList (idTask INTEGER PRIMARY KEY AUTOINCREMENT, Task TEXT, Project TEXT, Theme TEXT, Type TEXT, Priority TEXT, User TEXT, Description TEXT);CREATE TABLE IF NOT EXISTS TriggerList (idTrigger INTEGER PRIMARY KEY AUTOINCREMENT, Trigger TEXT)";
                    dbCommand.ExecuteNonQuery();
                    dbCommand.CommandText = "CREATE TRIGGER IF NOT EXISTS ProjectAddTrigger AFTER INSERT ON ProjectList BEGIN INSERT INTO TriggerList('Trigger') VALUES ('Добавлен проект.'); END";
                    dbCommand.ExecuteNonQuery();
                    dbCommand.CommandText = "CREATE TRIGGER IF NOT EXISTS ProjectDelTrigger AFTER DELETE ON ProjectList BEGIN INSERT INTO TriggerList('Trigger') VALUES ('Удалён проект.'); END";
                    dbCommand.ExecuteNonQuery();
                    dbCommand.CommandText = "CREATE TRIGGER IF NOT EXISTS UserAddTrigger AFTER INSERT ON UserList BEGIN INSERT INTO TriggerList('Trigger') VALUES ('Добавлен пользователь.'); END";
                    dbCommand.ExecuteNonQuery();
                    dbCommand.CommandText = "CREATE TRIGGER IF NOT EXISTS UserDelTrigger AFTER DELETE ON USerList BEGIN INSERT INTO TriggerList('Trigger') VALUES ('Удалён пользователь.'); END";
                    dbCommand.ExecuteNonQuery();
                    dbCommand.CommandText = "CREATE TRIGGER IF NOT EXISTS TaskAddTrigger AFTER INSERT ON TaskList BEGIN INSERT INTO TriggerList('Trigger') VALUES ('Добавлена задача.'); END";
                    dbCommand.ExecuteNonQuery();
                    dbCommand.CommandText = "CREATE TRIGGER IF NOT EXISTS TaskDelTrigger AFTER DELETE ON TaskList BEGIN INSERT INTO TriggerList('Trigger') VALUES ('Удалена задача.'); END";
                    dbCommand.ExecuteNonQuery();
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }               
                dgvViewer.Rows.Clear();
                dgvViewer.Columns.Clear();
            }
        }

        //Кнопка добавления проекта
        private void bnAddNameProject_Click(object sender, EventArgs e)
        {
            if (File.Exists(dbFileName))
            {
                if (tbProjectName.Text != "")
                {
                    Project project = new Project(dbFileName, dbConnect, dbCommand);
                    project.AddNameProject(tbProjectName.Text);
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
            Project project = new Project(dbFileName, dbConnect, dbCommand);
            project.DeleteNameProject();            
        }

        //Кнопка добавления пользователя
        private void bnAddNameUser_Click(object sender, EventArgs e)
        {
            if (File.Exists(dbFileName))
            {
                if (tbUserName.Text != "")
                {
                    User user = new User(dbFileName, dbConnect, dbCommand);
                    user.AddNameUser(tbUserName.Text);
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
            User user = new User(dbFileName, dbConnect, dbCommand);
            user.DeleteNameUser();
        }

        //Кнопка добавления задачи
        private void bnAddTask_Click(object sender, EventArgs e)
        {
            Task task = new Task(dbFileName, dbConnect, dbCommand);
            task.AddNameTask();
        }

        //Кнопка удаления задачи
        private void bnDeleteTask_Click(object sender, EventArgs e)
        {
            Task task = new Task(dbFileName, dbConnect, dbCommand);
            task.DeleteNameTask();
        }

        //Показать список проектов
        private void bnShowProjects_Click(object sender, EventArgs e)
        {
            Project project = new Project(dbFileName, dbConnect, dbCommand);
            project.ShowProjects(dgvViewer);
        }

        //Показать список пользователей
        private void bnShowUsers_Click(object sender, EventArgs e)
        {
            User user = new User(dbFileName, dbConnect, dbCommand);
            user.ShowUsers(dgvViewer);
        }

        //Показать список задач в проекте
        private void bnShowTasksInProject_Click(object sender, EventArgs e)
        {
            Task task = new Task(dbFileName, dbConnect, dbCommand);            
            if (File.Exists(dbFileName))
            {
                if (cbTasksInProject.SelectedIndex >= 0)
                {
                    task.ShowTasksInProject(dgvViewer, cbTasksInProject.SelectedItem.ToString());
                }
                else
                {
                    MessageBox.Show("Выберите проект!");
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
            Task task = new Task(dbFileName, dbConnect, dbCommand);
            if (File.Exists(dbFileName))
            {
                if (cbTasksOnUser.SelectedIndex >= 0)
                {
                    task.ShowTasksOnUser(dgvViewer, cbTasksOnUser.SelectedItem.ToString());
                }
                else
                {
                    MessageBox.Show("Выберите исполнителя!");
                }
            }
            else
            {
                MessageBox.Show("Необходимо создать или открыть файл базы данных!");
            }
        }

        
        //Заполнение списка проектов для задач
        private void fillCbTasksInProject()
        {
            dbConnect = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
            dbConnect.Open();
            dbCommand.Connection = dbConnect;
            string sqlQuery;
            DataTable dTable = new DataTable();
            sqlQuery = "SELECT Project FROM ProjectList";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, dbConnect);
            adapter.Fill(dTable);
            cbTasksInProject.Items.Clear();

            for (int i = 0; i < dTable.Rows.Count; i++)
            {
                cbTasksInProject.Items.AddRange(dTable.Rows[i].ItemArray);
            }
        }
        private void cbTasksInProject_Enter(object sender, EventArgs e)
        {
            if (File.Exists(dbFileName))
            {
                fillCbTasksInProject();
            }
        }

        //Заполнение списка пользователей для задач
        private void fillCbTasksOnUser()
        {
            dbConnect = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
            dbConnect.Open();
            dbCommand.Connection = dbConnect;
            string sqlQuery;
            DataTable dTable = new DataTable();
            sqlQuery = "SELECT User FROM UserList";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, dbConnect);
            adapter.Fill(dTable);
            cbTasksOnUser.Items.Clear();

            for (int i = 0; i < dTable.Rows.Count; i++)
            {
                cbTasksOnUser.Items.AddRange(dTable.Rows[i].ItemArray);
            }
        }
        private void cbTasksOnUser_Enter(object sender, EventArgs e)
        {
            if (File.Exists(dbFileName))
            {
                fillCbTasksOnUser();
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
