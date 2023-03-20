namespace Lab16Main
{
    public static class Program
    {
        public static CycledList<Transport> list = new CycledList<Transport>();
        public static Random rand = new Random();
        public static MainForm mainForm = new MainForm();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static int Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(mainForm);

            return 0;
        }
    }
}