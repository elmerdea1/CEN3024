package week10;

/**
 * sorting algorithm
 * @author Elmer Dea
 */
public class QuickSort extends AbstractSort
{
	/**
	 * constructor
	 */
	public QuickSort()
	{
		super("QuickSort");
	}
	
	/**
	 * sort array
	 * @param input array to sort
	 * @return sorted array
	 */
	public int[] sort(int[] input)
	{
		quickSort(input, 0, input.length - 1);
		return input;
	}
	
	/**
	 * @param input array to sort
	 * @param low beginning index
	 * @param high ending index
	 * @return finally returns the sorted array after recursive runs
	 */
	private int[] quickSort(int[] input, int low, int high)
	{
		if (low < high)
		{
			int pi = partition(input, low, high);
			
			quickSort(input, low, pi-1);
			quickSort(input, pi + 1, high);
		}
		return input;
	}
	
	
	/**
	 * @param input (sub)array to partition
	 * @param low index of lower value
	 * @param high index of higher value
	 * @return array with positions of low/high values swapped (partially sorted)
	 */
	private int partition(int[] input, int low, int high)
	{
	    int pivot = input[high];  
	    int i = (low - 1); 
	    for (int j = low; j <= high- 1; j++)
	    {
	        if (input[j] <= pivot)
	        {
	            i++;    
	            int placeholder = input[i];
	            input[i] = input[j];
	            input[j] = placeholder;
	        }
	    }
		int placeholder = input[i + 1];
		input[i + 1] = input[high];
		input[high] = placeholder;
	    return (i + 1);
	}
	
}
