using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProceedSolution.Data
{
    public class CommonDataAccess
    {
        //DbContext DataContext = new DbContext(Automation.edmx);
        List<object> listid = new List<object>();
        object obj = new object();
        SqlConnection conc = new SqlConnection();
        //var row = DataContext.MyTable.SingleOrDefault(r => r.ID == 0);
    }
}
