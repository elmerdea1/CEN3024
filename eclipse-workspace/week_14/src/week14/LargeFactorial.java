package week14;

import java.math.BigInteger;

/**
 * @author Elmer Dea
 *
 */
public class LargeFactorial 
{
	/**
	 * @param input value to get factorial of
	 * @return result the factorial
	 */
	public static BigInteger factorial(long input)
	{
		BigInteger result = BigInteger.valueOf(input);
		//if result is greater than 1
		if (result.compareTo(BigInteger.valueOf(1)) > 0)
		{
			//recursively multiply with one less than that value (repeatedly until 1)
			result = result.multiply(factorial(input-1));
		}
		return result;
	}
}
