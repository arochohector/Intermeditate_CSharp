using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connection, TimeSpan timeout) : base(connection, timeout)
        {
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Closing SQL Database Connection");
        }

        public override void OpenConection()
        {
            var startTime = DateTime.Now;
            Console.WriteLine("Estableshing connection to SQL Database");
        }
    }
}
