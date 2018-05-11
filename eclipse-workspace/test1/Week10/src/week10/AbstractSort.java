package week10;

/**
 * abstract class for sorting algorithms
 * @author Elmer Dea
 */
public abstract class AbstractSort 
{
	private String m_name;
	
	/**
	 * @param name name of sort algorithm class
	 */
	public AbstractSort(String name)
	{
		m_name = name;
	}
	
	/**
	 * abstract method
	 * @param input array to sort
	 * @return sorted array
	 */
	abstract public int[] sort(int[] input);
	
	/**
	 * @return name of algorithm
	 */
	public String getSortName()
	{
		return m_name;
	}
}
