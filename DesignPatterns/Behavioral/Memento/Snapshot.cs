namespace DesignPatterns.Behavioral.Memento;

public class Snapshot
{
        private string Text;
        private int X;
        private int Y;
        private int SelectionWidth;
        private Editor editor;

        public Snapshot(Editor editor, int selectionWidth, int x, int y, string text)
        {
            this.editor = editor;
            SelectionWidth = selectionWidth;
            X = x;
            Y = y;
            Text = text;
        }

        public void Restore()
        {
            
            editor.Text = this.Text;
            editor.SelectionWidth = this.SelectionWidth;
            editor.SetCursorPosition(this.X, this.Y);
        }
    }