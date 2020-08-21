using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTrackingSystemWithSQlite
{
    class Table
    {
        private string tableName;
        private string columnName;
        private string columnName1;
        private string columnName2;
        private string columnName3;
        private string columnName4;
        private string columnName5;
        private string columnName6;

        public Table (string tableName, string columnName)
        {
            this.tableName = tableName;
            this.columnName = columnName;            
        }
        public Table(string tableName, string columnName, string columnName1)
        {
            this.tableName = tableName;
            this.columnName = columnName;
            this.columnName1 = columnName1;
        }
        public Table(string tableName, string columnName, string columnName1, string columnName2)
        {
            this.tableName = tableName;
            this.columnName = columnName;
            this.columnName1 = columnName1;
            this.columnName2 = columnName2;
        }
        public Table(string tableName, string columnName, string columnName1, string columnName2, string columnName3)
        {
            this.tableName = tableName;
            this.columnName = columnName;
            this.columnName1 = columnName1;
            this.columnName2 = columnName2;
            this.columnName3 = columnName3;
        }
        public Table(string tableName, string columnName, string columnName1, string columnName2, string columnName3, string columnName4)
        {
            this.tableName = tableName;
            this.columnName = columnName;
            this.columnName1 = columnName1;
            this.columnName2 = columnName2;
            this.columnName3 = columnName3;
            this.columnName4 = columnName4;
        }
        public Table(string tableName, string columnName, string columnName1, string columnName2, string columnName3, string columnName4, string columnName5)
        {
            this.tableName = tableName;
            this.columnName = columnName;
            this.columnName1 = columnName1;
            this.columnName2 = columnName2;
            this.columnName3 = columnName3;
            this.columnName4 = columnName4;
            this.columnName4 = columnName5;
        }
        public Table(string tableName, string columnName, string columnName1, string columnName2, string columnName3, string columnName4, string columnName5, string columnName6)
        {
            this.tableName = tableName;
            this.columnName = columnName;
            this.columnName1 = columnName1;
            this.columnName2 = columnName2;
            this.columnName3 = columnName3;
            this.columnName4 = columnName4;
            this.columnName5 = columnName5;
            this.columnName6 = columnName6;
        }
        
        

        public string TableName { get { return tableName; } }
        public string ColumnName { get { return columnName; } }
        public string ColumnName1 { get { return columnName1; } }
        public string ColumnName2 { get { return columnName2; } }
        public string ColumnName3 { get { return columnName3; } }
        public string ColumnName4 { get { return columnName4; } }
        public string ColumnName5 { get { return columnName5; } }
        public string ColumnName6 { get { return columnName6; } }


        //Создать таблицу
        public void CreateTable ()
        {
            DataBase dataBase = new DataBase();
            dataBase.CreateTable(TableName);
        }

        //Добавить столбец
        public virtual void AddColumn()
        {
            DataBase dataBase = new DataBase();
            dataBase.AddColumn(TableName, ColumnName);
        }

        //Добавить значение в ячейку столбца ColumnName
        public virtual void AddItem(string ItemName)
        {
            DataBase dataBase = new DataBase();
            dataBase.AddItem(TableName, ColumnName, ItemName);
        }

        //Удалить значение из ячейки столбца ColumnName
        public virtual void DelItem(string ItemName)
        {
            DataBase dataBase = new DataBase();
            dataBase.DelItem(TableName, ColumnName, ItemName);
        }

        //Извлечь все данные из таблицы TableName
        public DataTable SelectTable()
        {
            DataBase dataBase = new DataBase();
            return dataBase.SelectTable(TableName);
        }

        //Извлечь все данные из столбца ColumnName
        public DataTable SelectColumn()
        {
            DataBase dataBase = new DataBase();
            return dataBase.SelectColumn(TableName, ColumnName);
        }
    }
}
