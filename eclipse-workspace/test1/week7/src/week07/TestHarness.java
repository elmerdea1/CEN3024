package week07;

import java.util.List;

import org.junit.runner.Result;
import org.junit.runner.notification.Failure;

/**
 * This class executes the JUnit Test specified from the command line
 * This will be used by the reference system for testing your code.
 * 
 * @author Scott LaChance
 *
 */
public class TestHarness
{
	public static void main(String[] args)
	{
		testSingleton();
	}

	private static void testSingleton()
	{
		try
		{
			Result result = org.junit.runner.JUnitCore.runClasses(Week07JUnitTest.class);
			int failCount = result.getFailureCount();
			if( failCount > 0 )
			{
				List<Failure> failures = result.getFailures();
				for(Failure fail : failures)
				{
					trace("FAILED: " + fail.getMessage());
				}
			}
			else
			{
				trace("SUCCESS");
			}		
		}
		catch(Exception ex)
		{
			trace("Unexpected exception: " + ex.getMessage());
		}
	}
	
	private static void trace(String msg)
	{
		System.out.println(msg);
	}
}
