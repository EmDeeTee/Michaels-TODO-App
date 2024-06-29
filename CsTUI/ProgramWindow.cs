using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal.Gui;

namespace CsTUI {
    internal class ProgramWindow : Window {
        private readonly List<Todo> _todos = new();
        public ProgramWindow() {
            Title = "Michael's C# TODO App";

            var label = new Label() {
                Text = "New TODO:"
            };

            var todoText = new TextField("") {
                X = Pos.Right(label) + 1,
                Width = Dim.Fill(),
            };

            var btnAdd = new Button() {
                Text = "Add",
                Y = Pos.Bottom(label) + 1,
                X = Pos.Center(),
                IsDefault = true,
            };

            var todoListView = new ListView(_todos) {
                Y = Pos.Bottom(btnAdd) + 1,
                X = Pos.Center(),
                Width = Dim.Fill(),
                Height = Dim.Fill(),
            };

            btnAdd.Clicked += () => {
                if (todoText.Text.IsEmpty) {
                    MessageBox.ErrorQuery("Error", "Todo can't be empty", "OK");
                    return;
                }

                string? name = todoText.Text.ToString();

                _todos.Add(new() { 
                    Content = name
                });
                todoText.Text = "";
            };

            todoListView.KeyDown += (key) => {
                if (key.KeyEvent.Key == Key.Space) {
                    _todos[todoListView.SelectedItem].ToggleComplete();
                }
                else if (key.KeyEvent.Key == Key.e) {
                    WindowManager.ShowWindow(WindowManager.WINDOW_TYPE.EDIT, _todos[todoListView.SelectedItem]);
                }
                todoListView.SetNeedsDisplay();
                key.Handled = true;
            };

            Add(label, todoText, btnAdd, todoListView);
        }
    }
}
