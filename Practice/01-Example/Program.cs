namespace _01_Example
{
    internal class Program
    {
        static Program()
        {
            Console.WriteLine("Hello from program constructor");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Example example = new Example(2);
            //Console.WriteLine(example.b);
            Console.WriteLine(example.c);
            Example.GetNumber();
            UnderstandingTypesOfVariables understandingTypesOfVariables = new UnderstandingTypesOfVariables();
            UnderstandingTypesOfVariables understandingTypesOfVariables2 = new UnderstandingTypesOfVariables();

            var valueOfA = UnderstandingTypesOfVariables.a;
            //understandingTypesOfVariables.e = 10;
            //UnderstandingTypesOfVariables.d = 10;
        }
    }
        
    public class Example
    {
        static int a = 1;
        private int b;
        protected internal int c;
        static Example()
        {
            Console.WriteLine("Static constructor of example class");
        }
        //private Example(string number)
        //{
        //    Console.WriteLine($"{number}" + a);
        //}
        public Example(int b)
        {
            //this.b = b;
        }
        public Example(string name)
        {
            //this.b = b;
        }
        public static void GetNumber()
        {
            Example example = new Example(1);
            Console.WriteLine(example.b);
        }
    }
    public static class StaticClass
    {
        static int a;
    }
    public class UnderstandingTypesOfVariables
    {
        public const int a = 1;
        //static const int b = 2;
        public readonly int c;
        public static readonly int d = 5;
        public readonly int e = 9;
        public int m;

        public UnderstandingTypesOfVariables()
        {
            this.e = 11;
        }
        static UnderstandingTypesOfVariables()
        {
            //m = 10;
            d = 10;
        }
        public void PrintValues()
        {
            Console.WriteLine("Value of a is: " + a);
        }
    }
}