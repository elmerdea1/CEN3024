package week10;


/**
 * sorts and times different sorting algorithms
 * @author Elmer Dea
 */
public class SortUtility 
{
	private SORT_ALGORITHM_TYPE m_sortAlgorithmType;
	private Stopwatch m_watch;
	private long m_elapsedTime = 0;
	
	/**
	 * @return elapsed time from stopwatch
	 */
	public long getElapsedTime()
	{
		return m_elapsedTime;
	}
	
	/**
	 * @param type of algorithm to sort with
	 * @return algorithm object of that type
	 * @throws NotImplementedException if the algorithm doesn't exist
	 */
	private AbstractSort getSortAlgorithm(SORT_ALGORITHM_TYPE type) throws NotImplementedException
	{
		AbstractSort sort = new SelectionSort();
		switch(type)
		{
			case SELECTION:
				sort = new SelectionSort();
				break;
			case QUICK:
				sort = new QuickSort();
				break;
			default:
				throw new NotImplementedException("This sorting algorithm does not exist");
		}
		return sort;
	}
	
	/**
	 * @param integerList to sort
	 * @param type of sort to apply
	 * @return sorted list
	 * @throws NotImplementedException if sort type is invalid
	 */
	public int[] sort(int[] integerList, SORT_ALGORITHM_TYPE type) throws NotImplementedException
	{
		AbstractSort algo = getSortAlgorithm(type);
		m_watch.start();
		int[] sortedList = algo.sort(integerList);
		m_watch.stop();
		
		m_elapsedTime = m_watch.getElapsedTimeMilliSeconds();
		return sortedList;
	}
	
	/**
	 * construct with a blank stopwatch object
	 */
	public SortUtility()
	{
		m_watch = new Stopwatch();
	}

}
