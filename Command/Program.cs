namespace CommandPatternExample
{
    // Interface pour les commandes
    public interface ICommand
    {
        void Execute();
        void Undo();
    }

    // Récepteur : l'éditeur de texte
    public class TextEditor
    {
        private string _text = "";

        public void AppendText(string text)
        {
            _text += text;
        }

        public void RemoveText(int length)
        {
            if (length <= _text.Length)
                _text = _text.Substring(0, _text.Length - length);
        }

        public string GetText()
        {
            return _text;
        }
    }

    // Commande concrète : Ajouter du texte
    public class AppendTextCommand : ICommand
    {
        private readonly TextEditor _editor;
        private readonly string _text;

        public AppendTextCommand(TextEditor editor, string text)
        {
            _editor = editor;
            _text = text;
        }

        public void Execute()
        {
            _editor.AppendText(_text);
        }

        public void Undo()
        {
            _editor.RemoveText(_text.Length);
        }
    }

    // Invocateur : Gestionnaire de commandes
    public class CommandManager
    {
        private readonly Stack<ICommand> _commandHistory = new();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _commandHistory.Push(command);
        }

        public void UndoLastCommand()
        {
            if (_commandHistory.Count > 0)
            {
                var command = _commandHistory.Pop();
                command.Undo();
            }
        }
    }

    // Classe de test
    class Program
    {
        static void Main(string[] args)
        {
            // Création des objets
            var editor = new TextEditor();
            var commandManager = new CommandManager();

            // Création des commandes
            var command1 = new AppendTextCommand(editor, "Hello, ");
            var command2 = new AppendTextCommand(editor, "World!");

            // Exécution des commandes
            commandManager.ExecuteCommand(command1);
            commandManager.ExecuteCommand(command2);

            Console.WriteLine("Text after commands: " + editor.GetText());            

            // Annulation de la dernière commande
            commandManager.UndoLastCommand();
            Console.WriteLine("Text after undo: " + editor.GetText());

            // Annulation de toutes les commandes
            commandManager.UndoLastCommand();
            Console.WriteLine("Text after undo all: " + editor.GetText());            
        }
    }
}
