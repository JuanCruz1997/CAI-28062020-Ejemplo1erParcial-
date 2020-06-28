using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Newtonsoft.Json;

namespace Datos
{
    public class TipoPrestamoMapper
    {
        public List<TipoPrestamo> TraerTodos()
        {
            string json = WebHelper.Get("api/v1/prestamotipo");
            List<TipoPrestamo> resultadoMapeo = MapList(json);
            return resultadoMapeo;
        }
        private List<TipoPrestamo> MapList(string jsonADeserializar)
        {
            List<TipoPrestamo> lstDeserializada = JsonConvert.DeserializeObject<List<TipoPrestamo>>(jsonADeserializar);
            return lstDeserializada;
        }
    }
}
