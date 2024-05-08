using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kss_DataObjects.kss_SocialClub.Setting
{
   public static class program
    {
        private static string BaseDatosSQLite= "kssSocialClub.db";
        //private static string appPath;
        //public static string appPathDbFile;
        private static string BaseDatosSQLite_ConnectionStringTemplate = "Data Source={0}{1};Version=3;";

        public static string generateConnectionString_Sqlite(string appPathDbFile,string database="")
        {
            return string.Format( BaseDatosSQLite_ConnectionStringTemplate,appPathDbFile,string.IsNullOrEmpty(database)? BaseDatosSQLite: database);
        }
    }
}
