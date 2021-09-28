using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD.UI.Data
{
    public class SqlConfiguration
    {

        public string ConnectionString { get; set; }
        public SqlConfiguration(string connectionString) => ConnectionString = connectionString;

    }
}
