using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsTUI {
    public class Todo {
        private string? _content;
        public string? Content {
            get { return _content; }
            set { _content = value; } 
        }
        public bool IsCompleted { get; private set; }

        public void ToggleComplete() {
            IsCompleted = !IsCompleted;
        }

        public override string ToString() {
            return _CompletedToString() + " " + Content;
        }

        private string _CompletedToString() {
            return IsCompleted ? "[x]": "[]";
        }
    }
}
