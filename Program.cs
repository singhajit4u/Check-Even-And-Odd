namespace Check_Even_And_Odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to test whether it is EVEN or ODD:");
            int dividend = Convert.ToInt32(Console.ReadLine());
            

            if (dividend % 2 == 0)
            {
                Console.WriteLine("The given number is EVEN");
            }
            else if (dividend % 2 == 1)
            {
                Console.WriteLine("The given number is ODD");
            }
            



        }
    }
}