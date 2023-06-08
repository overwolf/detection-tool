using Gtk;

namespace DetectionTool
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Init();
            MainWindow mainWindow = new MainWindow();
            mainWindow.ShowAll();
            Application.Run();
        }
    }
}
