using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsTUI {
    internal class Todo {
        public string? Name { get; init; } = String.Empty;
        public bool IsCompleted { get; private set; }

        public void ToggleComplete() {
            IsCompleted = !IsCompleted;
        }

        public override string ToString() {
            return _CompletedToString() + " " + Name;
        }

        private string _CompletedToString() {
            return IsCompleted ? "[x]": "[]";
        }
    }
}
