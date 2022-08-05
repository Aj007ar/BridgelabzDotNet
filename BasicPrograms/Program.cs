namespace BasicPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n**********************WELCOME TO BASIC PROGRAMS*********************");
            Console.WriteLine("\n*********************Flip Coin Program****************************");
            FlipCoins flip = new FlipCoins();
            flip.HaidTail();

            Console.WriteLine("\n***********************Leap Year Program*****************************");
            LeapYear leap = new LeapYear();
            leap.Leap();

            Console.WriteLine("\n***********************Power of Two***********************************");
            PowerOfTwo pwr = new PowerOfTwo();
            pwr.PowerTwo();

            Console.WriteLine("\n***********************Prime Factors**********************************");
            primeFactor prime = new primeFactor();
            prime.Factor();

        }
    }
}