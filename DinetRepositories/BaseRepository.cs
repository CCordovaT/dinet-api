using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinetRepositories
{
    public interface BaseRepository<T> where T : class
    {
        List<T> ObtenerTodos();
        void Crear(T entity);
    }
}
