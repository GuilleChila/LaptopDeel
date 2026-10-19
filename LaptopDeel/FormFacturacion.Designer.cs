namespace LaptopDeel
{
    partial class FormFacturacion
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTituloEncabezado = new Krypton.Toolkit.KryptonLabel();
            this.gbDatosCliente = new Krypton.Toolkit.KryptonGroupBox();
            this.lblClienteNombre = new Krypton.Toolkit.KryptonLabel();
            this.lblClienteDni = new Krypton.Toolkit.KryptonLabel();
            this.lblClienteIva = new Krypton.Toolkit.KryptonLabel();
            this.gbComprobante = new Krypton.Toolkit.KryptonGroupBox();
            this.lblTipoComprobante = new Krypton.Toolkit.KryptonLabel();
            this.cmbTipoFactura = new Krypton.Toolkit.KryptonComboBox();
            this.lblFechaEmision = new Krypton.Toolkit.KryptonLabel();
            this.dgvDetalleFactura = new Krypton.Toolkit.KryptonDataGridView();
            this.gbDesgloseTotales = new Krypton.Toolkit.KryptonGroupBox();
            this.lblSubtotalNeto = new Krypton.Toolkit.KryptonLabel();
            this.lblIva21 = new Krypton.Toolkit.KryptonLabel();
            this.lblExento = new Krypton.Toolkit.KryptonLabel();
            this.lblTotalPagar = new Krypton.Toolkit.KryptonLabel();
            this.gbPago = new Krypton.Toolkit.KryptonGroupBox();
            this.lblMetodoPago = new Krypton.Toolkit.KryptonLabel();
            this.cmbMetodoPago = new Krypton.Toolkit.KryptonComboBox();
            this.lblMontoAbonado = new Krypton.Toolkit.KryptonLabel();
            this.txtMontoAbonado = new Krypton.Toolkit.KryptonTextBox();
            this.lblVuelto = new Krypton.Toolkit.KryptonLabel();
            this.btnConfirmarFactura = new Krypton.Toolkit.KryptonButton();
            this.btnCancelar = new Krypton.Toolkit.KryptonButton();

            ((System.ComponentModel.ISupportInitialize)(this.gbDatosCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbDatosCliente.Panel)).BeginInit();
            this.gbDatosCliente.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbComprobante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbComprobante.Panel)).BeginInit();
            this.gbComprobante.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbDesgloseTotales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbDesgloseTotales.Panel)).BeginInit();
            this.gbDesgloseTotales.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbPago.Panel)).BeginInit();
            this.gbPago.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMetodoPago)).BeginInit();
            this.SuspendLayout();

            // Encabezado
            this.lblTituloEncabezado.Location = new System.Drawing.Point(20, 15);
            this.lblTituloEncabezado.Name = "lblTituloEncabezado";
            this.lblTituloEncabezado.Size = new System.Drawing.Size(350, 30);
            this.lblTituloEncabezado.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTituloEncabezado.Values.Text = "🧾 EMISIÓN DE FACTURA Y COBRO";

            // GroupBox Datos Cliente
            this.gbDatosCliente.Location = new System.Drawing.Point(20, 55);
            this.gbDatosCliente.Name = "gbDatosCliente";
            this.gbDatosCliente.Size = new System.Drawing.Size(430, 110);
            this.gbDatosCliente.Values.Heading = "Información del Cliente";
            this.gbDatosCliente.Panel.Controls.Add(this.lblClienteNombre);
            this.gbDatosCliente.Panel.Controls.Add(this.lblClienteDni);
            this.gbDatosCliente.Panel.Controls.Add(this.lblClienteIva);

            this.lblClienteNombre.Location = new System.Drawing.Point(10, 5);
            this.lblClienteNombre.Values.Text = "Cliente: --";
            this.lblClienteNombre.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);

            this.lblClienteDni.Location = new System.Drawing.Point(10, 30);
            this.lblClienteDni.Values.Text = "DNI / CUIT: --";

            this.lblClienteIva.Location = new System.Drawing.Point(10, 55);
            this.lblClienteIva.Values.Text = "Condición IVA: --";

            // GroupBox Comprobante
            this.gbComprobante.Location = new System.Drawing.Point(460, 55);
            this.gbComprobante.Name = "gbComprobante";
            this.gbComprobante.Size = new System.Drawing.Size(320, 110);
            this.gbComprobante.Values.Heading = "Detalles Fiscales";
            this.gbComprobante.Panel.Controls.Add(this.lblTipoComprobante);
            this.gbComprobante.Panel.Controls.Add(this.cmbTipoFactura);
            this.gbComprobante.Panel.Controls.Add(this.lblFechaEmision);

            this.lblTipoComprobante.Location = new System.Drawing.Point(10, 8);
            this.lblTipoComprobante.Values.Text = "Tipo:";

            this.cmbTipoFactura.Location = new System.Drawing.Point(55, 5);
            this.cmbTipoFactura.Name = "cmbTipoFactura";
            this.cmbTipoFactura.Size = new System.Drawing.Size(240, 28);
            this.cmbTipoFactura.SelectedIndexChanged += new System.EventHandler(this.cmbTipoFactura_SelectedIndexChanged);

            this.lblFechaEmision.Location = new System.Drawing.Point(10, 45);
            this.lblFechaEmision.Values.Text = "Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            // DataGridView Detalle
            this.dgvDetalleFactura.Location = new System.Drawing.Point(20, 175);
            this.dgvDetalleFactura.Name = "dgvDetalleFactura";
            this.dgvDetalleFactura.Size = new System.Drawing.Size(760, 180);

            // GroupBox Desglose Totales
            this.gbDesgloseTotales.Location = new System.Drawing.Point(460, 365);
            this.gbDesgloseTotales.Name = "gbDesgloseTotales";
            this.gbDesgloseTotales.Size = new System.Drawing.Size(320, 150);
            this.gbDesgloseTotales.Values.Heading = "Resumen Impositivo";
            this.gbDesgloseTotales.Panel.Controls.Add(this.lblSubtotalNeto);
            this.gbDesgloseTotales.Panel.Controls.Add(this.lblIva21);
            this.gbDesgloseTotales.Panel.Controls.Add(this.lblExento);
            this.gbDesgloseTotales.Panel.Controls.Add(this.lblTotalPagar);

            this.lblSubtotalNeto.Location = new System.Drawing.Point(10, 5);
            this.lblSubtotalNeto.Values.Text = "Subtotal Neto: $0.00";

            this.lblIva21.Location = new System.Drawing.Point(10, 28);
            this.lblIva21.Values.Text = "IVA (21%): $0.00";

            this.lblExento.Location = new System.Drawing.Point(10, 51);
            this.lblExento.Values.Text = "Libre Impuesto: $0.00";

            this.lblTotalPagar.Location = new System.Drawing.Point(10, 80);
            this.lblTotalPagar.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalPagar.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblTotalPagar.Values.Text = "TOTAL: $0.00";

            // GroupBox Medios de Pago
            this.gbPago.Location = new System.Drawing.Point(20, 365);
            this.gbPago.Name = "gbPago";
            this.gbPago.Size = new System.Drawing.Size(430, 150);
            this.gbPago.Values.Heading = "Procesamiento de Pago";
            this.gbPago.Panel.Controls.Add(this.lblMetodoPago);
            this.gbPago.Panel.Controls.Add(this.cmbMetodoPago);
            this.gbPago.Panel.Controls.Add(this.lblMontoAbonado);
            this.gbPago.Panel.Controls.Add(this.txtMontoAbonado);
            this.gbPago.Panel.Controls.Add(this.lblVuelto);

            this.lblMetodoPago.Location = new System.Drawing.Point(10, 10);
            this.lblMetodoPago.Values.Text = "Medio Pago:";

            this.cmbMetodoPago.Location = new System.Drawing.Point(110, 8);
            this.cmbMetodoPago.Name = "cmbMetodoPago";
            this.cmbMetodoPago.Size = new System.Drawing.Size(290, 28);
            this.cmbMetodoPago.SelectedIndexChanged += new System.EventHandler(this.cmbMetodoPago_SelectedIndexChanged);

            this.lblMontoAbonado.Location = new System.Drawing.Point(10, 48);
            this.lblMontoAbonado.Values.Text = "Abona con ($):";

            this.txtMontoAbonado.Location = new System.Drawing.Point(110, 45);
            this.txtMontoAbonado.Name = "txtMontoAbonado";
            this.txtMontoAbonado.Size = new System.Drawing.Size(290, 28);
            this.txtMontoAbonado.TextChanged += new System.EventHandler(this.txtMontoAbonado_TextChanged);

            this.lblVuelto.Location = new System.Drawing.Point(10, 85);
            this.lblVuelto.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblVuelto.Values.Text = "Vuelto: $0.00";

            // Botones Finales
            this.btnConfirmarFactura.Location = new System.Drawing.Point(460, 525);
            this.btnConfirmarFactura.Name = "btnConfirmarFactura";
            this.btnConfirmarFactura.Size = new System.Drawing.Size(320, 45);
            this.btnConfirmarFactura.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(16, 185, 129);
            this.btnConfirmarFactura.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(16, 185, 129);
            this.btnConfirmarFactura.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnConfirmarFactura.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnConfirmarFactura.Values.Text = "💳 Confirmar y Emitir Factura";
            this.btnConfirmarFactura.Click += new System.EventHandler(this.btnConfirmarFactura_Click);

            this.btnCancelar.Location = new System.Drawing.Point(20, 525);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(180, 45);
            this.btnCancelar.Values.Text = "❌ Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            // FormFacturacion
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 585);
            this.Controls.Add(this.lblTituloEncabezado);
            this.Controls.Add(this.gbDatosCliente);
            this.Controls.Add(this.gbComprobante);
            this.Controls.Add(this.dgvDetalleFactura);
            this.Controls.Add(this.gbDesgloseTotales);
            this.Controls.Add(this.gbPago);
            this.Controls.Add(this.btnConfirmarFactura);
            this.Controls.Add(this.btnCancelar);

            this.Name = "FormFacturacion";
            this.Text = "Módulo de Facturación y Cobro - LaptopDeel";

            ((System.ComponentModel.ISupportInitialize)(this.gbDatosCliente.Panel)).EndInit();
            this.gbDatosCliente.Panel.ResumeLayout(false);
            this.gbDatosCliente.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbDatosCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbComprobante.Panel)).EndInit();
            this.gbComprobante.Panel.ResumeLayout(false);
            this.gbComprobante.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbComprobante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbDesgloseTotales.Panel)).EndInit();
            this.gbDesgloseTotales.Panel.ResumeLayout(false);
            this.gbDesgloseTotales.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbDesgloseTotales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbPago.Panel)).EndInit();
            this.gbPago.Panel.ResumeLayout(false);
            this.gbPago.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMetodoPago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonLabel lblTituloEncabezado;
        private Krypton.Toolkit.KryptonGroupBox gbDatosCliente;
        private Krypton.Toolkit.KryptonLabel lblClienteNombre;
        private Krypton.Toolkit.KryptonLabel lblClienteDni;
        private Krypton.Toolkit.KryptonLabel lblClienteIva;
        private Krypton.Toolkit.KryptonGroupBox gbComprobante;
        private Krypton.Toolkit.KryptonLabel lblTipoComprobante;
        private Krypton.Toolkit.KryptonComboBox cmbTipoFactura;
        private Krypton.Toolkit.KryptonLabel lblFechaEmision;
        private Krypton.Toolkit.KryptonDataGridView dgvDetalleFactura;
        private Krypton.Toolkit.KryptonGroupBox gbDesgloseTotales;
        private Krypton.Toolkit.KryptonLabel lblSubtotalNeto;
        private Krypton.Toolkit.KryptonLabel lblIva21;
        private Krypton.Toolkit.KryptonLabel lblExento;
        private Krypton.Toolkit.KryptonLabel lblTotalPagar;
        private Krypton.Toolkit.KryptonGroupBox gbPago;
        private Krypton.Toolkit.KryptonLabel lblMetodoPago;
        private Krypton.Toolkit.KryptonComboBox cmbMetodoPago;
        private Krypton.Toolkit.KryptonLabel lblMontoAbonado;
        private Krypton.Toolkit.KryptonTextBox txtMontoAbonado;
        private Krypton.Toolkit.KryptonLabel lblVuelto;
        private Krypton.Toolkit.KryptonButton btnConfirmarFactura;
        private Krypton.Toolkit.KryptonButton btnCancelar;
    }
}