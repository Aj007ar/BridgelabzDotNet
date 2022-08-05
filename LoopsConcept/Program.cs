namespace LoopsConcept
{
    internal class Program
    {
        public void PassByValue(int a)
        {
            a = a + 10;
            Console.WriteLine(a);
        }
        public void PassByRef(ref int b)
        {
            b = b + 10;
            Console.WriteLine(b);
        }
        static void Main(string[] args)
        {
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i+"  Hello, World!");
            }
            Console.WriteLine("\n*********Nested For Loop********");
            for(int i = 1; i <= 3; i++)
            {
                Console.WriteLine("\n******Hello***********");
                for(int j = 1; j <= 3; j++)
                {
                    Console.WriteLine("Ajay");
                }
            }
            Console.WriteLine("\n*********While Loop*****");
            int k= 0;
            while(k <= 5)
            {
                Console.WriteLine("Ajay");
                k++;
            }
            Console.WriteLine("\n***********Passing Values*****");
            int value = 5;
            Program obj = new Program();
            obj.PassByValue(value);
            Console.WriteLine(value);
            obj.PassByRef(ref value);
            Console.WriteLine("After refer value is "+value);
        }
    }
}