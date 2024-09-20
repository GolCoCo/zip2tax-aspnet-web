using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zip2TaxWebApp.Models
{
    public class Utils
    {
        //public static string MSSQL_SERVER_NAME = "Chester01.HarvestAmerican.net";
        //public static string MSSQL_DATABASE_NAME = "z2t_Accounts";
        //public static string MSSQL_USERNAME = "z2t_Reports";
        //public static string MSSQL_PASSWORD = "t45!sid32b";
        public static string MSSQL_SP = "crm_Notes_Count";
        public static bool MSSQL_TRUSTSERVER = true;

        public static string MSSQL_SERVER_NAME = "ADMINISTRATOR\\MYSQLEXPRESS";
        public static string MSSQL_DATABASE_NAME = "ws_bi_sql";
        public static string MSSQL_USERNAME = "user";
        public static string MSSQL_PASSWORD = "qwe";
    }
}