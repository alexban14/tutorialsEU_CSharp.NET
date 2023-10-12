namespace ClassProperties;

class Program
{
    static void Main(string[] args)
    {
        Box box = new Box(3, 4, 5);

        Console.WriteLine("Box Width is " + box.Width);
        box.Width = 10;
        Console.WriteLine("Box Width is " + box.Width);

        Console.WriteLine("Box volume is " + box.Volume);

        Console.ReadKey();
    }
}
