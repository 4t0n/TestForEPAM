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
        public Table(string tableName, string columnName, string columnName1): this(tableName,columnName)
        {            
            this.columnName1 = columnName1;
        }
        public Table(string tableName, string columnName, string columnName1, string columnName2): this(tableName,columnName,columnName1)
        {            
            this.columnName2 = columnName2;
        }
        public Table(string tableName, string columnName, string columnName1, string columnName2, string columnName3):this(tableName,columnName,columnName1,columnName2)
        {            
            this.columnName3 = columnName3;
        }
        public Table(string tableName, string columnName, string columnName1, string columnName2, string columnName3, string columnName4):this(tableName,columnName,columnName1,columnName2,columnName3)
        {            
            this.columnName4 = columnName4;
        }
        public Table(string tableName, string columnName, string columnName1, string columnName2, string columnName3, string columnName4, string columnName5): this(tableName, columnName, columnName1, columnName2, columnName3,columnName4)
        {            
            this.columnName5 = columnName5;
        }
        public Table(string tableName, string columnName, string columnName1, string columnName2, string columnName3, string columnName4, string columnName5, string columnName6) : this(tableName, columnName, columnName1, columnName2, columnName3, columnName4,columnName5)
        {            
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
            DataBase.CreateTable(TableName);
        }

        //Добавить столбец
        public void AddColumn(params string[] ColumnName)
        {            
            DataBase.AddColumn(TableName, ColumnName);
        }

        //Добавить значение в ячейку столбца ColumnName
        public void AddItem(string ItemName, params string[] ColumnName)
        {            
            DataBase.AddItem(TableName, ItemName, ColumnName);
        }

        //Удалить строку, где значение столбца ColumnName равно ItemName
        public void DelItem(string ItemName, string ColumnName)
        {            
            DataBase.DelItem(TableName, ItemName, ColumnName);
        }

        //Извлечь все данные из таблицы TableName
        //public DataTable SelectTable()
        //{            
        //    return DataBase.SelectTable(TableName);
        //}

        //Извлечь все данные из таблицы TableName, где столбец ColumnName имеет значение cellValue
        public DataTable SelectTableWhere(string columnValue, string cellValue)
        {            
            return DataBase.SelectTableWhere(TableName,columnValue,cellValue);
        }

        //Извлечь все данные из столбца ColumnName
        public DataTable SelectColumn(string columnName)
        {            
            return DataBase.SelectColumn(TableName, columnName);
        }

        //Создать триггеры
        public void CreateTrigger (string addText, string delText)
        {
            DataBase.CreateTrigger(TableName, addText, delText);
        }
    }
}
