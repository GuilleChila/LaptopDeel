namespace LaptopDeel
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            using (LoginForm login = new LoginForm())
            {
                DialogResult resultado = login.ShowDialog();

                // 2. Si el usuario hizo clic en "Iniciar Sesión", abre el FormPrincipal
                if (resultado == DialogResult.OK)
                {
                    Application.Run(new FormPrincipal());
                }
                else
                {
                    // Si cerró la ventana desde la barra de tareas, sale del sistema
                    Application.Exit();
                }
            }
        }
    }
}