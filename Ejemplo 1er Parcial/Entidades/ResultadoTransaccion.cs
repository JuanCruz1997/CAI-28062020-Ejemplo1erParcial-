using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ResultadoTransaccion
    {
        private bool _isOk;
        private string _error;
        private int _id;
        public Boolean IsOk
        {
            set
            {
                this._isOk = value;
            }
            get
            {
                return this._isOk;
            }
        }
        public string Error
        {
            set
            {
                this._error = value;
            }
            get
            {
                return this._error;
            }
        }
        public int Id
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
    }
}
