using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public class LineasPrestamo
    {
        private TipoPrestamoMapper mapper;
        public LineasPrestamo()
        {
            mapper = new TipoPrestamoMapper();
        }
        public List<TipoPrestamo> TraerLineasPrestamo()
        {
            List<TipoPrestamo> listaLineasPrestamo = mapper.TraerTodos();
            return listaLineasPrestamo;
        }
    }
}
