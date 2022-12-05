using DataBaseLib.Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLib.Commands
{
    internal class Table2Commands : ITableEditorCommand
    {
        // ЕСЛИ нужна другая БД, просто меняем AccessDataBaseController
        // на нужную, например SQLiteDataBaseController
        // в следующей строке
        private AccessDataBaseController controller = new AccessDataBaseController();

        public void Select(string[] args)
        {

        }

        public void Insert(string[] args)
        {            
            string query = $"INSERT INTO [Колледж] " +
                    $"([Код колледжа], [Название колледжа], [Адрес колледжа]) " +
                    $"VALUES ({args[0]}, '{args[1]}','{args[2]}')";
            controller.ExecuteCommand(query);
        }

        public void Update(string[] args)
        {
            string query = @$"UPDATE [Колледж]
                    SET [Название колледжа] = '{args[1]}',[Адрес колледжа] = '{args[2]}'
                    WHERE [Код колледжа] = {args[0]}";
            controller.ExecuteCommand(query);
        }

        public void Delete(string[] args)
        {
            string query = $"DELETE FROM [Колледж] " +
                    $"WHERE [Код колледжа] = {args[0]}";
            controller.ExecuteCommand(query);
        }


    }
}
