using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    public class DbConfig
    {
        [Obsolete("This method depricated in next version", true)]
        public void ConnectToDataBase(string connectionString = "")
        {

        }

        public void ConnectToDb(string dbNaem = "", string serverName = "")
        {

        }
    }
}
