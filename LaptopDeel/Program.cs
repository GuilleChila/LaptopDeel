using System;
using System.Windows.Forms;

namespace LaptopDeel
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm login = new LoginForm();

            if (login.ShowDialog() == DialogResult.OK)
            {
                // Le mandamos el usuario que se acaba de loguear
                Application.Run(new FormAdminPrincipal(login.UsuarioAutenticado));
            }

            bool continuarEjecucion = true;
            while (continuarEjecucion)
            {
                using (LoginForm loginForm = new LoginForm())
                {
                    if (loginForm.ShowDialog() == DialogResult.OK)
                    {
                        string rolAcceso = loginForm.Tag?.ToString() ?? "Admin";

                        // Redirección condicional según el rol verificado
                        if (rolAcceso == "Vendedor")
                        {
                            using (FormVendedorPrincipal formVendedor = new FormVendedorPrincipal())
                            {
                                DialogResult resultado = formVendedor.ShowDialog();
                                if (resultado != DialogResult.Retry)
                                {
                                    continuarEjecucion = false;
                                }
                            }
                        }
                        else if (rolAcceso == "Gerente")
                        {
                            using (FormCeoPrincipal formCeo = new FormCeoPrincipal())
                            {
                                DialogResult resultado = formCeo.ShowDialog();
                                if (resultado != DialogResult.Retry)
                                {
                                    continuarEjecucion = false;
                                }
                            }
                        }
                        else
                        {
                            using (FormAdminPrincipal formAdmin = new FormAdminPrincipal())
                            {
                                DialogResult resultado = formAdmin.ShowDialog();
                                if (resultado != DialogResult.Retry)
                                {
                                    continuarEjecucion = false;
                                }
                            }
                        }
                    }
                    else
                    {
                        continuarEjecucion = false;
                    }
                }
            }


        }
    }
}