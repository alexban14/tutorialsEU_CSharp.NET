using System;

public class Arrays
{
	public Arrays()
	{
		// intializing an array with a fixed size and no values
		int[] grades = new int[5];

		grades[0] = 20;
		grades[1] = 15;
		grades[2] = 12;
		grades[3] = 9;
		grades[4] = 7;
		Console.WriteLine("grade at index 0: {0}", grades[0]);

		string input = Console.ReadLine();
		grades[0] = int.Parse(input);
		Console.WriteLine("grade at index 0 after input: {0}", grades[0]);

		// initializing an array with the actual values
		int[] gradesOfMathStudentsA = { 20, 13, 12, 8, 8 };

		// third way of initializing an arra
		int[] gradesOfMathStudentsB = new int[] { 13, 30, 24, 12, 7, 9, 4 };

		// using the Length property on an array to get the number of elements in the array
		Console.WriteLine("Length of gradesOfMathStudentsA: {0}", gradesOfMathStudentsA.Length);

		// looping thru an array
		for (int i = 0; i < gradesOfMathStudentsB.Length; i++)
		{
            Console.WriteLine("Element {0} from the array = {1}", i, gradesOfMathStudentsB[i]);
        }

		//foreach loop
		int counter = 0;
		foreach(int k in gradesOfMathStudentsA)
		{
            Console.WriteLine("Element {0} from the array = {1}", counter, gradesOfMathStudentsA[counter]);
			counter++;
		}

		string[] myFriends = { "Michael", "Wlad", "Ilja", "Andy", "Daniel" };
		foreach(string name in  myFriends)
		{
			Console.WriteLine("Hello there {0}, my friend!", name);
		}

		Console.ReadKey();
	}
}
