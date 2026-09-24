using System;
using System.Windows.Forms;
using LaptopDeel.Entidades; // Necesario para que reconozca al "Usuario"

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

            bool continuarEjecucion = true;
            while (continuarEjecucion)
            {
                using (LoginForm loginForm = new LoginForm())
                {
                    if (loginForm.ShowDialog() == DialogResult.OK)
                    {
                        // 1. Rescatamos el usuario real
                        var usuario = loginForm.UsuarioAutenticado;

                        // 2. Leemos el rol
                        string rolAcceso = usuario.RolUsuario.RolName.Trim().ToLower();

                        DialogResult resultado;

                        // 3. Redirigimos pasándole el paquete (usuario)
                        if (rolAcceso == "vendedor")
                        {
                            using (FormVendedorPrincipal formVendedor = new FormVendedorPrincipal(usuario))
                            {
                                resultado = formVendedor.ShowDialog();
                            }
                        }
                        else if (rolAcceso == "gerente")
                        {
                            using (FormCeoPrincipal formCeo = new FormCeoPrincipal(usuario))
                            {
                                resultado = formCeo.ShowDialog();
                            }
                        }
                        else
                        {
                            using (FormAdminPrincipal formAdmin = new FormAdminPrincipal(usuario))
                            {
                                resultado = formAdmin.ShowDialog();
                            }
                        }

                        // Cortamos el ciclo si no apretaron "Cerrar sesión"
                        if (resultado != DialogResult.Retry)
                        {
                            continuarEjecucion = false;
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