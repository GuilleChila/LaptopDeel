namespace LaptopDeel
{
    partial class LoginForm
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panelTarjetaCentral = new Krypton.Toolkit.KryptonPanel();
            btnIniciarSesion = new Krypton.Toolkit.KryptonButton();
            linkl_olvideContraseña = new Krypton.Toolkit.KryptonLinkLabel();
            txtPassword = new Krypton.Toolkit.KryptonTextBox();
            L_contraseñaLogin = new Krypton.Toolkit.KryptonLabel();
            txtEmail = new Krypton.Toolkit.KryptonTextBox();
            L_mailLogin = new Krypton.Toolkit.KryptonLabel();
            LSubtituloLogin = new Krypton.Toolkit.KryptonLabel();
            LMarca_Login = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)panelTarjetaCentral).BeginInit();
            panelTarjetaCentral.SuspendLayout();
            SuspendLayout();
            // 
            // panelTarjetaCentral
            // 
            panelTarjetaCentral.Anchor = AnchorStyles.None;
            panelTarjetaCentral.Controls.Add(btnIniciarSesion);
            panelTarjetaCentral.Controls.Add(linkl_olvideContraseña);
            panelTarjetaCentral.Controls.Add(txtPassword);
            panelTarjetaCentral.Controls.Add(L_contraseñaLogin);
            panelTarjetaCentral.Controls.Add(txtEmail);
            panelTarjetaCentral.Controls.Add(L_mailLogin);
            panelTarjetaCentral.Controls.Add(LSubtituloLogin);
            panelTarjetaCentral.Controls.Add(LMarca_Login);
            panelTarjetaCentral.Location = new Point(490, 110);
            panelTarjetaCentral.Name = "panelTarjetaCentral";
            panelTarjetaCentral.Size = new Size(380, 500);
            panelTarjetaCentral.StateCommon.Color1 = Color.FromArgb(33, 39, 56);
            panelTarjetaCentral.TabIndex = 0;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Location = new Point(100, 411);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(183, 46);
            btnIniciarSesion.StateCommon.Back.Color1 = Color.FromArgb(37, 99, 235);
            btnIniciarSesion.StateCommon.Back.Color2 = Color.FromArgb(37, 99, 235);
            btnIniciarSesion.StateCommon.Border.Rounding = 8F;
            btnIniciarSesion.StateCommon.Content.ShortText.Color1 = Color.White;
            btnIniciarSesion.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciarSesion.TabIndex = 7;
            btnIniciarSesion.Values.DropDownArrowColor = Color.Empty;
            btnIniciarSesion.Values.Text = "Iniciar Sesión";
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // linkl_olvideContraseña
            // 
            linkl_olvideContraseña.Location = new Point(189, 353);
            linkl_olvideContraseña.Name = "linkl_olvideContraseña";
            linkl_olvideContraseña.Size = new Size(158, 24);
            linkl_olvideContraseña.TabIndex = 6;
            linkl_olvideContraseña.Values.Text = "Olvidé mi Contraseña ";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(41, 314);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(291, 33);
            txtPassword.StateCommon.Back.Color1 = Color.FromArgb(24, 30, 42);
            txtPassword.StateCommon.Border.Color1 = Color.FromArgb(45, 53, 72);
            txtPassword.StateCommon.Border.Rounding = 8F;
            txtPassword.TabIndex = 5;
            txtPassword.Text = "hola1234";
            txtPassword.TextAlign = HorizontalAlignment.Center;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // L_contraseñaLogin
            // 
            L_contraseñaLogin.Location = new Point(3, 284);
            L_contraseñaLogin.Name = "L_contraseñaLogin";
            L_contraseñaLogin.Size = new Size(89, 24);
            L_contraseñaLogin.StateCommon.ShortText.Color1 = Color.FromArgb(148, 163, 184);
            L_contraseñaLogin.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            L_contraseñaLogin.TabIndex = 4;
            L_contraseñaLogin.Values.Text = "Contraseña";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(41, 231);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(291, 33);
            txtEmail.StateCommon.Back.Color1 = Color.FromArgb(24, 30, 42);
            txtEmail.StateCommon.Border.Color1 = Color.FromArgb(45, 53, 72);
            txtEmail.StateCommon.Border.Rounding = 8F;
            txtEmail.TabIndex = 3;
            txtEmail.Text = "ejemplo@laptopdeel.com";
            txtEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // L_mailLogin
            // 
            L_mailLogin.Location = new Point(3, 201);
            L_mailLogin.Name = "L_mailLogin";
            L_mailLogin.Size = new Size(137, 24);
            L_mailLogin.StateCommon.ShortText.Color1 = Color.FromArgb(148, 163, 184);
            L_mailLogin.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            L_mailLogin.TabIndex = 2;
            L_mailLogin.Values.Text = "Correo Electrónico";
            // 
            // LSubtituloLogin
            // 
            LSubtituloLogin.Location = new Point(41, 140);
            LSubtituloLogin.Name = "LSubtituloLogin";
            LSubtituloLogin.Size = new Size(306, 24);
            LSubtituloLogin.StateCommon.ShortText.Color1 = Color.FromArgb(148, 163, 184);
            LSubtituloLogin.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LSubtituloLogin.TabIndex = 1;
            LSubtituloLogin.Values.Text = "Gestión de Stock y Ventas de Notebooks";
            // 
            // LMarca_Login
            // 
            LMarca_Login.Location = new Point(100, 88);
            LMarca_Login.Name = "LMarca_Login";
            LMarca_Login.Size = new Size(183, 46);
            LMarca_Login.StateCommon.ShortText.Color1 = Color.WhiteSmoke;
            LMarca_Login.StateCommon.ShortText.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LMarca_Login.TabIndex = 0;
            LMarca_Login.Values.Text = "LaptopDeel";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1360, 720);
            CloseBox = false;
            ControlBox = false;
            Controls.Add(panelTarjetaCentral);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(1360, 720);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LaptopDeel - Iniciar Sesión";
            ((System.ComponentModel.ISupportInitialize)panelTarjetaCentral).EndInit();
            panelTarjetaCentral.ResumeLayout(false);
            panelTarjetaCentral.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel panelTarjetaCentral;
        private Krypton.Toolkit.KryptonLabel LMarca_Login;
        private Krypton.Toolkit.KryptonLabel LSubtituloLogin;
        private Krypton.Toolkit.KryptonTextBox txtEmail;
        private Krypton.Toolkit.KryptonLabel L_mailLogin;
        private Krypton.Toolkit.KryptonLinkLabel linkl_olvideContraseña;
        private Krypton.Toolkit.KryptonTextBox txtPassword;
        private Krypton.Toolkit.KryptonLabel L_contraseñaLogin;
        private Krypton.Toolkit.KryptonButton btnIniciarSesion;
    }
}