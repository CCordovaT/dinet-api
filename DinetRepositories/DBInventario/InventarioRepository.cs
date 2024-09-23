using DinetModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinetRepositories.DBInventario
{
    public interface InventarioRepository : BaseRepository<Inventario>
    {
        IEnumerable<Inventario> ObtenerPorFecha(DateTime fechaInicio, DateTime fechaFin, string tipoMovimiento, string nroDocumento);
    }
}
