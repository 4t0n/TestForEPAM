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
    public static class DataBase
    {
        //Набор инструментов для работы с БД

        public static string dbFileName;
        public static SQLiteConnection dbConnect = new SQLiteConnection();
        public static SQLiteCommand dbCommand = new SQLiteCommand();

        //Создать файл
        public static void CreateFile()
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
        public static void OpenFile()
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

        //Создать таблицу
        public static void CreateTable(string tableName)
        {
            string sqlQuery = "CREATE TABLE IF NOT EXISTS " + tableName + " (idProject INTEGER PRIMARY KEY AUTOINCREMENT)";
            dbConnect = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
            dbConnect.Open();
            dbCommand.Connection = dbConnect;
            dbCommand.CommandText = sqlQuery;
            dbCommand.ExecuteNonQuery();
        }

        //Создать триггеры
        public static void CreateTrigger(string tableName, string addText, string delText)
        {
            dbConnect = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
            dbConnect.Open();
            dbCommand.Connection = dbConnect;
            dbCommand.CommandText = "CREATE TABLE IF NOT EXISTS TriggerList (idTrigger INTEGER PRIMARY KEY AUTOINCREMENT, Trigger TEXT)";
            dbCommand.ExecuteNonQuery();
            dbCommand.CommandText = "CREATE TRIGGER IF NOT EXISTS AddTrigger"+tableName+" AFTER INSERT ON "+tableName+" BEGIN INSERT INTO TriggerList('Trigger') VALUES ('"+addText+"'); END";
            dbCommand.ExecuteNonQuery();
            dbCommand.CommandText = "CREATE TRIGGER IF NOT EXISTS DelTrigger"+tableName+" AFTER DELETE ON "+tableName+" BEGIN INSERT INTO TriggerList('Trigger') VALUES ('"+delText+"'); END";
            dbCommand.ExecuteNonQuery();
        }

        //Создать колонки
        public static void AddColumn(string tableName, params string[] columnName)
        {
            string sqlQuery;
            for (int i = 0; i < columnName.Length; i++)
            {
                sqlQuery = "ALTER TABLE " + tableName + " ADD COLUMN " + columnName[i] + " TEXT";
                dbConnect = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
                dbConnect.Open();
                dbCommand.Connection = dbConnect;
                dbCommand.CommandText = sqlQuery;
                dbCommand.ExecuteNonQuery();
            }
        }

        //Добавить строку
        public static void AddItem(string tableName, string itemName, params string[] columnName)
        {            
            string JoinColumnName = string.Join("', '", columnName);
            dbConnect = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
            dbConnect.Open();
            dbCommand.Connection = dbConnect;
            string sqlQuery = "INSERT INTO " + tableName + " ('" + JoinColumnName + "') VALUES ('" +
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

        //Удалить строку
        public static void DelItem(string tableName, string itemName, string columnName)
        {            
            dbConnect = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
            dbConnect.Open();
            dbCommand.Connection = dbConnect;
            string sqlQuery = "DELETE FROM " + tableName + " WHERE " + columnName + " = '" + itemName + "'";
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

        //Выделить колонку и добавить в dTable
        public static DataTable SelectColumn(string tableName, string columnName)
        {
            string sqlQuery;
            DataTable dTable = new DataTable();
            sqlQuery = "SELECT " + columnName + " FROM " + tableName + "";
            dbConnect = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, dbConnect);
            adapter.Fill(dTable);
            return dTable;
        }

        //Выделить таблицу и добавить в dTable
        public static DataTable SelectTable(string tableName)
        {
            string sqlQuery;
            DataTable dTable = new DataTable();
            sqlQuery = "SELECT * FROM " + tableName + "";
            dbConnect = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, dbConnect);
            adapter.Fill(dTable);
            return dTable;
        }

        //Выделить строки, где колонка columnName имеет значение cellValue и добавить в dTable
        public static DataTable SelectTableWhere(string tableName, string columnName, string cellValue)
        {
            string sqlQuery;
            DataTable dTable = new DataTable();
            sqlQuery = "SELECT * FROM " + tableName + " WHERE "+columnName+" = '"+cellValue+"'" ;
            dbConnect = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, dbConnect);
            adapter.Fill(dTable);
            return dTable;
        }
    }
}
