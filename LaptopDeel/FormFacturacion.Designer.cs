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
            lblTituloEncabezado = new Krypton.Toolkit.KryptonLabel();
            gbDatosCliente = new Krypton.Toolkit.KryptonGroupBox();
            lblClienteNombre = new Krypton.Toolkit.KryptonLabel();
            lblClienteDni = new Krypton.Toolkit.KryptonLabel();
            lblClienteIva = new Krypton.Toolkit.KryptonLabel();
            gbComprobante = new Krypton.Toolkit.KryptonGroupBox();
            lblTipoComprobante = new Krypton.Toolkit.KryptonLabel();
            cmbTipoFactura = new Krypton.Toolkit.KryptonComboBox();
            lblFechaEmision = new Krypton.Toolkit.KryptonLabel();
            dgvDetalleFactura = new Krypton.Toolkit.KryptonDataGridView();
            gbDesgloseTotales = new Krypton.Toolkit.KryptonGroupBox();
            lblSubtotalNeto = new Krypton.Toolkit.KryptonLabel();
            lblIva21 = new Krypton.Toolkit.KryptonLabel();
            lblExento = new Krypton.Toolkit.KryptonLabel();
            lblTotalPagar = new Krypton.Toolkit.KryptonLabel();
            gbPago = new Krypton.Toolkit.KryptonGroupBox();
            lblMetodoPago = new Krypton.Toolkit.KryptonLabel();
            cmbMetodoPago = new Krypton.Toolkit.KryptonComboBox();
            lblMontoAbonado = new Krypton.Toolkit.KryptonLabel();
            txtMontoAbonado = new Krypton.Toolkit.KryptonTextBox();
            lblVuelto = new Krypton.Toolkit.KryptonLabel();
            btnConfirmarFactura = new Krypton.Toolkit.KryptonButton();
            btnCancelar = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)gbDatosCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gbDatosCliente.Panel).BeginInit();
            gbDatosCliente.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gbComprobante).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gbComprobante.Panel).BeginInit();
            gbComprobante.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbTipoFactura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleFactura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gbDesgloseTotales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gbDesgloseTotales.Panel).BeginInit();
            gbDesgloseTotales.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gbPago).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gbPago.Panel).BeginInit();
            gbPago.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbMetodoPago).BeginInit();
            SuspendLayout();
            // 
            // lblTituloEncabezado
            // 
            lblTituloEncabezado.Location = new Point(20, 15);
            lblTituloEncabezado.Name = "lblTituloEncabezado";
            lblTituloEncabezado.Size = new Size(399, 36);
            lblTituloEncabezado.StateCommon.ShortText.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTituloEncabezado.TabIndex = 0;
            lblTituloEncabezado.Values.Text = "\U0001f9fe EMISIÓN DE FACTURA Y COBRO";
            // 
            // gbDatosCliente
            // 
            gbDatosCliente.Location = new Point(20, 55);
            // 
            // 
            // 
            gbDatosCliente.Panel.Controls.Add(lblClienteNombre);
            gbDatosCliente.Panel.Controls.Add(lblClienteDni);
            gbDatosCliente.Panel.Controls.Add(lblClienteIva);
            gbDatosCliente.Size = new Size(430, 110);
            gbDatosCliente.TabIndex = 1;
            gbDatosCliente.Values.Heading = "Información del Cliente";
            // 
            // lblClienteNombre
            // 
            lblClienteNombre.Location = new Point(10, 5);
            lblClienteNombre.Name = "lblClienteNombre";
            lblClienteNombre.Size = new Size(87, 26);
            lblClienteNombre.StateCommon.ShortText.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblClienteNombre.TabIndex = 0;
            lblClienteNombre.Values.Text = "Cliente: --";
            // 
            // lblClienteDni
            // 
            lblClienteDni.Location = new Point(10, 30);
            lblClienteDni.Name = "lblClienteDni";
            lblClienteDni.Size = new Size(105, 24);
            lblClienteDni.TabIndex = 1;
            lblClienteDni.Values.Text = "DNI / CUIT: --";
            // 
            // lblClienteIva
            // 
            lblClienteIva.Location = new Point(10, 55);
            lblClienteIva.Name = "lblClienteIva";
            lblClienteIva.Size = new Size(128, 24);
            lblClienteIva.TabIndex = 2;
            lblClienteIva.Values.Text = "Condición IVA: --";
            // 
            // gbComprobante
            // 
            gbComprobante.Location = new Point(460, 55);
            // 
            // 
            // 
            gbComprobante.Panel.Controls.Add(lblTipoComprobante);
            gbComprobante.Panel.Controls.Add(cmbTipoFactura);
            gbComprobante.Panel.Controls.Add(lblFechaEmision);
            gbComprobante.Size = new Size(320, 110);
            gbComprobante.TabIndex = 2;
            gbComprobante.Values.Heading = "Detalles Fiscales";
            // 
            // lblTipoComprobante
            // 
            lblTipoComprobante.Location = new Point(10, 8);
            lblTipoComprobante.Name = "lblTipoComprobante";
            lblTipoComprobante.Size = new Size(45, 24);
            lblTipoComprobante.TabIndex = 0;
            lblTipoComprobante.Values.Text = "Tipo:";
            // 
            // cmbTipoFactura
            // 
            cmbTipoFactura.Location = new Point(55, 5);
            cmbTipoFactura.Name = "cmbTipoFactura";
            cmbTipoFactura.Size = new Size(240, 26);
            cmbTipoFactura.TabIndex = 1;
            cmbTipoFactura.SelectedIndexChanged += cmbTipoFactura_SelectedIndexChanged;
            // 
            // lblFechaEmision
            // 
            lblFechaEmision.Location = new Point(10, 45);
            lblFechaEmision.Name = "lblFechaEmision";
            lblFechaEmision.Size = new Size(178, 24);
            lblFechaEmision.TabIndex = 2;
            lblFechaEmision.Values.Text = "Fecha: 09/11/2026 21:07";
            // 
            // dgvDetalleFactura
            // 
            dgvDetalleFactura.BorderStyle = BorderStyle.None;
            dgvDetalleFactura.ColumnHeadersHeight = 36;
            dgvDetalleFactura.Location = new Point(20, 175);
            dgvDetalleFactura.Name = "dgvDetalleFactura";
            dgvDetalleFactura.RowHeadersWidth = 51;
            dgvDetalleFactura.Size = new Size(760, 180);
            dgvDetalleFactura.TabIndex = 3;
            // 
            // gbDesgloseTotales
            // 
            gbDesgloseTotales.Location = new Point(460, 365);
            // 
            // 
            // 
            gbDesgloseTotales.Panel.Controls.Add(lblSubtotalNeto);
            gbDesgloseTotales.Panel.Controls.Add(lblIva21);
            gbDesgloseTotales.Panel.Controls.Add(lblExento);
            gbDesgloseTotales.Panel.Controls.Add(lblTotalPagar);
            gbDesgloseTotales.Size = new Size(320, 150);
            gbDesgloseTotales.TabIndex = 4;
            gbDesgloseTotales.Values.Heading = "Resumen Impositivo";
            // 
            // lblSubtotalNeto
            // 
            lblSubtotalNeto.Location = new Point(10, 5);
            lblSubtotalNeto.Name = "lblSubtotalNeto";
            lblSubtotalNeto.Size = new Size(151, 24);
            lblSubtotalNeto.TabIndex = 0;
            lblSubtotalNeto.Values.Text = "Subtotal Neto: $0.00";
            // 
            // lblIva21
            // 
            lblIva21.Location = new Point(10, 28);
            lblIva21.Name = "lblIva21";
            lblIva21.Size = new Size(122, 24);
            lblIva21.TabIndex = 1;
            lblIva21.Values.Text = "IVA (21%): $0.00";
            // 
            // lblExento
            // 
            lblExento.Location = new Point(10, 51);
            lblExento.Name = "lblExento";
            lblExento.Size = new Size(158, 24);
            lblExento.TabIndex = 2;
            lblExento.Values.Text = "Libre Impuesto: $0.00";
            // 
            // lblTotalPagar
            // 
            lblTotalPagar.Location = new Point(10, 80);
            lblTotalPagar.Name = "lblTotalPagar";
            lblTotalPagar.Size = new Size(142, 32);
            lblTotalPagar.StateCommon.ShortText.Color1 = Color.FromArgb(37, 99, 235);
            lblTotalPagar.StateCommon.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalPagar.TabIndex = 3;
            lblTotalPagar.Values.Text = "TOTAL: $0.00";
            // 
            // gbPago
            // 
            gbPago.Location = new Point(0, 365);
            // 
            // 
            // 
            gbPago.Panel.Controls.Add(lblMetodoPago);
            gbPago.Panel.Controls.Add(cmbMetodoPago);
            gbPago.Panel.Controls.Add(lblMontoAbonado);
            gbPago.Panel.Controls.Add(txtMontoAbonado);
            gbPago.Panel.Controls.Add(lblVuelto);
            gbPago.Size = new Size(450, 150);
            gbPago.TabIndex = 5;
            gbPago.Values.Heading = "Procesamiento de Pago";
            // 
            // lblMetodoPago
            // 
            lblMetodoPago.Location = new Point(10, 10);
            lblMetodoPago.Name = "lblMetodoPago";
            lblMetodoPago.Size = new Size(98, 24);
            lblMetodoPago.TabIndex = 0;
            lblMetodoPago.Values.Text = "Medio Pago:";
            // 
            // cmbMetodoPago
            // 
            cmbMetodoPago.Location = new Point(127, 8);
            cmbMetodoPago.Name = "cmbMetodoPago";
            cmbMetodoPago.Size = new Size(273, 26);
            cmbMetodoPago.TabIndex = 1;
            cmbMetodoPago.SelectedIndexChanged += cmbMetodoPago_SelectedIndexChanged;
            // 
            // lblMontoAbonado
            // 
            lblMontoAbonado.Location = new Point(10, 48);
            lblMontoAbonado.Name = "lblMontoAbonado";
            lblMontoAbonado.Size = new Size(111, 24);
            lblMontoAbonado.TabIndex = 2;
            lblMontoAbonado.Values.Text = "Abona con ($):";
            // 
            // txtMontoAbonado
            // 
            txtMontoAbonado.Location = new Point(127, 45);
            txtMontoAbonado.Name = "txtMontoAbonado";
            txtMontoAbonado.Size = new Size(273, 27);
            txtMontoAbonado.TabIndex = 3;
            txtMontoAbonado.TextChanged += txtMontoAbonado_TextChanged;
            txtMontoAbonado.Click += txtMontoAbonado_Click;
            txtMontoAbonado.Enter += txtMontoAbonado_Enter;
            // 
            // lblVuelto
            // 
            lblVuelto.Location = new Point(10, 85);
            lblVuelto.Name = "lblVuelto";
            lblVuelto.Size = new Size(119, 27);
            lblVuelto.StateCommon.ShortText.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblVuelto.TabIndex = 4;
            lblVuelto.Values.Text = "Vuelto: $0.00";
            // 
            // btnConfirmarFactura
            // 
            btnConfirmarFactura.Location = new Point(460, 525);
            btnConfirmarFactura.Name = "btnConfirmarFactura";
            btnConfirmarFactura.Size = new Size(320, 45);
            btnConfirmarFactura.StateCommon.Back.Color1 = Color.FromArgb(16, 185, 129);
            btnConfirmarFactura.StateCommon.Back.Color2 = Color.FromArgb(16, 185, 129);
            btnConfirmarFactura.StateCommon.Content.ShortText.Color1 = Color.White;
            btnConfirmarFactura.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnConfirmarFactura.TabIndex = 6;
            btnConfirmarFactura.Values.DropDownArrowColor = Color.Empty;
            btnConfirmarFactura.Values.Text = "💳 Confirmar y Emitir Factura";
            btnConfirmarFactura.Click += btnConfirmarFactura_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(20, 525);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(180, 45);
            btnCancelar.TabIndex = 7;
            btnCancelar.Values.DropDownArrowColor = Color.Empty;
            btnCancelar.Values.Text = "❌ Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormFacturacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 585);
            Controls.Add(lblTituloEncabezado);
            Controls.Add(gbDatosCliente);
            Controls.Add(gbComprobante);
            Controls.Add(dgvDetalleFactura);
            Controls.Add(gbDesgloseTotales);
            Controls.Add(gbPago);
            Controls.Add(btnConfirmarFactura);
            Controls.Add(btnCancelar);
            Name = "FormFacturacion";
            Text = "Módulo de Facturación y Cobro - LaptopDeel";
            ((System.ComponentModel.ISupportInitialize)gbDatosCliente.Panel).EndInit();
            gbDatosCliente.Panel.ResumeLayout(false);
            gbDatosCliente.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gbDatosCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)gbComprobante.Panel).EndInit();
            gbComprobante.Panel.ResumeLayout(false);
            gbComprobante.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gbComprobante).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbTipoFactura).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleFactura).EndInit();
            ((System.ComponentModel.ISupportInitialize)gbDesgloseTotales.Panel).EndInit();
            gbDesgloseTotales.Panel.ResumeLayout(false);
            gbDesgloseTotales.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gbDesgloseTotales).EndInit();
            ((System.ComponentModel.ISupportInitialize)gbPago.Panel).EndInit();
            gbPago.Panel.ResumeLayout(false);
            gbPago.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gbPago).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbMetodoPago).EndInit();
            ResumeLayout(false);
            PerformLayout();
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