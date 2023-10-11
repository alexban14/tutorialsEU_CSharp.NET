public class CheckTempApp
{
    /*
     * 
     */
    public static void Main(string[] args)
    {
        Console.WriteLine("What's the temperature like");
        var temperature = Console.ReadLine();
        int numTemp;
        int number;

        if (int.TryParse(temperature, out number))
        {
            numTemp = number;
        }
        else
        {
            numTemp = 0;
            Console.WriteLine("Value entered is not a number");
        }

        if (numTemp < 20)
        {
            Console.WriteLine("Take the coat");
        } else if (numTemp == 20) 
        {
            Console.WriteLine("Pants and pullover should be fine");
        } else if (numTemp > 30)
        {
            Console.WriteLine("It's super hot!");
        } else
        {
            Console.WriteLine("Shorts are enough today");
        }
    }
}