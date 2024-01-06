
namespace _100days_c_
{
    internal class day_2_of_100
    {
        static void Main(string[] args)
        {
            //this program ask for a temperature degree which it covert to calcius and ferhant
            Console.WriteLine("type in a temperature degree");
            string readResult = Console.ReadLine();
            if (double.TryParse(readResult, out double number))
            {
                double fahrenheit = (number * 9 / 5) + 32;
                double celcius = (number - 32) * 5 / 9;

                //the output
                Console.WriteLine($"the convation of temprature {readResult} degree is {fahrenheit} in fahrenheit and {celcius} degree in celcius");
            }
            else { Console.WriteLine(" invalid input"); }
        }
    }
}
