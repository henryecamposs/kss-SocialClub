using KSS_DataObjects.Capas.Datos.SQlite.Repository_Dapper;
using ksslib;
using System;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Linq;

namespace KSS_DataObjects.kss_SocialClub.Capas.Negocio
{
    public class adapterEntity<TEntity>
         where TEntity : class
    {
        internal readonly SQLiteConnection _dbConnection;
        public readonly CurrentRepository<TEntity> currentRepository;
        private string QuerySelect;
        private object ParameterQuerySelect;

        public List<TEntity> Rows { get; private set; }

        public adapterEntity(SQLiteConnection dbConnection, string id_campo = "ID", string querySelect = "", object parameterQuerySelect = null)
        {
            if (dbConnection != null)
            {
                if (!string.IsNullOrEmpty(dbConnection.ConnectionString))
                {
                    this._dbConnection = dbConnection;
                    currentRepository = new CurrentRepository<TEntity>(_dbConnection, id_campo);
                    currentRepository.statusRegistrosCambiado += CurrentRepository_statusRegistrosCambiado;
                }
                QuerySelect = querySelect;
                ParameterQuerySelect = parameterQuerySelect;
            }
            else
                kss_msjDelay.Show("No existe comunicación con la Base de Datos.");
        }



        /// <summary>
        /// Rellenar la base de Datos
        /// </summary>
        /// <returns></returns>
        public int fill()
        {
            try
            {
                //string qry = $"SELECT * FROM {typeof(Clientes).Name} WHERE esActivo = @esActivo";
                //object parameters = new { esActivo = 1 };
                if (string.IsNullOrEmpty(QuerySelect))
                    Rows = currentRepository.All().ToList();
                else
                    Rows = currentRepository.GetData(QuerySelect, !string.IsNullOrEmpty(QuerySelect) ? ParameterQuerySelect : null).ToList();

                return Rows.Count();
            }
            catch (Exception ex)
            {
                clsUtilErrors.Manejador_errores(ex);
                return 0;
            }
        }

        public List<TEntity> getData()
        {
            try
            {
                fill();
                return Rows;
            }
            catch (Exception ex)
            {
                clsUtilErrors.Manejador_errores(ex);
                return null;
            }
        }
        private void CurrentRepository_statusRegistrosCambiado(object sender, enuStatusRegistro e)
        {
            throw new NotImplementedException();
        }
    }
}
