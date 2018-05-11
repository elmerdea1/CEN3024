package week07;

public class Week07Singleton 
{
	public static Week07Singleton getInstance()
	{
		return m_instance;
	}
	
	protected Week07Singleton()
	{
		
	}
	
	private final static Week07Singleton m_instance = new Week07Singleton();
}
