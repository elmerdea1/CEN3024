package week12;

/**
 * @author Elmer Dea
 *
 */
public class LoginRequest extends Week12Object
{
	private long m_accountId;
	private int m_pin;
	
	/**
	 * @return accountId getter
	 */
	public long getAccountId() 
	{
		return m_accountId;
	}

	/**
	 * @param m_accountId setter
	 */
	public void setAccountId(long m_accountId) 
	{
		this.m_accountId = m_accountId;
	}

	/**
	 * @return pin getter
	 */
	public int getPin() 
	{
		return m_pin;
	}

	/**
	 * @param m_pin setter
	 */
	public void setPin(int m_pin) 
	{
		this.m_pin = m_pin;
	}

	/**
	 * constructor, 2 factor id
	 * @param pin 
	 * @param accountId
	 */
	public LoginRequest(int pin, long accountId)
	{
		m_pin = pin;
		m_accountId = accountId;
	}

	@Override
	public boolean equals(Object obj) 
	{
		boolean result = false;
		if( obj instanceof LoginRequest)
		{
			LoginRequest rhs = (LoginRequest)obj;
			
			if( this.getPin() == rhs.getPin() &&
				this.getAccountId() == rhs.getAccountId())
			{
				result = true;
			}
		}
		
		return result;
	}
	
}
