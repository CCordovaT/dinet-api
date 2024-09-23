using Dapper;
using DinetModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinetRepositories.DBInventario
{
    public class InventarioRepositoryImp : BaseRepositoryImp<Inventario>, InventarioRepository
    {
        public IEnumerable<Inventario> ObtenerPorFecha(DateTime fechaInicio, DateTime fechaFin, string tipoMovimiento, string nroDocumento)
        {
            try
            {
                using (var conexion = new SqlConnection(cadenaConexion))
                {
                    return conexion.Query<Inventario>("usp_ObtenerMovimientos", new
                    {
                        FechaInicio = fechaInicio,
                        FechaFin = fechaFin,
                        TipoMovimiento = tipoMovimiento,
                        NroDocumento = nroDocumento
                    }, commandType: System.Data.CommandType.StoredProcedure);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
