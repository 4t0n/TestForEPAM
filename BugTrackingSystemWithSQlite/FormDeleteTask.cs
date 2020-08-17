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
    public partial class FormDeleteTask : Form
    {
        public string dbFileName;
        public SQLiteConnection dbConnect;
        public SQLiteCommand dbCommand;
        public FormDeleteTask(string dbFileName, SQLiteConnection dbConnect, SQLiteCommand dbCommand)
        {
            InitializeComponent();
            this.dbFileName = dbFileName;
            this.dbConnect = dbConnect;
            this.dbCommand = dbCommand;
        }        

        //Заполнение списка задач
        private void FormDeleteTask_Load(object sender, EventArgs e)
        {
            dbConnect = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
            dbConnect.Open();
            dbCommand.Connection = dbConnect;
            string sqlQuery;
            DataTable dTable = new DataTable();
            sqlQuery = "SELECT Task FROM TaskList";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, dbConnect);
            adapter.Fill(dTable);
            cbTaskNameForDelete.Items.Clear();

            for (int i = 0; i < dTable.Rows.Count; i++)
            {
                cbTaskNameForDelete.Items.AddRange(dTable.Rows[i].ItemArray);
            }
        }

        //Кнопка удаления задачи
        private void bnDeleteTask_Click(object sender, EventArgs e)
        {
            if (cbTaskNameForDelete.SelectedIndex >= 0)
            {
                string sqlQuery = "DELETE FROM TaskList WHERE Task = '" + cbTaskNameForDelete.SelectedItem.ToString() + "'";
                try
                {
                    dbCommand.CommandText = sqlQuery;
                    dbCommand.ExecuteNonQuery();
                    MessageBox.Show("Задача удалена.");
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Введите название задачи!");
            }
        }
    }
}
