package week10;

import week10.AbstractSort;

/**
 * @author Scott LaChance
 * @version 1.0
 * @created 13-Mar-2016 9:12:01 PM
 */
public class SelectionSort extends AbstractSort
{
	/**
	 * Default constructor
	 */
	public SelectionSort()
	{
		super("Selection Sort");
	}

	public void finalize() throws Throwable
	{
		super.finalize();
	}

	/**
	 * Sorts an integer array
	 *
	 * @return sorted list
	 */
	public int[] sort(int[] integerArray)
	{
		int minIndex;
        int length;
        int temp;
        int i;
        length = integerArray.length;

        for(int startIndex = 0; startIndex < length - 1; startIndex++)
        {
            // each iteration of the for loop is one pass
            minIndex = startIndex;

            // find the smallest in this pass at
            // position minIndex
            for(i = startIndex + 1; i < length; i++)
            {
                if(integerArray[i] < integerArray[minIndex])
                {
                    minIndex = i;
                }
            }

            // exchange number[startIndex] and number[minIndex]
            temp = integerArray[startIndex];
            integerArray[startIndex] = integerArray[minIndex];
            integerArray[minIndex] = temp;
        }

        return integerArray;
	}
}// end SelectionSort
