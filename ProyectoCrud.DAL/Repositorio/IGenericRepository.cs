using ProyectoCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCrud.DAL.Repositorio
{
    public interface IGenericRepository<T> where T: class
    {
        Task<bool> Insertar(T modelo);

        Task<bool> Actualizar(T modelo);

        Task<T> Obtener(int id);

        Task<bool> Eliminar(int id);

        Task<IQueryable<T>> ObtenerTodo();
    }
}
