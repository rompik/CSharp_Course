namespace ViewWinForm
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
            Application.Run(new Form1());
            //Form1 form1 = new Form1();
            //IMainModel model = new MainModel();
            //MainPresenter presenter = new MainPresenter(model, form1); //TODO: 

            //Application.Run(form1);

        }
    }
}