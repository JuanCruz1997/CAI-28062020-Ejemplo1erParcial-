using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;

namespace Forms
{
    public partial class frmPrincipal : Form
    {
        private LineasPrestamo _lineasServicio;
        private PrestamoServicio _prestamoServicio;
        public frmPrincipal(LineasPrestamo ls,PrestamoServicio ps)
        {
            this._lineasServicio = ls;
            this._prestamoServicio = ps;
            InitializeComponent();
        }
        #region Métodos
        private void CargarTiposPrestamo(List<TipoPrestamo> listaLineasPrestamo)
        {
            lstTiposPrestamo.DataSource = null;
            lstTiposPrestamo.DataSource = listaLineasPrestamo;
        }
        private void CambiarTxt(TipoPrestamo tipoPrestamoElegido)
        {
            txtLinea.Text = tipoPrestamoElegido.Linea;
            txtTNA.Text = tipoPrestamoElegido.TNA.ToString();
        }
        private Boolean ValidarCampos()
        {
            bool valido = true;
            string msg = string.Empty;
            if (ValidacionHelper.ValidarDouble(txtMonto.Text) == -1 || ValidacionHelper.ValidarInt(txtPlazo.Text) == -1)
            {
                msg = "Debe ingresar valores válidos en los campos Monto y Plazo.";
            }
            if (msg != string.Empty)
            {
                valido = false;
                MessageBox.Show(msg);
            }
            return valido;
        }
        private void CargarListaPrestamos(List<Prestamo> prestamos)
        {
            lstPrestamos.DataSource = null;
            lstPrestamos.DataSource = prestamos;
            CalcularComisionOperador();
        }
        private void CalcularComisionOperador()
        {
            txtComisionTotal.Text = this._prestamoServicio.ObtenerPorcentajeComision().ToString();
        }
        #endregion
        #region Eventos
        private void lstTiposPrestamo_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoPrestamo seleccionado = (TipoPrestamo)lstTiposPrestamo.SelectedItem;
            if (seleccionado != null)
            {
                CambiarTxt(seleccionado);
            }
        }

        private void gbTiposPréstamo_Enter(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CargarTiposPrestamo(this._lineasServicio.TraerLineasPrestamo());
            CargarListaPrestamos(this._prestamoServicio.TraerPrestamos());
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    double monto = Convert.ToDouble(txtMonto.Text);
                    int plazo = Convert.ToInt32(txtPlazo.Text);
                    double tna = Convert.ToDouble(txtTNA.Text);
                    txtCuotaCapital.Text = "$ " + this._prestamoServicio.ObtenerCoutaCapital(monto,plazo).ToString();
                    txtCuotaInteres.Text = "$ " + this._prestamoServicio.ObtenerCuotaInteres(monto, plazo, tna).ToString();
                    txtCuotaTotal.Text = "$ " + this._prestamoServicio.ObtenerCuotaTotal(monto, plazo, tna).ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error.\n" + ex.Message);
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    double monto = Convert.ToDouble(txtMonto.Text);
                    int plazo = Convert.ToInt32(txtPlazo.Text);
                    double tna = Convert.ToDouble(txtTNA.Text);
                    this._prestamoServicio.AltaPrestamo(txtLinea.Text, tna, plazo, monto);
                    MessageBox.Show("El préstamo se dio de alta exitosamente.");
                    CargarListaPrestamos(this._prestamoServicio.TraerPrestamos());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error.\n" + ex.Message);
            }
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
