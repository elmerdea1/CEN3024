package week12;

public class LoginRequest extends Week12Object
{
	private long m_accountId;
	private int m_pin;
	
	public long getAccountId() 
	{
		return m_accountId;
	}

	public void setAccountId(long m_accountId) 
	{
		this.m_accountId = m_accountId;
	}

	public int getPin() 
	{
		return m_pin;
	}

	public void setPin(int m_pin) 
	{
		this.m_pin = m_pin;
	}

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
