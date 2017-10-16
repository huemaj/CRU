using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace DAO
{
    class DAOSQLite
    {
        private SQLiteConnection conn;

        public DAOSQLite()
        {
            conn = new SQLiteConnection("Data Source= ./databasepath/cru.db");
        }

    }
}
