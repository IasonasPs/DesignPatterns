using DependencyInjection.ConstructorInjection;

namespace DependencyInjection.ConstructorInjection
{
    public class ConstructorInjection
    {
        private IText _text;

        public ConstructorInjection(IText text)
        {
            _text = text;
        }

        public void print()
        {
            _text.Print();
        }
    }
}


public class WithOutConstructorInjection
{
    private IText _text;

    public WithOutConstructorInjection()
    {
        _text = new Format();
    }

    public void print()
    {
        _text.Print();
    }
}


