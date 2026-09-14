using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LaptopDeel
{
    public partial class ControlMenuAdmin : UserControl
    {
        private FormAdminPrincipal formPadre;
        public ControlMenuAdmin(FormAdminPrincipal padre)
        {
            InitializeComponent();
            this.formPadre = padre;
            this.Dock = DockStyle.Fill;
            this.BackColor = ColorTranslator.FromHtml("#F8FAFC");
        }
    }
}
