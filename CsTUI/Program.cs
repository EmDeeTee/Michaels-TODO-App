using Terminal.Gui;

namespace CsTUI {
    internal class Program {
        public static ProgramWindow Window { get; private set; } = new ProgramWindow();
        static void Main(string[] args) {
            Application.Init();
            WindowManager.ShowWindow(WindowManager.WINDOW_TYPE.MAIN);
            Application.Run();

            Application.Shutdown();
        }
    }
}
