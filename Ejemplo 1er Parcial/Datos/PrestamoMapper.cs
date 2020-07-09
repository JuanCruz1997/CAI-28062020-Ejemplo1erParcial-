using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Datos
{
    public class PrestamoMapper
    {
        public ResultadoTransaccion Insert(Prestamo prestamoNuevo)
        {
            NameValueCollection obj = ReverseMap(prestamoNuevo);
            string resultadoPost = WebHelper.Post("api/v1/prestamo/", obj);
            ResultadoTransaccion resultado = MapResultado(resultadoPost);
            return resultado;
        }
        private NameValueCollection ReverseMap(Prestamo prestamo)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("Linea", prestamo.Linea);
            n.Add("TNA", prestamo.TNA.ToString());
            n.Add("Monto", prestamo.Monto.ToString());
            n.Add("Plazo", prestamo.Plazo.ToString());
            n.Add("Usuario", ConfigurationManager.AppSettings["Legajo"]);
            n.Add("Cuota", prestamo.CuotaTotal.ToString());
            return n;
        }
        private ResultadoTransaccion MapResultado(string resultado)
        {
            ResultadoTransaccion resultadoDeserializado = JsonConvert.DeserializeObject<ResultadoTransaccion>(resultado);
            return resultadoDeserializado;
        }
        public List<Prestamo> TraerTodos()
        {
            string json = WebHelper.Get("api/v1/prestamo/");
            List<Prestamo> resultadoMapeo = MapList(json);
            return resultadoMapeo;
        }
        private List<Prestamo> MapList(string jsonADeserializar)
        {
            List<Prestamo> lstDeserializada = JsonConvert.DeserializeObject<List<Prestamo>>(jsonADeserializar);
            return lstDeserializada;
        }
    }
}
