using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [DataContract]
    public class Prestamo
    {
        private string _linea;
        private double _tna;
        private int _plazo;
        private double _monto;
        private string _usuario;
        private int _id;
        private double _cuotaCapital;
        private double _cuotaInteres;
        private double _cuotaTotal;
        public Prestamo(double monto,int plazo,double tna)
        {
            this._monto = monto;
            this._plazo = plazo;
            this._tna = tna;
            this._cuotaCapital = this._monto / this._plazo;
            this._cuotaInteres = this._cuotaCapital * (this._tna / 12 / 100);
            this._cuotaTotal = this._cuotaCapital + this._cuotaInteres;
        }
        [DataMember]
        public string Linea
        {
            set
            {
                this._linea = value;
            }
            get
            {
                return this._linea;
            }
        }
        [DataMember]
        public double TNA
        {
            set
            {
                this._tna = value;
            }
            get
            {
                return this._tna;
            }
        }
        [DataMember]
        public int Plazo
        {
            set
            {
                this._plazo = value;
            }
            get
            {
                return this._plazo;
            }
        }
        [DataMember]
        public double Monto
        {
            set
            {
                this._monto = value;
            }
            get
            {
                return this._monto;
            }
        }
        [DataMember]
        public int ID
        {
            set
            {
                this._id = value;
            }
            get
            {
                return this._id;
            }
        }
        public double CuotaCapital
        {
            set
            {
                this._cuotaCapital = value;
            }
            get
            {
                return this._cuotaCapital;
            }
        }
        public double CuotaInteres
        {
            set
            {
                this._cuotaInteres = value;
            }
            get
            {
                return this._cuotaInteres;
            }
        }
        public double CuotaTotal
        {
            set
            {
                this._cuotaTotal = value;
            }
            get
            {
                return this._cuotaTotal;
            }
        }
        public override string ToString()
        {
            return this._id.ToString() + ") " + this._linea + " - Monto: $" + this._monto + " - Cuota: $" + this._cuotaTotal;
        }
    }
}
