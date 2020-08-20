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
    class Project
    {
        public string dbFileName;
        public SQLiteConnection dbConnect;
        public SQLiteCommand dbCommand;

        public Project(string dbFileName, SQLiteConnection dbConnect, SQLiteCommand dbCommand)
        {
            this.dbFileName = dbFileName;
            this.dbConnect = dbConnect;
            this.dbCommand = dbCommand;
        }

        //Добавление проекта
        public void AddNameProject(string tbProjectName)
        {
            DataBase dataBase = new DataBase();
            dataBase.AddItem("ProjectList", "Project", tbProjectName);
        }

        //Вызов формы для удаления проекта
        public void DeleteNameProject()
        {
            if (File.Exists(dbFileName))
            {
                FormDeleteProject formDeleteProject = new FormDeleteProject(dbFileName, dbConnect, dbCommand);
                formDeleteProject.Show();
            }
            else
            {
                MessageBox.Show("Необходимо создать или открыть файл базы данных!");
            }
        }
        
        //Показать список проектов
        public void ShowProjects(DataGridView dgvViewer)
        {
            
            DataBase dataBase = new DataBase();            
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
                for (int i = 0; i < dataBase.SelectColumn("ProjectList","Project").Rows.Count; i++)
                    dgvViewer.Rows.Add(dataBase.SelectColumn("ProjectList","Project").Rows[i].ItemArray);
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }                                 
        }
    }
}
