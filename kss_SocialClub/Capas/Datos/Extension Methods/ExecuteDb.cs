using System.Data.SQLite;

namespace kss_SocialClub.Capas.Datos.Extension_Methods
{
    public static class ExecuteDb
    {

        public static long LastID(string cnnString, string tablename)
        {
            using (SQLiteConnection cnn = new SQLiteConnection() { ConnectionString = cnnString })
            {
                cnn.Open();
                var tmpScalar = new SQLiteCommand($"SELECT MAX(id) FROM {tablename}", cnn).ExecuteScalar();
                if (tmpScalar.GetType().Name.Equals("DBNull"))
                    return 0;
                else
                    return (long)tmpScalar;
            }
        }
    }
}
