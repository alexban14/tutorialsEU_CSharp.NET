public class UserInput
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Calculate());
        Console.Read();
    }

    public static int Calculate()
    {
        Console.WriteLine("Please enter the first number");
        string firstNumInput = Console.ReadLine();

        Console.WriteLine("Please enter the second number");
        string secondNumInput = Console.ReadLine();

        int firstNum = int.Parse(firstNumInput);
        int secondNum = int.Parse(secondNumInput);

        int result = firstNum + secondNum;
        return result;
    }
}
