using System;
using System.Collections;

public class ArrayListsC
{
	public ArrayListsC()
	{
		// ArrayList with undefined amount of objects
		ArrayList firstArrayList = new ArrayList();

		// ArrayList with defined amount of objects
		ArrayList secondArrayList = new ArrayList(100);

		firstArrayList.Add(25);
		firstArrayList.Add("Hello");
		firstArrayList.Add(13.37);
		firstArrayList.Add(13);
		firstArrayList.Add(128);
		firstArrayList.Add(25.3);
		firstArrayList.Add(13);

		// delete specific value
		firstArrayList.Remove(13);

		// delete element at specific position
		firstArrayList.RemoveAt(0);

		// count the object within the ArrayList
		Console.WriteLine(firstArrayList.Count);

		double sum = 0;
		foreach(object obj in firstArrayList)
		{
            // converting the object to a double if is a type int
			if (obj is int)
			{
				sum += Convert.ToDouble(obj);
			} else if (obj is double)
			{
				/* we need to cast the object to a double
				before adding it to the sum, else the compile will complain */
				sum += (double)obj;
			} else if (obj is string)
			{
				Console.WriteLine(obj);
			}
		}

		Console.WriteLine(sum);

		Console.ReadKey();
	}
}
