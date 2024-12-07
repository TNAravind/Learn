namespace _03_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Child child = new Child();
            child.PrintChild();
        }

        public class Parent
        {
            public int a = 1;

            public Parent(int a)
            {
                this.a = a;
            }
            private Parent()
            {
                Console.WriteLine("Private constructor of the Parent class");
            }
            public void PrintParent()
            {
                Console.WriteLine("Printing from PrintParent method");
            }
        }
        public class Child : Parent
        {
            public Child() : base(1)
            {

            }
            public Child(int a) : base(1)
            {

            }
            //private Child()
            //{

            //}
            public void PrintChild()
            {
                Child child = new Child();
                child.PrintParent();
            }
        }
        public class AnotherChild : Child
        {
            private AnotherChild(int a) : base(a)
            {

            }
            private AnotherChild() : base()
            {

            }
            public void AccessParentValues()
            {
                Console.WriteLine(a);
            }
        }
    }
}