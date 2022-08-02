namespace TypeCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type Casting");
            int a = 51;
            float f = a;
            Console.WriteLine("Int to float data type "+f);
            Console.WriteLine("Enter your name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter 1st number");
            float d = float.Parse(Console.ReadLine());

            //************Concat**************
            string c = "50";
            string b = "25";
            Console.WriteLine(c+b);
            Console.WriteLine("Hello" + "" + "String" + "!");

            //*****Interpolation*********
            string author = "Ajay";
            string book = "C# pogramming";
            string bookAuthor = $"{author} is the author of book {book}";
            Console.WriteLine(bookAuthor);

            //*****InBuilt Concat**********
            string fistName = "ajay";
            string LastName = "Rathod";
            Console.WriteLine(string.Concat(fistName,LastName));

        }
    }
}