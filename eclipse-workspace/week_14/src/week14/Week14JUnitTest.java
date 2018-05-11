package week14;

import static org.junit.Assert.*;

import java.math.BigInteger;
import java.util.ArrayList;
import java.util.List;

import org.junit.Test;

/**
 * Tests the week14 application
 * 
 * @author Scott LaChance
 *
 */
public class Week14JUnitTest
{
	/**
	 * Pass in invalid guesses and get an InvalidArgumentException
	 */
	@Test
	public void testBigInteger()
	{
		trace("testBigInteger");

		setupTestData();
		StopWatch watch = new StopWatch();

		try
		{
			for(TestData data : m_testData)
			{
				int number = data.getFactorial();
				String expected = data.getExpected();

				watch.start();
				BigInteger result = LargeFactorial.factorial(number);
				watch.stop();
				long elapsed = watch.getElapsedTimeMilliSeconds();
				String actual = result.toString();
				String msg = String.format("%dms: %d! is ", elapsed, number);
				trace(msg);
				trace(actual);
				assertTrue(String.format("Factorial: %d, Expected: %s, Actual: %s", 
						number, expected, actual), 
						expected.equals(actual));
			}						
		}
		catch(Exception ex)
		{
			trace(ex.toString());
			fail("Error testBigInteger " + ex.getMessage());
		}
	}

	private void trace(String msg)
	{
		System.out.println(msg);
	}

	private void setupTestData()
	{
		m_testData = new ArrayList<TestData>();
		m_testData.add(new TestData(10, "3628800"));
		m_testData.add(new TestData(50, "30414093201713378043612608166064768844377641568960512000000000000"));
		m_testData.add(new TestData(100, "93326215443944152681699238856266700490715968264381621468592963895217599993229915608941463976156518286253697920827223758251185210916864000000000000000000000000"));
		m_testData.add(new TestData(500, "1220136825991110068701238785423046926253574342803192842192413588385845373153881997605496447502203281863013616477148203584163378722078177200480785205159329285477907571939330603772960859086270429174547882424912726344305670173270769461062802310452644218878789465754777149863494367781037644274033827365397471386477878495438489595537537990423241061271326984327745715546309977202781014561081188373709531016356324432987029563896628911658974769572087926928871281780070265174507768410719624390394322536422605234945850129918571501248706961568141625359056693423813008856249246891564126775654481886506593847951775360894005745238940335798476363944905313062323749066445048824665075946735862074637925184200459369692981022263971952597190945217823331756934581508552332820762820023402626907898342451712006207714640979456116127629145951237229913340169552363850942885592018727433795173014586357570828355780158735432768888680120399882384702151467605445407663535984174430480128938313896881639487469658817504506926365338175055478128640000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000"));
	}

	private List<TestData> m_testData = new ArrayList<TestData>();

	/**
	 * Represents a specific test data point
	 * @author Scott
	 */
	class TestData
	{
		TestData(int factorial, String expected)
		{
			m_factorial = factorial;
			m_expected = expected;
		}

		int getFactorial()
		{
			return m_factorial;
		}

		String getExpected()
		{
			return m_expected;
		}

		private int m_factorial;
		private String m_expected;
	}
}
