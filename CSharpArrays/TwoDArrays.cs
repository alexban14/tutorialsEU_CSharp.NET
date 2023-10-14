using System;

namespace CSharpArrays;
public class TwoDArrays
{
	public TwoDArrays()
	{
        // declaring 2D array
        string[,] matrix;

        // declaring 3D array
        string[,,] threeD;

        int[,] array2D = new int[,]
        {
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };
        Console.WriteLine("Central value from 2D: {0}", array2D[1, 1]);

        string[,,] array3D = new string[,,]
        {
            {
                {"000", "001"},
                {"010", "011"},
            },
            {
                {"100", "101"},
                {"110", "111"}
            }
        };
        Console.WriteLine("Value from 3D array: {0}", array3D[1, 1, 0]);

        //assinging values to certain indexes in a 2D array
        string[,] array2DString = new string[3, 2]
        {
            { "one", "two"},
            { "three", "four" },
            { "five", "six" }
        };
        array2DString[1, 1] = "chicken";

        // get the number of dimensions the array has
        int dimensions = array2DString.Rank;

        Console.ReadKey();
    }

}
