using System;

namespace LazyExample
{
    class Program
    {
        class Test
        {
            int[] _array;

            public Test()
            {
                Console.WriteLine("Test");
                _array = new int[5];
            }

            public int Length
            {
                get { return _array.Length; }
            }
        }
        static void Main(string[] args)
        {
            Lazy<Test> lazy = new Lazy<Test>();
            Console.WriteLine("IsValueCreated = {0}", lazy.IsValueCreated);
            Test test = lazy.Value;
            Console.WriteLine("IsValueCreated = {0}", lazy.IsValueCreated);
            Console.ReadKey();
        }
    }
}
