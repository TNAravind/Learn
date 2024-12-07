using _01_Example;

namespace _02_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            _01_Example.Example example = new _01_Example.Example(1);
        }
    }
    public class Example
    {

    }
    public class Example2 : _01_Example.Example
    {
        public Example2(string s) : base("hello")
        {

        }
        public Example2(int a) : base(a)
        {

        }
        public Example2(double d): base(4)
        {

        }
        public void AccessTheProtectedVariable()
        {
            Console.WriteLine(c);
        }
    }
}   