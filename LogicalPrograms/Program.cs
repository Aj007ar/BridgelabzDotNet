namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n*******************WELCOME TO LOGICAL PROGRAMS*******************");

            Console.WriteLine("\n********************Fibbonacci Numbers***************************");
            Fibbonacci fib = new Fibbonacci();
            fib.Fibbo();

            Console.WriteLine("\n\n*********************Prime Numbers*******************************");
            Prime prm = new Prime();
            prm.PrimeNumber();

            Console.WriteLine("\n\n**********************Reversed Number****************************");
            ReverseNumber revrs = new ReverseNumber();
            revrs.Reverse();
        }
    }
}