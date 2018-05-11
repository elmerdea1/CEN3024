package week06;

import static org.junit.Assert.*;

import java.util.Date;

import org.junit.Test;

public class Week06JUnitTest 
{
	
	public Week06JUnitTest()
	{	
	}
	
	@Test
	public void testApplication() 
	{
			TimedGcd gcd = new TimedGcd();
			Date start = new Date();
			//boolean result = true;
			int run = 1;
			String curStatus = "";
			String m_result = "";
			
			Week06TestData[] m_testData = new Week06TestData[] 
			{
				new Week06TestData(4567820,2147483640,20,false),
				new Week06TestData(545690876L,3456901294L,2,false),
				new Week06TestData(546587619L,21474836121L,3,false),
				new Week06TestData(951987545L,21474836651L,1,false),
				new Week06TestData(10,5,5,false),
				new Week06TestData(1542354865L,3216548445L,5,false),
				new Week06TestData(-100,325,0,true),
				new Week06TestData(4951987545L,3216548445L,15,false),
				new Week06TestData(94951987542L, 33216548448L ,6,false)
			};
			for(Week06TestData x:m_testData)
			{
				long M = x.getM();
				long N = x.getN();
				long expectedGcd = x.getExpected();
				try 
				{
					gcd.start(M, N);
					if (gcd.getGcdValue() != expectedGcd)
					{
						fail("GCD: " + gcd.getGcdValue() + " when expected GCD: " + expectedGcd);
					}
					trace("Test Run " + run);
					trace("M: " + M + ", N: " + N);
					trace("Euclid time: " + gcd.getElapsedTime());
					if(x.expectIllegalArgumentException())
					{
						
						fail(" Expected Invalid Argument Exception");
					}
					
				}
				catch(IllegalArgumentException ex)
				{
					trace("Test Run " + run);
					trace("M: " + M + ", N: " + N);
					if(x.expectIllegalArgumentException())
					{
						
						trace("Triggered Expected Invalid Argument Exception");
					}
					else
					{
						fail("Unexpected Invalid Argument Exception");
					}
				}
				run++;
			}
	}
	
	private void trace(String msg)
	{
		System.out.println(msg);
	}
}
