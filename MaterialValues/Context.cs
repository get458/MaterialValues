using MaterialValues.Model;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Data.Entity;


namespace MaterialValues
{
    public class Context : System.Data.Entity.DbContext
    {
        public Context() : base("DbConnection")
        { }


        public System.Data.Entity.DbSet<Value> values { get; set; }
        public System.Data.Entity.DbSet<Supplier> suppliers { get; set; }

    }
}
