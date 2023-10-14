using System;

public class NestedLoops
{
	public NestedLoops()
	{
		int[,] matrix =
		{
			{1, 2, 3 },
			{4, 5, 6 },
			{7, 8, 9 },
		};

		Console.WriteLine("\n Foreach looping the matrix");
		foreach (int item in matrix)
		{
            Console.Write(item + " ");
        }

		Console.WriteLine("\n Looping thru the matrix with nested for loops");
		// we get the length of the array for the first dimension
		// the first loop goes itterates over the rows
		for (int i = 0; i < matrix.GetLength(0); i++)
		{
			// this second loop goes thru the columns
			for (int j = 0; j < matrix.GetLength(1); j++)
			{
				Console.Write(matrix[i, j] + " ");
			}
		}

		Console.ReadKey();
	}
}
