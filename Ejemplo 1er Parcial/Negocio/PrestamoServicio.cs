using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class PrestamoServicio
    {
        private PrestamoMapper mapper;
        public PrestamoServicio()
        {
            mapper = new PrestamoMapper();
        }
        public double ObtenerCoutaCapital(double monto,int plazo)
        {
            double cuotaCapital = monto / plazo;
            return cuotaCapital;
        }
        public double ObtenerCuotaInteres(double monto,int plazo,double tna)
        {
            double cuotaInteres = ObtenerCoutaCapital(monto, plazo) * (tna / 12 / 100);
            return cuotaInteres;
        }
        public double ObtenerCuotaTotal(double monto, int plazo,double tna)
        {
            double cuotaTotal = ObtenerCoutaCapital(monto, plazo) + ObtenerCuotaInteres(monto, plazo, tna);
            return cuotaTotal;
        }
        public int AltaPrestamo(string linea,double tna,int plazo,double monto)
        {
            Prestamo prestamoNuevo = new Prestamo(monto, plazo, tna);
            prestamoNuevo.Linea = linea;
            ResultadoTransaccion resultado = mapper.Insert(prestamoNuevo);
            if (resultado.IsOk)
            {
                return resultado.Id;
            }
            else
            {
                throw new Exception("Hubo un error en la petición al servidor. Detalle:" + resultado.Error);
            }
        }
        public List<Prestamo> TraerPrestamos()
        {
            List<Prestamo> prestamos = mapper.TraerTodos();
            return prestamos;
        }
        public double ObtenerPorcentajeComision()
        {
            double comision = 0;
            Operador operador = new Operador(mapper.TraerTodos());
            foreach(Prestamo p in operador.Prestamos)
            {
                comision += p.CuotaInteres * operador.PorcentajeComision;
            }
            return comision;
        }
    }
}
