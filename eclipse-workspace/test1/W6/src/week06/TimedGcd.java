package week06;

public class TimedGcd 
{
	private long m_elapsedTime;
	private long m_gcdValue;
	
	public TimedGcd()
	{
		
	}
	
	public long getElapsedTime() 
	{
		return m_elapsedTime;
	}
	
	
	
	public long getGcdValue()
	{
		return m_gcdValue;
	}
	
	public void start(long m, long n) throws IllegalArgumentException
	{
		if (m < 1 || n < 1)
		{
			throw new IllegalArgumentException();
		}
		long startTime = System.nanoTime();
		m_gcdValue = getGcdBreak(m, n);
		m_elapsedTime = System.nanoTime() - startTime;	
	}
	
	private long getGcdBreak(long m, long n) 
	{
		long remainder;
		while (true)
		{
			remainder = n%m;
			if (remainder ==0)
			{
				break;
			}
			n = m;
			m = remainder;
		}
		return m;
	}
//	private void validateParameters(long m, long n) throws IllegalArgumentException
//	{
//		
//	}
//	
//	private long timeMethod(long m, long n)
//	{
//		
//	}
//	

	
	
}
