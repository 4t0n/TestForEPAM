using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackingSystemWithSQlite
{
    class Task:Table
    {
        public Task():base("TaskList","Task","Project","Theme","Type","Priority","User","Description")
        {

        }

        //public override void AddItem(string ItemName)
        //{
        //    DataBase dataBase = new DataBase();
        //    dataBase.AddItem(TableName, ItemName, ColumnName, ColumnName1, ColumnName2, ColumnName3, ColumnName4, ColumnName5, ColumnName6);            
        //}

        //public override void AddColumn()
        //{
        //    DataBase dataBase = new DataBase();
        //    dataBase.AddColumn(TableName, ColumnName, ColumnName1, ColumnName2, ColumnName3, ColumnName4, ColumnName5, ColumnName6);
        //}

        //public void DelTask (string columnName, string itemName)
        //{
        //    DataBase dataBase = new DataBase();
        //    dataBase.DelItem(TableName, columnName, itemName);
        //}
        /*
        //Показать список проектов
        public void ShowTasks(DataGridView dgvViewer)
        {
            string sqlQuery;
            DataTable dTable = new DataTable();
            DataGridViewTextBoxColumn dgvIdTask = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn dgvTask = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn dgvProject = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn dgvTheme = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn dgvType = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn dgvPriority = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn dgvUser = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn dgvDescription = new DataGridViewTextBoxColumn();
            try
            {
                sqlQuery = "SELECT * FROM TaskList";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, dbConnect);
                adapter.Fill(dTable);
                dgvViewer.Rows.Clear();                
                dgvViewer.Columns.Clear();
                dgvIdTask.Name = "idTask";
                dgvIdTask.HeaderText = "Порядковый номер";
                dgvTask.Name = "Task";
                dgvTask.HeaderText = "Название задачи";
                dgvProject.Name = "Project";
                dgvProject.HeaderText = "Проект";
                dgvTheme.Name = "Theme";
                dgvTheme.HeaderText = "Тема";
                dgvType.Name = "Type";
                dgvType.HeaderText = "Тип";
                dgvPriority.Name = "Priority";
                dgvPriority.HeaderText = "Приоритет";
                dgvUser.Name = "User";
                dgvUser.HeaderText = "Исполнитель";
                dgvDescription.Name = "Description";
                dgvDescription.HeaderText = "Описание";
                dgvIdTask.Visible = false;
                dgvViewer.Columns.Add(dgvIdTask);
                dgvViewer.Columns.Add(dgvTask);
                dgvViewer.Columns.Add(dgvProject);
                dgvViewer.Columns.Add(dgvTheme);
                dgvViewer.Columns.Add(dgvType);
                dgvViewer.Columns.Add(dgvPriority);
                dgvViewer.Columns.Add(dgvUser);
                dgvViewer.Columns.Add(dgvDescription);
                dgvViewer.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvViewer.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                for (int i = 0; i < dTable.Rows.Count; i++)
                    dgvViewer.Rows.Add(dTable.Rows[i].ItemArray);
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }*/

        //Показать список задач в выбранном проекте
        /*public void ShowTasksInProject(DataGridView dgvViewer, string cbTasksInProject)
        {
            string sqlQuery;
            DataTable dTable = new DataTable();
            DataGridViewTextBoxColumn dgvIdTask = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn dgvTask = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn dgvProject = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn dgvTheme = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn dgvType = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn dgvPriority = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn dgvUser = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn dgvDescription = new DataGridViewTextBoxColumn();
            try
            {
                sqlQuery = "SELECT * FROM TaskList WHERE Project = '"+cbTasksInProject+"'";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, dbConnect);
                adapter.Fill(dTable);
                dgvViewer.Rows.Clear();
                dgvViewer.Columns.Clear();
                dgvIdTask.Name = "idTask";
                dgvIdTask.HeaderText = "Порядковый номер";
                dgvTask.Name = "Task";
                dgvTask.HeaderText = "Название задачи";
                dgvProject.Name = "Project";
                dgvProject.HeaderText = "Проект";
                dgvTheme.Name = "Theme";
                dgvTheme.HeaderText = "Тема";
                dgvType.Name = "Type";
                dgvType.HeaderText = "Тип";
                dgvPriority.Name = "Priority";
                dgvPriority.HeaderText = "Приоритет";
                dgvUser.Name = "User";
                dgvUser.HeaderText = "Исполнитель";
                dgvDescription.Name = "Description";
                dgvDescription.HeaderText = "Описание";
                dgvIdTask.Visible = false;
                dgvViewer.Columns.Add(dgvIdTask);
                dgvViewer.Columns.Add(dgvTask);
                dgvViewer.Columns.Add(dgvProject);
                dgvViewer.Columns.Add(dgvTheme);
                dgvViewer.Columns.Add(dgvType);
                dgvViewer.Columns.Add(dgvPriority);
                dgvViewer.Columns.Add(dgvUser);
                dgvViewer.Columns.Add(dgvDescription);
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

        //Показать список задач на исполнителе
        public void ShowTasksOnUser(DataGridView dgvViewer, string cbTasksOnUser)
        {
            string sqlQuery;
            DataTable dTable = new DataTable();
            DataGridViewTextBoxColumn dgvIdTask = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn dgvTask = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn dgvProject = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn dgvTheme = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn dgvType = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn dgvPriority = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn dgvUser = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn dgvDescription = new DataGridViewTextBoxColumn();
            try
            {
                sqlQuery = "SELECT * FROM TaskList WHERE User = '" + cbTasksOnUser + "'";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, dbConnect);
                adapter.Fill(dTable);
                dgvViewer.Rows.Clear();
                dgvViewer.Columns.Clear();
                dgvIdTask.Name = "idTask";
                dgvIdTask.HeaderText = "Порядковый номер";
                dgvTask.Name = "Task";
                dgvTask.HeaderText = "Название задачи";
                dgvProject.Name = "Project";
                dgvProject.HeaderText = "Проект";
                dgvTheme.Name = "Theme";
                dgvTheme.HeaderText = "Тема";
                dgvType.Name = "Type";
                dgvType.HeaderText = "Тип";
                dgvPriority.Name = "Priority";
                dgvPriority.HeaderText = "Приоритет";
                dgvUser.Name = "User";
                dgvUser.HeaderText = "Исполнитель";
                dgvDescription.Name = "Description";
                dgvDescription.HeaderText = "Описание";
                dgvIdTask.Visible = false;
                dgvViewer.Columns.Add(dgvIdTask);
                dgvViewer.Columns.Add(dgvTask);
                dgvViewer.Columns.Add(dgvProject);
                dgvViewer.Columns.Add(dgvTheme);
                dgvViewer.Columns.Add(dgvType);
                dgvViewer.Columns.Add(dgvPriority);
                dgvViewer.Columns.Add(dgvUser);
                dgvViewer.Columns.Add(dgvDescription);
                dgvViewer.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvViewer.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                for (int i = 0; i < dTable.Rows.Count; i++)
                    dgvViewer.Rows.Add(dTable.Rows[i].ItemArray);
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }*/
    }
}
