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
using System.Data.SqlClient;

namespace BugTrackingSystemWithSQlite
{
    class DataBase
    {
        public static string dbFileName;
        public static SQLiteConnection dbConnect = new SQLiteConnection();
        public static SQLiteCommand dbCommand = new SQLiteCommand();

        //Создать файл
        public void CreateFile()
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
                        SQLiteConnection.CreateFile(dbFileName);
                    }
                    catch (SQLiteException ex)
                    {
                        MessageBox.Show("Ошибка: " + ex.Message);
                    }
                }                
            }
        }

        //Открыть файл
        public void OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            openFileDialog.Filter = "DataBase Files(*.db;*.sdb;*.sqlite;*.db3;*.s3db;*.sqlite3;*.sl3;)|*.db*;.sdb;*.sqlite;*.db3;*.s3db;*.sqlite3;*.sl3;";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                dbFileName = openFileDialog.FileName;                
            }
        }

        public void CreateDataBase (string tableName)
        {            
            /*dbConnect = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
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
            dbCommand.ExecuteNonQuery();*/
        }

        //Создать таблицу
        public void CreateTable(string tableName)
        {
            string sqlQuery = "CREATE TABLE IF NOT EXISTS "+tableName+" (idProject INTEGER PRIMARY KEY AUTOINCREMENT)";
            dbConnect = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
            dbConnect.Open();
            dbCommand.Connection = dbConnect;
            dbCommand.CommandText = sqlQuery;
            dbCommand.ExecuteNonQuery();
        }
        //Создать 1 колонку
        public void AddColumn (string tableName, string columnName)
        {
            string sqlQuery = "ALTER TABLE "+tableName+" ADD COLUMN "+columnName+" TEXT";
            dbConnect = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
            dbConnect.Open();
            dbCommand.Connection = dbConnect;
            dbCommand.CommandText = sqlQuery;
            dbCommand.ExecuteNonQuery();
        }
        //Создать 2 колонки
        public void AddColumn(string tableName, string columnName, string columnName1)
        {            
            dbConnect = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
            dbConnect.Open();
            dbCommand.Connection = dbConnect;
            dbCommand.CommandText = "ALTER TABLE " + tableName + " ADD COLUMN " + columnName + " TEXT";
            dbCommand.ExecuteNonQuery();
            dbCommand.CommandText = "ALTER TABLE " + tableName + " ADD COLUMN " + columnName1 + " TEXT";
            dbCommand.ExecuteNonQuery();

        }
        //Создать 3 колонки
        public void AddColumn(string tableName, string columnName, string columnName1, string columnName2)
        {            
            dbConnect = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
            dbConnect.Open();
            dbCommand.Connection = dbConnect;
            dbCommand.CommandText = "ALTER TABLE " + tableName + " ADD COLUMN " + columnName + " TEXT";
            dbCommand.ExecuteNonQuery();
            dbCommand.CommandText = "ALTER TABLE " + tableName + " ADD COLUMN " + columnName1 + " TEXT";
            dbCommand.ExecuteNonQuery();
            dbCommand.CommandText = "ALTER TABLE " + tableName + " ADD COLUMN " + columnName2 + " TEXT";
            dbCommand.ExecuteNonQuery();
        }
        //Создать 4 колонки
        public void AddColumn(string tableName, string columnName, string columnName1, string columnName2, string columnName3)
        {            
            dbConnect = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
            dbConnect.Open();
            dbCommand.Connection = dbConnect;
            dbCommand.CommandText = "ALTER TABLE " + tableName + " ADD COLUMN " + columnName + " TEXT";
            dbCommand.ExecuteNonQuery();
            dbCommand.CommandText = "ALTER TABLE " + tableName + " ADD COLUMN " + columnName1 + " TEXT";
            dbCommand.ExecuteNonQuery();
            dbCommand.CommandText = "ALTER TABLE " + tableName + " ADD COLUMN " + columnName2 + " TEXT";
            dbCommand.ExecuteNonQuery();
            dbCommand.CommandText = "ALTER TABLE " + tableName + " ADD COLUMN " + columnName3 + " TEXT";
            dbCommand.ExecuteNonQuery();
        }
        //Создать 5 колонок
        public void AddColumn(string tableName, string columnName, string columnName1, string columnName2, string columnName3, string columnName4)
        {
            dbConnect = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
            dbConnect.Open();
            dbCommand.Connection = dbConnect;
            dbCommand.CommandText = "ALTER TABLE " + tableName + " ADD COLUMN " + columnName + " TEXT";
            dbCommand.ExecuteNonQuery();
            dbCommand.CommandText = "ALTER TABLE " + tableName + " ADD COLUMN " + columnName1 + " TEXT";
            dbCommand.ExecuteNonQuery();
            dbCommand.CommandText = "ALTER TABLE " + tableName + " ADD COLUMN " + columnName2 + " TEXT";
            dbCommand.ExecuteNonQuery();
            dbCommand.CommandText = "ALTER TABLE " + tableName + " ADD COLUMN " + columnName3 + " TEXT";
            dbCommand.ExecuteNonQuery();
            dbCommand.CommandText = "ALTER TABLE " + tableName + " ADD COLUMN " + columnName4 + " TEXT";
            dbCommand.ExecuteNonQuery();
        }
        //Создать 6 колонок
        public void AddColumn(string tableName, string columnName, string columnName1, string columnName2, string columnName3, string columnName4, string columnName5)
        {
            dbConnect = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
            dbConnect.Open();
            dbCommand.Connection = dbConnect;
            dbCommand.CommandText = "ALTER TABLE " + tableName + " ADD COLUMN " + columnName + " TEXT";
            dbCommand.ExecuteNonQuery();
            dbCommand.CommandText = "ALTER TABLE " + tableName + " ADD COLUMN " + columnName1 + " TEXT";
            dbCommand.ExecuteNonQuery();
            dbCommand.CommandText = "ALTER TABLE " + tableName + " ADD COLUMN " + columnName2 + " TEXT";
            dbCommand.ExecuteNonQuery();
            dbCommand.CommandText = "ALTER TABLE " + tableName + " ADD COLUMN " + columnName3 + " TEXT";
            dbCommand.ExecuteNonQuery();
            dbCommand.CommandText = "ALTER TABLE " + tableName + " ADD COLUMN " + columnName4 + " TEXT";
            dbCommand.ExecuteNonQuery();
            dbCommand.CommandText = "ALTER TABLE " + tableName + " ADD COLUMN " + columnName5 + " TEXT";
            dbCommand.ExecuteNonQuery();
        }
        //Создать 7 колонок
        public void AddColumn(string tableName, string columnName, string columnName1, string columnName2, string columnName3, string columnName4, string columnName5, string columnName6)
        {
            dbConnect = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
            dbConnect.Open();
            dbCommand.Connection = dbConnect;
            dbCommand.CommandText = "ALTER TABLE " + tableName + " ADD COLUMN " + columnName + " TEXT";
            dbCommand.ExecuteNonQuery();
            dbCommand.CommandText = "ALTER TABLE " + tableName + " ADD COLUMN " + columnName1 + " TEXT";
            dbCommand.ExecuteNonQuery();
            dbCommand.CommandText = "ALTER TABLE " + tableName + " ADD COLUMN " + columnName2 + " TEXT";
            dbCommand.ExecuteNonQuery();
            dbCommand.CommandText = "ALTER TABLE " + tableName + " ADD COLUMN " + columnName3 + " TEXT";
            dbCommand.ExecuteNonQuery();
            dbCommand.CommandText = "ALTER TABLE " + tableName + " ADD COLUMN " + columnName4 + " TEXT";
            dbCommand.ExecuteNonQuery();
            dbCommand.CommandText = "ALTER TABLE " + tableName + " ADD COLUMN " + columnName5 + " TEXT";
            dbCommand.ExecuteNonQuery();
            dbCommand.CommandText = "ALTER TABLE " + tableName + " ADD COLUMN " + columnName6 + " TEXT";
            dbCommand.ExecuteNonQuery();
        }

        //Добавить значение в колонку
        public void AddItem(string tableName, string columnName, string itemName)
        {
            if (File.Exists(dbFileName))
            {                
                dbConnect = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
                dbConnect.Open();
                dbCommand.Connection = dbConnect;
                string sqlQuery = "INSERT INTO "+ tableName +" ('"+columnName+"') values ('" +
                        itemName + "')";
                try
                {
                    dbCommand.CommandText = sqlQuery;
                    dbCommand.ExecuteNonQuery();
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
                dbConnect.Close();
            }
            else
            {
                MessageBox.Show("Необходимо создать или открыть файл базы данных!");
            }
        }

        //Удалить строку из колонки
        public void DelItem(string tableName, string columnName, string itemName)
        {
            if (File.Exists(dbFileName))
            {
                dbConnect = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
                dbConnect.Open();
                dbCommand.Connection = dbConnect;
                string sqlQuery = "DELETE FROM "+tableName+" WHERE "+columnName+" = '" + itemName + "'";
                try
                {
                    dbCommand.CommandText = sqlQuery;
                    dbCommand.ExecuteNonQuery();
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
                dbConnect.Close();
            }
            else
            {
                MessageBox.Show("Необходимо создать или открыть файл базы данных!");
            }
        }

        //Выделить колонку
        public DataTable SelectColumn(string tableName, string columnName)
        {
            string sqlQuery;
            DataTable dTable = new DataTable();
            sqlQuery = "SELECT "+columnName+" FROM "+tableName+"";
            dbConnect = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");            
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, dbConnect);
            adapter.Fill(dTable);
            return dTable;
        }

        //Выжелить таблицу
        public DataTable SelectTable(string tableName)
        {
            string sqlQuery;
            DataTable dTable = new DataTable();
            sqlQuery = "SELECT * FROM " + tableName + "";
            dbConnect = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, dbConnect);
            adapter.Fill(dTable);
            return dTable;
        }
    }
}
