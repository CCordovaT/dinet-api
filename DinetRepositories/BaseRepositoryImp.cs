using DapperExtensions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dapper.SqlMapper;

namespace DinetRepositories
{
    public class BaseRepositoryImp<T> : BaseRepository<T> where T : class
    {
        protected string cadenaConexion;

        public BaseRepositoryImp()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["DBInventario"].ConnectionString;
        }

        public void Crear(T entity)
        {
            try
            {
                using (var conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Insert(entity);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<T> ObtenerTodos()
        {
            try
            {
                using (var conexion = new SqlConnection(cadenaConexion))
                {
                    return conexion.GetList<T>().ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
