using ksslib;
using System;
using System.Data;
using System.Data.SQLite;

namespace kss_DataObjects
{
    public static class connectionHelper
    {

        /// <summary>
        /// Comprobar conexion a Base de Datos
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="_connectionString"></param>
        /// <example>
        /// escombrobar = esComprobarConnection<MySqlConnection>(connectionstring); 
        /// </example>
        /// <returns></returns>
        public static bool esComprobarConnection<T>(string _connectionString) where T : IDbConnection, new()
        {
            try
            {
                using (var conn = new T())
                {
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.Connection.ConnectionString = _connectionString;
                        cmd.Connection.Open();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                clsUtilErrors.Manejador_errores(ex);
                return false;
            }
        }

        /// <summary>
        /// Devuelve una Datatable de una Conexion
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <example>
        /// dt = getDatatable<MySqlConnection>(query, connectionstring); // ~9800ms
        /// </example>
        /// <returns></returns>
        public static DataTable getDatatable<T>(string query, string _connectionString) where T : IDbConnection, new()
        {
            try
            {
                using (var conn = new T())
                {
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = query;
                        cmd.Connection.ConnectionString = _connectionString;
                        cmd.Connection.Open();
                        var table = new DataTable();
                        table.Load(cmd.ExecuteReader());
                        //MessageBox.Show("Tabla rows:" + table.Rows.Count.ToString());
                        return table;
                    }
                }
            }
            catch (Exception ex)
            {
                clsUtilErrors.Manejador_errores(ex);
                return null;
            }

        }

        public static SQLiteConnection getConnection(string connectionString)
        {
            var conn = new SQLiteConnection();
            using (var cmd = conn.CreateCommand())
            {
                try
                {
                    cmd.Connection.ConnectionString = connectionString;
                    cmd.Connection.Open();
                    cmd.Connection.Close();
                    return conn;
                }
                catch (Exception)
                {
                    return null;
                }
            }

        }

        /// <summary>
        /// Devuelve una Datatable d euna conexion
        /// </summary>
        /// <typeparam name="S"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <example>
        /// dt = Read2<MySqlConnection, MySqlDataAdapter>(query); // ~2300ms
        /// </example>
        /// <returns></returns>
        public static DataTable GetDataTable<S, T>(string query, string _connectionString) where S : IDbConnection, new()
                                                   where T : IDbDataAdapter, IDisposable, new()
        {
            try
            {
                using (var conn = new S())
                {
                    using (var da = new T())
                    {
                        using (da.SelectCommand = conn.CreateCommand())
                        {
                            da.SelectCommand.CommandText = query;
                            da.SelectCommand.Connection.ConnectionString = _connectionString;
                            DataSet ds = new DataSet(); //conn is opened by dataadapter
                            da.Fill(ds);
                            return ds.Tables[0];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsUtilErrors.Manejador_errores(ex);
                return null;
            }
        }
    }
}
