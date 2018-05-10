using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; private set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connection, TimeSpan timeout)
        {
            if (connection == string.Empty || connection == null)
                throw new ArgumentException("Connection string is required.", connection);
             
            ConnectionString = connection;
            Timeout = timeout;
        }

        public abstract void OpenConection();

        public abstract void CloseConnection();
    }
}
