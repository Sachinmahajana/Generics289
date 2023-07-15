namespace Generics289
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the generics program");
            Console.WriteLine("Select the program given below");
            Console.WriteLine("\n1:Findmaxint");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FindMaxint.FindMaxintFunction(50, 20, 30);
                    break;
            }
        }
    }
}