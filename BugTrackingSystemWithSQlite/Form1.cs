﻿using System;
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
            DataBase dataBase = new DataBase();
            dataBase.CreateFile();
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
            if (File.Exists(dbFileName = DataBase.dbFileName))
            {
                if (cbProjectName.SelectedIndex >= 0)
                {
                    Project project = new Project(dbFileName, dbConnect, dbCommand);
                    project.DeleteNameProject(cbProjectName.SelectedItem.ToString());                    
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
            if (File.Exists(dbFileName = DataBase.dbFileName))
            {
                project.ShowProjects(dgvViewer);
            }
            else
            {
                MessageBox.Show("Необходимо создать или открыть файл базы данных!");
            }                
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
            DataBase dataBase = new DataBase();
            cbTasksInProject.Items.Clear();
            cbProjectName.Items.Clear();
            for (int i = 0; i < dataBase.SelectColumn("ProjectList","Project").Rows.Count; i++)
            {
                cbTasksInProject.Items.AddRange(dataBase.SelectColumn("ProjectList", "Project").Rows[i].ItemArray);
                cbProjectName.Items.AddRange(dataBase.SelectColumn("ProjectList", "Project").Rows[i].ItemArray);
            }
        }
        private void cbTasksInProject_Enter(object sender, EventArgs e)
        {
            if (File.Exists(dbFileName = DataBase.dbFileName))
            {
                fillCbTasksInProject();
            }
        }

        private void cbProjectName_Enter(object sender, EventArgs e)
        {
            if (File.Exists(dbFileName = DataBase.dbFileName))
            {
                fillCbTasksInProject();
            }
        }

        //Заполнение списка пользователей для задач
        private void fillCbTasksOnUser()
        {
            DataBase dataBase = new DataBase();
            cbTasksOnUser.Items.Clear();

            for (int i = 0; i < dataBase.SelectColumn("UserList","User").Rows.Count; i++)
            {
                cbTasksOnUser.Items.AddRange(dataBase.SelectColumn("UserList", "User").Rows[i].ItemArray);
            }
        }
        private void cbTasksOnUser_Enter(object sender, EventArgs e)
        {
            if (File.Exists(dbFileName = DataBase.dbFileName))
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
