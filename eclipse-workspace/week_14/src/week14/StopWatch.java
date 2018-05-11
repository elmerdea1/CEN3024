package week14;

/**
 * logs time and finds difference
 * @author Elmer Dea
 */
public class StopWatch 
{
	private long m_startTime;
	private long m_stopTime;
	
	/**
	 * constructor
	 */
	public StopWatch()
	{
		
	}
	
	/**
	 * log start time
	 */
	public void start()
	{
		m_startTime = System.currentTimeMillis();
	}
	
	/**
	 * log end time
	 */
	public void stop()
	{
		m_stopTime = System.currentTimeMillis();
	}
	
	/**
	 * @return start time
	 */
	public long getStartTime()
	{
		return m_startTime;
	}
	
	/**
	 * @return end time
	 */
	public long getStopTime()
	{
		return m_stopTime;
	}
	
	/**
	 * @return difference in start and end times
	 */
	public long getElapsedTimeMilliSeconds()
	{
		return m_stopTime - m_startTime;
	}
}
