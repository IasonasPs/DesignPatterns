namespace DependencyInjection.ConstructorInjection
{
    public class Format : IText
    {
        private string _text = "this is a text format";

        public Format()
        {
        }

        public Format(string text)
        {
            _text = text;
        }

        public void Print()
        {
            Console.WriteLine(_text);
        }
    }
}