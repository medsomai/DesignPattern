namespace MementoPatternExample
{
    public class TextEditorMemento
    {
        public string Content { get; }

        public TextEditorMemento(string content)
        {
            Content = content;
        }
    }

    public class TextEditor
    {
        public string Content { get; private set; } = "";

        public void Write(string text)
        {
            Content += text;
        }

        public TextEditorMemento Save()
        {
            return new TextEditorMemento(Content);
        }

        public void Restore(TextEditorMemento memento)
        {
            Content = memento.Content;
        }
    }

    public class TextHistory
    {
        private readonly Stack<TextEditorMemento> _history = new();

        public void Save(TextEditor editor)
        {
            _history.Push(editor.Save());
        }

        public void Undo(TextEditor editor)
        {
            if (_history.Count > 0)
            {
                _history.Pop();

                editor.Restore(_history.Count > 0 ? _history.Peek() : new TextEditorMemento(""));
            }
        }
    }

    class Program
    {
        static void Main()
        {
            var editor = new TextEditor();
            var history = new TextHistory();

            editor.Write("Bonjour");
            history.Save(editor);
            Console.WriteLine("État actuel : " + editor.Content);

            editor.Write(", comment ça va ?");
            history.Save(editor);
            Console.WriteLine("État après modification : " + editor.Content);

            history.Undo(editor);
            Console.WriteLine("Après annulation : " + editor.Content);

            history.Undo(editor);
            Console.WriteLine("Retour à l'état initial : " + editor.Content);
        }
    }
}
