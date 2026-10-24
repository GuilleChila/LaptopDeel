namespace LaptopDeel
{
    partial class FormVendedorPrincipal
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

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            panelHeader = new Krypton.Toolkit.KryptonPanel();
            lblTituloApp = new Krypton.Toolkit.KryptonLabel();
            lblStatusDB = new Krypton.Toolkit.KryptonLabel();
            panelSidebar = new Krypton.Toolkit.KryptonPanel();
            btnNavNuevaVenta = new Krypton.Toolkit.KryptonButton();
            btnNavClientes = new Krypton.Toolkit.KryptonButton();
            btnNavHistorialVentas = new Krypton.Toolkit.KryptonButton();
            lblUsuarioSidebar = new Krypton.Toolkit.KryptonLabel();
            btnCerrarSesion = new Krypton.Toolkit.KryptonButton();
            panelCanvas = new Krypton.Toolkit.KryptonPanel();

            ((System.ComponentModel.ISupportInitialize)panelHeader).BeginInit();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelSidebar).BeginInit();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelCanvas).BeginInit();
            SuspendLayout();

            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(lblTituloApp);
            panelHeader.Controls.Add(lblStatusDB);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1360, 60);
            panelHeader.StateCommon.Color1 = Color.FromArgb(30, 41, 59);
            panelHeader.StateCommon.Color2 = Color.FromArgb(30, 41, 59);
            panelHeader.TabIndex = 0;

            // 
            // lblTituloApp
            // 
            lblTituloApp.Location = new Point(20, 12);
            lblTituloApp.Name = "lblTituloApp";
            lblTituloApp.Size = new Size(197, 36);
            lblTituloApp.StateCommon.ShortText.Color1 = Color.White;
            lblTituloApp.StateCommon.ShortText.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTituloApp.TabIndex = 0;
            lblTituloApp.Values.Text = "LaptopDeel POS";

            // 
            // lblStatusDB
            // 
            lblStatusDB.Dock = DockStyle.Right;
            lblStatusDB.Location = new Point(1220, 0);
            lblStatusDB.Name = "lblStatusDB";
            lblStatusDB.Size = new Size(140, 60);
            lblStatusDB.StateCommon.ShortText.Color1 = Color.FromArgb(16, 185, 129);
            lblStatusDB.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatusDB.TabIndex = 2;
            lblStatusDB.Values.Text = "● DB: Conectado";

            // 
            // panelSidebar
            // 
            panelSidebar.Controls.Add(btnNavNuevaVenta);
            panelSidebar.Controls.Add(btnNavClientes);
            panelSidebar.Controls.Add(btnNavHistorialVentas);
            panelSidebar.Controls.Add(lblUsuarioSidebar);
            panelSidebar.Controls.Add(btnCerrarSesion);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 60);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(240, 660);
            panelSidebar.StateCommon.Color1 = Color.FromArgb(30, 41, 59);
            panelSidebar.StateCommon.Color2 = Color.FromArgb(30, 41, 59);
            panelSidebar.TabIndex = 1;

            // 
            // btnNavNuevaVenta
            // 
            btnNavNuevaVenta.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnNavNuevaVenta.Location = new Point(15, 30);
            btnNavNuevaVenta.Name = "btnNavNuevaVenta";
            btnNavNuevaVenta.Size = new Size(210, 45);
            btnNavNuevaVenta.StateCommon.Back.Color1 = Color.FromArgb(37, 99, 235);
            btnNavNuevaVenta.StateCommon.Back.Color2 = Color.FromArgb(37, 99, 235);
            btnNavNuevaVenta.StateCommon.Content.ShortText.Color1 = Color.White;
            btnNavNuevaVenta.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNavNuevaVenta.TabIndex = 0;
            btnNavNuevaVenta.Values.Text = "🛒 Nueva Venta";

            // 
            // btnNavClientes
            // 
            btnNavClientes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnNavClientes.Location = new Point(15, 85);
            btnNavClientes.Name = "btnNavClientes";
            btnNavClientes.Size = new Size(210, 45);
            btnNavClientes.StateCommon.Back.Color1 = Color.Transparent;
            btnNavClientes.StateCommon.Back.Color2 = Color.Transparent;
            btnNavClientes.StateCommon.Content.ShortText.Color1 = Color.FromArgb(148, 163, 184);
            btnNavClientes.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            btnNavClientes.TabIndex = 1;
            btnNavClientes.Values.Text = "👥 Clientes";

            // 
            // btnNavHistorialVentas
            // 
            btnNavHistorialVentas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnNavHistorialVentas.Location = new Point(15, 140);
            btnNavHistorialVentas.Name = "btnNavHistorialVentas";
            btnNavHistorialVentas.Size = new Size(210, 45);
            btnNavHistorialVentas.StateCommon.Back.Color1 = Color.Transparent;
            btnNavHistorialVentas.StateCommon.Back.Color2 = Color.Transparent;
            btnNavHistorialVentas.StateCommon.Content.ShortText.Color1 = Color.FromArgb(148, 163, 184);
            btnNavHistorialVentas.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            btnNavHistorialVentas.TabIndex = 2;
            btnNavHistorialVentas.Values.Text = "📋 Historial Ventas";

            // 
            // lblUsuarioSidebar
            // 
            lblUsuarioSidebar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblUsuarioSidebar.Location = new Point(15, 544);
            lblUsuarioSidebar.Name = "lblUsuarioSidebar";
            lblUsuarioSidebar.Size = new Size(210, 27);
            lblUsuarioSidebar.StateCommon.ShortText.Color1 = Color.White;
            lblUsuarioSidebar.StateCommon.ShortText.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsuarioSidebar.TabIndex = 3;
            lblUsuarioSidebar.Values.Text = "👤 Vendedor (POS)";

            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCerrarSesion.Location = new Point(15, 585);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(210, 45);
            btnCerrarSesion.StateCommon.Back.Color1 = Color.FromArgb(239, 68, 68);
            btnCerrarSesion.StateCommon.Back.Color2 = Color.FromArgb(239, 68, 68);
            btnCerrarSesion.StateCommon.Content.ShortText.Color1 = Color.White;
            btnCerrarSesion.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCerrarSesion.TabIndex = 4;
            btnCerrarSesion.Values.Text = "🔴 Cerrar Sesión";

            // 
            // panelCanvas
            // 
            panelCanvas.Dock = DockStyle.Fill;
            panelCanvas.Location = new Point(240, 60);
            panelCanvas.Name = "panelCanvas";
            panelCanvas.Size = new Size(1120, 660);
            panelCanvas.StateCommon.Color1 = Color.FromArgb(241, 245, 249);
            panelCanvas.StateCommon.Color2 = Color.FromArgb(241, 245, 249);
            panelCanvas.TabIndex = 2;

            // 
            // FormVendedorPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 720);
            Controls.Add(panelCanvas);
            Controls.Add(panelSidebar);
            Controls.Add(panelHeader);
            Name = "FormVendedorPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LaptopDeel - Selección y Punto de Venta (POS)";

            ((System.ComponentModel.ISupportInitialize)panelHeader).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelSidebar).EndInit();
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelCanvas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel panelHeader;
        private Krypton.Toolkit.KryptonLabel lblTituloApp;
        private Krypton.Toolkit.KryptonLabel lblStatusDB;
        private Krypton.Toolkit.KryptonPanel panelSidebar;
        private Krypton.Toolkit.KryptonButton btnNavNuevaVenta;
        private Krypton.Toolkit.KryptonButton btnNavClientes;
        private Krypton.Toolkit.KryptonButton btnNavHistorialVentas;
        private Krypton.Toolkit.KryptonLabel lblUsuarioSidebar;
        private Krypton.Toolkit.KryptonButton btnCerrarSesion;
        private Krypton.Toolkit.KryptonPanel panelCanvas;
    }
}