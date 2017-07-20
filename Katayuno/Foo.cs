namespace Katayuno
{
    public class Foo
    {
        private readonly Bar _bar;

        public Foo(Bar bar)
        {
            _bar = bar;
        }

        public string DoFoo()
        {
            return "Foo" + _bar.DoBar();
        }
    }
}
