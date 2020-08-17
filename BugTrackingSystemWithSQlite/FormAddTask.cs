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
using System.ComponentModel.DataAnnotations.Schema;

namespace BugTrackingSystemWithSQlite
{
    public partial class FormAddTask : Form
    {
        public string dbFileName;
        public SQLiteConnection dbConnect;
        public SQLiteCommand dbCommand;
        public FormAddTask(string dbFileName, SQLiteConnection dbConnect, SQLiteCommand dbCommand)
        {
            InitializeComponent();
            this.dbFileName = dbFileName;
            this.dbConnect = dbConnect;
            this.dbCommand = dbCommand;
        }

        //Заполнение списка проектов и пользователей
        private void FormAddTask_Load(object sender, EventArgs e)
        {
            dbConnect = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
            dbConnect.Open();
            dbCommand.Connection = dbConnect;
            string sqlQueryProject;
            string sqlQueryUser;
            DataTable dTableProject = new DataTable();
            DataTable dTableUser = new DataTable();
            sqlQueryProject = "SELECT Project FROM ProjectList";
            sqlQueryUser = "SELECT User FROM UserList";
            SQLiteDataAdapter adapterProject = new SQLiteDataAdapter(sqlQueryProject, dbConnect);
            adapterProject.Fill(dTableProject);
            SQLiteDataAdapter adapterUser = new SQLiteDataAdapter(sqlQueryUser, dbConnect);
            adapterUser.Fill(dTableUser);
            cbProjectName.Items.Clear();
            cbUserName.Items.Clear();

            for (int i = 0; i < dTableProject.Rows.Count; i++)
            {
                cbProjectName.Items.AddRange(dTableProject.Rows[i].ItemArray);
            }

            for (int i = 0; i < dTableUser.Rows.Count; i++)
            {
                cbUserName.Items.AddRange(dTableUser.Rows[i].ItemArray);
            }
        }

        //Кнопка добавления задачи
        private void bnAddTask_Click(object sender, EventArgs e)
        {
            string sqlQuery = "INSERT INTO TaskList (Task, Project, Theme, Type, Priority, User, Description) values ('" +tbTaskName.Text+ "', '"+cbProjectName.SelectedItem.ToString()+"','"+tbTheme.Text+"','"+tbType.Text+"','"+tbPriority.Text+"','"+cbUserName.SelectedItem.ToString()+"','"+tbDescription.Text+"')";
            try
            {
                dbCommand.CommandText = sqlQuery;
                dbCommand.ExecuteNonQuery();
                MessageBox.Show("Задача добавлена.");
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            this.Close();
        }        
    }
}
