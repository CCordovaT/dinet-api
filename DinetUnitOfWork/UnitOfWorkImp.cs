using DinetModels;
using DinetRepositories;
using DinetRepositories.DBInventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinetUnitOfWork
{
    public class UnitOfWorkImp : UnitOfWork
    {
        public InventarioRepository Inventario => new InventarioRepositoryImp();
    }
}
