using Terminal.Gui;

namespace CsTUI {
    internal class Program {
        static void Main(string[] args) {
            Application.Run<ProgramWindow>();

            Application.Shutdown();
        }
    }
}
