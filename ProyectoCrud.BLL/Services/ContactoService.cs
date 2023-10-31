using ProyectoCrud.DAL.Repositorio;
using ProyectoCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCrud.BLL.Services
{
    public class ContactoService : IContactoService
    {
        private readonly IGenericRepository<Contacto> _contactoRepositorio;

        public ContactoService(IGenericRepository<Contacto> contacto)
        {
            _contactoRepositorio = contacto;
        }

        public async Task<bool> Actualizar(Contacto model)
        {
            return await _contactoRepositorio.Actualizar(model); 
        }

        public async Task<bool> Eliminar(int id)
        {
            return await _contactoRepositorio.Eliminar(id);
        }

        public async Task<bool> Insertar(Contacto model)
        {
            return await _contactoRepositorio.Insertar(model);
        }

        public async Task<Contacto> Obtener(int id)
        {
            return await _contactoRepositorio.Obtener(id);
        }

        public async Task<IQueryable<Contacto>> ObtenerTodo()
        {
          
            return await _contactoRepositorio.ObtenerTodo();
        }

        public async Task<Contacto> ObtenerPorNombre(string nombre)
        {
            IQueryable<Contacto> queryContacto = await _contactoRepositorio.ObtenerTodo();
            Contacto contacto = queryContacto.Where(c => c.Nombre == nombre).FirstOrDefault();
            return contacto;
        }
    }
}
