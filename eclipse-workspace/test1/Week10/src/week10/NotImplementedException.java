package week10;

/**
 * exception class for when a type of sort is not found
 * @author Elmer Dea
 */
public class NotImplementedException extends Exception
{
	public NotImplementedException()
	{
		
	}
	
	/**
	 * @param arg0 message
	 */
	public NotImplementedException(String arg0)
	{
		super(arg0);
	}
	
	/**
	 * @param arg0 message 
	 * @param arg1 cause
	 */
	public NotImplementedException(String arg0, Throwable arg1)
	{
		super(arg0,arg1);
	}
}
