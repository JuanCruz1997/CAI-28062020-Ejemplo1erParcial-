namespace Forms
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbTiposPréstamo = new System.Windows.Forms.GroupBox();
            this.btnAlta = new System.Windows.Forms.Button();
            this.txtCuotaTotal = new System.Windows.Forms.TextBox();
            this.txtCuotaCapital = new System.Windows.Forms.TextBox();
            this.txtCuotaInteres = new System.Windows.Forms.TextBox();
            this.lblCuotaTotal = new System.Windows.Forms.Label();
            this.lblCuotaInteres = new System.Windows.Forms.Label();
            this.lblCuotaCapital = new System.Windows.Forms.Label();
            this.btnSimular = new System.Windows.Forms.Button();
            this.txtPlazo = new System.Windows.Forms.TextBox();
            this.txtTNA = new System.Windows.Forms.TextBox();
            this.txtLinea = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblPlazo = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblTNA = new System.Windows.Forms.Label();
            this.lblLinea = new System.Windows.Forms.Label();
            this.lstTiposPrestamo = new System.Windows.Forms.ListBox();
            this.gbPrestamosAlta = new System.Windows.Forms.GroupBox();
            this.txtComisionTotal = new System.Windows.Forms.TextBox();
            this.lblComisionTotal = new System.Windows.Forms.Label();
            this.lstPrestamos = new System.Windows.Forms.ListBox();
            this.gbTiposPréstamo.SuspendLayout();
            this.gbPrestamosAlta.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTiposPréstamo
            // 
            this.gbTiposPréstamo.Controls.Add(this.btnAlta);
            this.gbTiposPréstamo.Controls.Add(this.txtCuotaTotal);
            this.gbTiposPréstamo.Controls.Add(this.txtCuotaCapital);
            this.gbTiposPréstamo.Controls.Add(this.txtCuotaInteres);
            this.gbTiposPréstamo.Controls.Add(this.lblCuotaTotal);
            this.gbTiposPréstamo.Controls.Add(this.lblCuotaInteres);
            this.gbTiposPréstamo.Controls.Add(this.lblCuotaCapital);
            this.gbTiposPréstamo.Controls.Add(this.btnSimular);
            this.gbTiposPréstamo.Controls.Add(this.txtPlazo);
            this.gbTiposPréstamo.Controls.Add(this.txtTNA);
            this.gbTiposPréstamo.Controls.Add(this.txtLinea);
            this.gbTiposPréstamo.Controls.Add(this.txtMonto);
            this.gbTiposPréstamo.Controls.Add(this.lblPlazo);
            this.gbTiposPréstamo.Controls.Add(this.lblMonto);
            this.gbTiposPréstamo.Controls.Add(this.lblTNA);
            this.gbTiposPréstamo.Controls.Add(this.lblLinea);
            this.gbTiposPréstamo.Controls.Add(this.lstTiposPrestamo);
            this.gbTiposPréstamo.Location = new System.Drawing.Point(13, 13);
            this.gbTiposPréstamo.Name = "gbTiposPréstamo";
            this.gbTiposPréstamo.Size = new System.Drawing.Size(634, 567);
            this.gbTiposPréstamo.TabIndex = 0;
            this.gbTiposPréstamo.TabStop = false;
            this.gbTiposPréstamo.Text = "Tipos de préstamo";
            this.gbTiposPréstamo.Enter += new System.EventHandler(this.gbTiposPréstamo_Enter);
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(296, 510);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(331, 44);
            this.btnAlta.TabIndex = 16;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // txtCuotaTotal
            // 
            this.txtCuotaTotal.Location = new System.Drawing.Point(406, 465);
            this.txtCuotaTotal.Name = "txtCuotaTotal";
            this.txtCuotaTotal.ReadOnly = true;
            this.txtCuotaTotal.Size = new System.Drawing.Size(222, 22);
            this.txtCuotaTotal.TabIndex = 15;
            // 
            // txtCuotaCapital
            // 
            this.txtCuotaCapital.Location = new System.Drawing.Point(406, 378);
            this.txtCuotaCapital.Name = "txtCuotaCapital";
            this.txtCuotaCapital.ReadOnly = true;
            this.txtCuotaCapital.Size = new System.Drawing.Size(222, 22);
            this.txtCuotaCapital.TabIndex = 14;
            // 
            // txtCuotaInteres
            // 
            this.txtCuotaInteres.Location = new System.Drawing.Point(406, 421);
            this.txtCuotaInteres.Name = "txtCuotaInteres";
            this.txtCuotaInteres.ReadOnly = true;
            this.txtCuotaInteres.Size = new System.Drawing.Size(222, 22);
            this.txtCuotaInteres.TabIndex = 13;
            // 
            // lblCuotaTotal
            // 
            this.lblCuotaTotal.AutoSize = true;
            this.lblCuotaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuotaTotal.Location = new System.Drawing.Point(297, 470);
            this.lblCuotaTotal.Name = "lblCuotaTotal";
            this.lblCuotaTotal.Size = new System.Drawing.Size(87, 17);
            this.lblCuotaTotal.TabIndex = 12;
            this.lblCuotaTotal.Text = "Cuota total";
            // 
            // lblCuotaInteres
            // 
            this.lblCuotaInteres.AutoSize = true;
            this.lblCuotaInteres.Location = new System.Drawing.Point(298, 426);
            this.lblCuotaInteres.Name = "lblCuotaInteres";
            this.lblCuotaInteres.Size = new System.Drawing.Size(102, 17);
            this.lblCuotaInteres.TabIndex = 11;
            this.lblCuotaInteres.Text = "Cuota (interés)";
            // 
            // lblCuotaCapital
            // 
            this.lblCuotaCapital.AutoSize = true;
            this.lblCuotaCapital.Location = new System.Drawing.Point(297, 381);
            this.lblCuotaCapital.Name = "lblCuotaCapital";
            this.lblCuotaCapital.Size = new System.Drawing.Size(100, 17);
            this.lblCuotaCapital.TabIndex = 10;
            this.lblCuotaCapital.Text = "Couta (capital)";
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(297, 221);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(331, 44);
            this.btnSimular.TabIndex = 9;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // txtPlazo
            // 
            this.txtPlazo.Location = new System.Drawing.Point(351, 170);
            this.txtPlazo.Name = "txtPlazo";
            this.txtPlazo.Size = new System.Drawing.Size(277, 22);
            this.txtPlazo.TabIndex = 8;
            // 
            // txtTNA
            // 
            this.txtTNA.Location = new System.Drawing.Point(351, 76);
            this.txtTNA.Name = "txtTNA";
            this.txtTNA.ReadOnly = true;
            this.txtTNA.Size = new System.Drawing.Size(277, 22);
            this.txtTNA.TabIndex = 7;
            // 
            // txtLinea
            // 
            this.txtLinea.Location = new System.Drawing.Point(351, 22);
            this.txtLinea.Name = "txtLinea";
            this.txtLinea.ReadOnly = true;
            this.txtLinea.Size = new System.Drawing.Size(277, 22);
            this.txtLinea.TabIndex = 6;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(351, 127);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(277, 22);
            this.txtMonto.TabIndex = 5;
            // 
            // lblPlazo
            // 
            this.lblPlazo.AutoSize = true;
            this.lblPlazo.Location = new System.Drawing.Point(297, 170);
            this.lblPlazo.Name = "lblPlazo";
            this.lblPlazo.Size = new System.Drawing.Size(43, 17);
            this.lblPlazo.TabIndex = 4;
            this.lblPlazo.Text = "Plazo";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(297, 127);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(47, 17);
            this.lblMonto.TabIndex = 3;
            this.lblMonto.Text = "Monto";
            // 
            // lblTNA
            // 
            this.lblTNA.AutoSize = true;
            this.lblTNA.Location = new System.Drawing.Point(296, 76);
            this.lblTNA.Name = "lblTNA";
            this.lblTNA.Size = new System.Drawing.Size(36, 17);
            this.lblTNA.TabIndex = 2;
            this.lblTNA.Text = "TNA";
            // 
            // lblLinea
            // 
            this.lblLinea.AutoSize = true;
            this.lblLinea.Location = new System.Drawing.Point(297, 22);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(43, 17);
            this.lblLinea.TabIndex = 1;
            this.lblLinea.Text = "Línea";
            // 
            // lstTiposPrestamo
            // 
            this.lstTiposPrestamo.FormattingEnabled = true;
            this.lstTiposPrestamo.ItemHeight = 16;
            this.lstTiposPrestamo.Location = new System.Drawing.Point(7, 22);
            this.lstTiposPrestamo.Name = "lstTiposPrestamo";
            this.lstTiposPrestamo.Size = new System.Drawing.Size(283, 532);
            this.lstTiposPrestamo.TabIndex = 0;
            this.lstTiposPrestamo.SelectedIndexChanged += new System.EventHandler(this.lstTiposPrestamo_SelectedIndexChanged);
            // 
            // gbPrestamosAlta
            // 
            this.gbPrestamosAlta.Controls.Add(this.txtComisionTotal);
            this.gbPrestamosAlta.Controls.Add(this.lblComisionTotal);
            this.gbPrestamosAlta.Controls.Add(this.lstPrestamos);
            this.gbPrestamosAlta.Location = new System.Drawing.Point(654, 13);
            this.gbPrestamosAlta.Name = "gbPrestamosAlta";
            this.gbPrestamosAlta.Size = new System.Drawing.Size(439, 567);
            this.gbPrestamosAlta.TabIndex = 1;
            this.gbPrestamosAlta.TabStop = false;
            this.gbPrestamosAlta.Text = "Préstamos dados de alta";
            // 
            // txtComisionTotal
            // 
            this.txtComisionTotal.Location = new System.Drawing.Point(115, 510);
            this.txtComisionTotal.Name = "txtComisionTotal";
            this.txtComisionTotal.ReadOnly = true;
            this.txtComisionTotal.Size = new System.Drawing.Size(318, 22);
            this.txtComisionTotal.TabIndex = 2;
            // 
            // lblComisionTotal
            // 
            this.lblComisionTotal.AutoSize = true;
            this.lblComisionTotal.Location = new System.Drawing.Point(7, 510);
            this.lblComisionTotal.Name = "lblComisionTotal";
            this.lblComisionTotal.Size = new System.Drawing.Size(101, 17);
            this.lblComisionTotal.TabIndex = 1;
            this.lblComisionTotal.Text = "Comisión Total";
            // 
            // lstPrestamos
            // 
            this.lstPrestamos.FormattingEnabled = true;
            this.lstPrestamos.ItemHeight = 16;
            this.lstPrestamos.Location = new System.Drawing.Point(6, 22);
            this.lstPrestamos.Name = "lstPrestamos";
            this.lstPrestamos.Size = new System.Drawing.Size(427, 468);
            this.lstPrestamos.TabIndex = 0;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 592);
            this.Controls.Add(this.gbPrestamosAlta);
            this.Controls.Add(this.gbTiposPréstamo);
            this.Name = "frmPrincipal";
            this.Text = "Sistema Préstamos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.gbTiposPréstamo.ResumeLayout(false);
            this.gbTiposPréstamo.PerformLayout();
            this.gbPrestamosAlta.ResumeLayout(false);
            this.gbPrestamosAlta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTiposPréstamo;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.TextBox txtCuotaTotal;
        private System.Windows.Forms.TextBox txtCuotaCapital;
        private System.Windows.Forms.TextBox txtCuotaInteres;
        private System.Windows.Forms.Label lblCuotaTotal;
        private System.Windows.Forms.Label lblCuotaInteres;
        private System.Windows.Forms.Label lblCuotaCapital;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.TextBox txtPlazo;
        private System.Windows.Forms.TextBox txtTNA;
        private System.Windows.Forms.TextBox txtLinea;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblPlazo;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblTNA;
        private System.Windows.Forms.Label lblLinea;
        private System.Windows.Forms.ListBox lstTiposPrestamo;
        private System.Windows.Forms.GroupBox gbPrestamosAlta;
        private System.Windows.Forms.TextBox txtComisionTotal;
        private System.Windows.Forms.Label lblComisionTotal;
        private System.Windows.Forms.ListBox lstPrestamos;
    }
}

