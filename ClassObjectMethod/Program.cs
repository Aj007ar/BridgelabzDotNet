namespace ClassObjectMethod
{
    internal class Program
    {
        int number = 20;
        int number2 = 10;
        private static float s;

        public int ReturnMethod()
        {
            int result = number + number2;
         
            return result;
        }
        public void ParameterMethod(string firstName)
        {
            Console.WriteLine("hello {0}",firstName);
        }
        public float ParameterReturnMethod(float var1,float var2)
        {
            float res = var1 + var2;

            return res;
        }
        public static void StaticMethod()
        {
            Console.WriteLine("Static method");
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            Console.WriteLine(obj.ReturnMethod());
            obj.ParameterMethod("Ajay");
            s=obj.ParameterReturnMethod(23.44f, 45.34f);
            Console.WriteLine(s);
            Program.StaticMethod();
    
            CalculatorMethod method=new CalculatorMethod();
            method.Addition();
            method.substraction();
            method.multiplication();
            method.division();
            //Console.WriteLine("Hello, World!");
        }
        
    }
}