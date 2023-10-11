namespace Classes_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Human denis = new Human("Denis", "Rodman", "brown", 39);

            denis.IntroduceMyself();

            Console.ReadKey();
        }
    }
}