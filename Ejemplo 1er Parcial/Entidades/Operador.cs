using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operador
    {
        private List<Prestamo> _prestamos;
        private double _comision;
        private double _porcentajeComision;
        public Operador(List<Prestamo> prestamosDelOperador)
        {
            this._prestamos = prestamosDelOperador;
            this._porcentajeComision = 0.15;
        }
        public List<Prestamo> Prestamos
        {
            get
            {
                return this._prestamos;
            }
        }
        public double Comision
        {
            set
            {
                this._comision = value;
            }
            get
            {
                return this._comision;
            }
        }
        public double PorcentajeComision
        {
            get
            {
                return this._porcentajeComision;
            }
        }
    }
}
