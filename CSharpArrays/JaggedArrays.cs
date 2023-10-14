using System;

public class JaggedArrays
{
	public JaggedArrays()
	{
		// creating a Jagged array -> storing multiple arrays within an array
		int[][] jaggedArray = new int[3][];
		// we declared that we want to have 3 arrays stored within the array

		jaggedArray[0] = new int[5];
		jaggedArray[1] = new int[3];
		jaggedArray[2] = new int[2];

		// intializing the values within the stored sub-arrays
		jaggedArray[0] = new int[] { 2, 3, 5, 7, 11 };
		jaggedArray[1] = new int[] { 1, 2, 3 };
		jaggedArray[2] = new int[] { 13, 21 };

		// alternative way
		int[][] secondJaggedArray = new int[][]
		{
			new int[] { 2, 3, 5, 7, 11 },
			new int[] { 1, 2, 3 }
		};

        Console.WriteLine("The value in the middle of the first entry: {0}", secondJaggedArray[0][2]);

		Console.WriteLine("logging all the values within the Jagged array");
		for (int i = 0; i < secondJaggedArray.Length; i++)
		{
			Console.WriteLine("Element {0}", i);
			for (int j = 0; j < secondJaggedArray[i].Length; j++)
			{
				Console.WriteLine(secondJaggedArray[i][j] + " ");
			}
		}

		Console.ReadKey();
    }
}
