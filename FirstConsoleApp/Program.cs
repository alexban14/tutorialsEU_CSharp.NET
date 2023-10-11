public class FirstConsoleApp
{
    public static void Main()
    {
        float vat = 19f;
        float productA = 3.99f;
        float productB = 11.99f;
        float productC = 5.75f;

        float summed = productA + productB + productC;

        // vat required
        float totalTax = (summed / 100) * vat;

        summed += totalTax;

        Console.WriteLine("Total price is: " + summed);
    }
}