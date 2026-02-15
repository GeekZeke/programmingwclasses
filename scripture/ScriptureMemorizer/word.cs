namespace ScriptureMemorizer
{
    public class Word
    {
        private string _text;
        private bool _hidden;

        public Word(string text)
        {
            _text = text;
            _hidden = false;
        }

        public string Display()
        {
            return _hidden ? "____" : _text;
        }

        public void Hide()
        {
            _hidden = true;
        }

        public bool IsHidden()
        {
            return _hidden;
        }
    }
}
