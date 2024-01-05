//A program that write a welcome message to a name given by the user
namespace _100days_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please type in your name");
            String readResult = Console.ReadLine();
            Console.WriteLine($"Thank you {readResult} for being a part of my 100 days c# code challange");
            Console.WriteLine(" see you tommorow");
        }
    }
}
