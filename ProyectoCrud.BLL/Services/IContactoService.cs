using ProyectoCrud.DAL.Repositorio;
using ProyectoCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCrud.BLL.Services
{
    public interface IContactoService
    {
        Task<Contacto> ObtenerPorNombre(string nombre);
    }
}
