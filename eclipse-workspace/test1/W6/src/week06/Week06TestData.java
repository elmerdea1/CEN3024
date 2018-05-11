package week06;

public class Week06TestData 
{
	private long m_M;
	private long m_N;
	private long m_expected;
	private boolean m_expectException;
	
	public Week06TestData(long m, long n, long expected, boolean exceptionExpected)
	{
		m_M = m;
		m_N = n;
		m_expected = expected;
		m_expectException = exceptionExpected;
	}

	public long getM() {
		return m_M;
	}

	public long getN() {
		return m_N;
	}

	public long getExpected() {
		return m_expected;
	}

	public boolean expectIllegalArgumentException(){
		return m_expectException;
	}
}
