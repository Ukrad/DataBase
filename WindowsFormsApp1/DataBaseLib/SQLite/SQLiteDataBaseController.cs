using System.Data;
using System.Data.SQLite;

namespace DataBaseLib.SQLite;

internal class SQLiteDataBaseController
{
    // пока ее нет физически, адрес некорректный
    private string _connectionString = @"Data Source=c:\mydb.db;Version=3;";

    /// <summary>
    /// Возвращает виртуальную таблицу по SQL-запросу из БД Access
    /// </summary>
    /// <param name="query">SQL-запрос</param>
    /// <returns></returns>
    public DataTable GetDataTable(string query)
    {
        DataTable table = new DataTable();

        using (SQLiteConnection connection = new SQLiteConnection(query))
        {
            try
            {
                connection.Open();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);
                adapter.Fill(table);
            }
            catch
            {
                throw new Exception("Соединение не было установлено!");
            }
        }
        return table;
    }

    /// <summary>
    /// Для команд Delete, Insert, Update
    /// </summary>
    /// <param name="query"></param>
    public void ExecuteCommand(string query)
    {
        using (SQLiteConnection connection = new SQLiteConnection(query))
        {
            try
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.ExecuteNonQuery();
            }
            catch
            {
                throw new Exception("Соединение не было установлено!");
            }
        }
    }


}
