using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackingSystemWithSQlite
{
    class Table
    {
        private string tableName;
        private string columnName;

        public Table (string tableName, string columnName)
        {
            this.tableName = tableName;
            this.columnName = columnName;
        }

        public string TableName { get { return tableName; } }
        public string ColumnName { get { return columnName; } }



        //Добавить значение в ячейку столбца ColumnName
        public void AddItem(string ItemName)
        {
            DataBase dataBase = new DataBase();
            dataBase.AddItem(TableName, ColumnName, ItemName);
        }

        //Удалить значение из ячейки столбца ColumnName
        public void DelItem(string ItemName)
        {
            DataBase dataBase = new DataBase();
            dataBase.DelItem(TableName, ColumnName, ItemName);
        }

        //Извлечь все данные из таблицы TableName
        public DataTable ShowTable()
        {
            DataBase dataBase = new DataBase();
            return dataBase.SelectTable(TableName);
        }
    }
}
