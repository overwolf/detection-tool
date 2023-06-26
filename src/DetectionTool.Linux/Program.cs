using Gtk;

namespace DetectionToolLinux {
  internal static class Program {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {
      Application.Init();
      MainWindow mainWindow = new MainWindow();
      mainWindow.DeleteEvent += (sender, eventArgs) => {
        // Perform any necessary cleanup tasks here
        Application.Quit();
      };
      mainWindow.ShowAll();
      Application.Run();
    }
  }
}