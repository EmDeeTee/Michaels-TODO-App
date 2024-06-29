using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal.Gui;

namespace CsTUI {
    // NOTE: That is such a weird implementation. I don't know what I was thinking
    public static class WindowManager {
        public static Dictionary<WINDOW_TYPE, Window> Windows { get; private set; } = new() {
            { WINDOW_TYPE.MAIN, new ProgramWindow() },
        };

        public enum WINDOW_TYPE {
            MAIN,
            EDIT
        }

        public static void ShowWindow(WINDOW_TYPE type, Todo? selectedTodo = null) {
            Application.Top.RemoveAll();

            if (type == WINDOW_TYPE.EDIT) {
                Application.Top.Add(new EditTodoWindow(selectedTodo));
                Application.Refresh();
                return;
            }

            Application.Top.Add(Windows[type]);
            Application.Refresh();
        }
    }
}
