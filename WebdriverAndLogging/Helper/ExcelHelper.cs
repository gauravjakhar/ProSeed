using System;
using System.Data.OleDb;

namespace WebdriverAndLogging
{
    public class ExcelHelper
    {
        public static string[] ReturnLoginUser(int id)
        {
            string[] logindata = new string[2];
            string con =
  @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Testing\Data.xls;" +
  @"Extended Properties='Excel 4.0;HDR=Yes;'";
            try
            {
                using (OleDbConnection connection = new OleDbConnection(con))
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand("SELECT * FROM [Login$]", connection);
                    using (OleDbDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            if (Int32.Parse(dr[0].ToString()) == id)
                            {
                                logindata[0] = dr[1].ToString(); //uname
                                logindata[1] = dr[2].ToString(); //pwd
                                break;
                            }
                        }
                        return logindata;
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
