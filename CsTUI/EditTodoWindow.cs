using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal.Gui;

namespace CsTUI {
    internal class EditTodoWindow : Window {
        // TODO: the 'e' character overflows to the name
        public EditTodoWindow(Todo todo) {
            Title = "Edit todo";

            var label = new Label() {
                Text = "Name:"
            };

            var label2 = new Label() {
                Text = "Enter to accept",
                X = Pos.Center(),
                Y = Pos.Center()
            };

            var todoText = new TextField(todo.Content) {
                X = Pos.Right(label) + 1,
                Width = Dim.Fill(),
            };

            todoText.KeyPress += (key) => {
                if (key.KeyEvent.Key == Key.Enter) {
                    todo.Content = todoText.Text.ToString();
                    key.Handled = true;
                    WindowManager.ShowWindow(WindowManager.WINDOW_TYPE.MAIN);
                }

            };

            Add(todoText, label, label2);
        }
    }
}
