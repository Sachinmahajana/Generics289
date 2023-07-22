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
                case 2:
                    FindMaxminFloat.FindMaxMinFloatFunction(50.3f, 40.2f, 30.4f);
                    break;
                case 3:
                    FindMaxminstring.FindMaxstringFunction("Apple", "Peach", "banana");
                    break;
                case 4:
                    FindMaxvalue<int>.Testmaximum(30, 40, 50 );
                    FindMaxvalue<float>.Testmaximum(50.4f, 40.2f, 33.6f);
                    FindMaxvalue<string>.Testmaximum("Suresh", "Ajay", "Nikam");
                    break;

                default:
                    Console.WriteLine("Please select the program given below");
                    break;
            }
        }
    }
}