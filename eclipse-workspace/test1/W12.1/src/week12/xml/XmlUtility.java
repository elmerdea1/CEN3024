package week12.xml;


import org.jdom2.Document;
import org.jdom2.Attribute;
import org.jdom2.Element;

import week12.LoginRequest;
import week12.LoginResponse;
import week12.Week12Exception;
import week12.Week12Object;

/**
 * @author Elmer Dea
 *
 */
public class XmlUtility 
{
	/**
	 * constructor
	 */
	public XmlUtility()
	{
		
	}
	
	/**
	 * @param obj object to convert
	 * @return xml document
	 * @throws Week12Exception if week12object type not found
	 */
	public static Document objectToXml(Week12Object obj) throws Week12Exception
	{
		Document dom = new Document();
		
		if (obj instanceof LoginRequest)
		{
			dom = generateLoginRequestXml((LoginRequest)obj);
		}
		else if (obj instanceof LoginResponse)
		{
			dom = generateLoginResponseXml((LoginResponse)obj);
		}
		else 
		{
			throw new Week12Exception("Unknown Week12Object");
		}
		return dom;
	}
	
	/**
	 * @param dom xml document to convert
	 * @return atmObject java object
	 * @throws Week12Exception if week12object type not found
	 */
	public static Week12Object xmlToObject(Document dom) throws Week12Exception
	{
		Week12Object atmObject = null;
		
		Element root = dom.getRootElement();
		String elementName = root.getName();
		try
		{
			if (elementName.equals("login-request"))
			{
				atmObject = getLoginObject(root);
			}
			else if (elementName.equals("login-response"))
			{
				atmObject = getLoginResponseObject(root);
			}
		}
		catch(NumberFormatException ex)
		{
			throw new Week12Exception(ex);
		}

		return atmObject;
	}
	
	/**
	 * @param response week12object of loginResponse type
	 * @return dom xml version of response
	 */
	private static Document generateLoginResponseXml(LoginResponse response)
	{
		Document dom;
		Element root = new Element("login-response");
		Attribute version = new Attribute("version", "1.0");
		root.setAttribute(version);
		String loggedInFmt = response.getLoggedIn().toString();
		Attribute loggedIn = new Attribute("logged-in", loggedInFmt);
		root.setAttribute(loggedIn);
		String sessionFmt = String.format("%d", response.getSessionId());
		Attribute account = new Attribute("session-id", sessionFmt);
		root.setAttribute(account);
		
		dom = new Document(root);
		return dom;
	}
	

	/**
	 * @param request week12object of loginRequest type
	 * @return dom xml version of request
	 */
	private static Document generateLoginRequestXml(LoginRequest request)
	{
		Document dom;
		Element root = new Element("login-request");
		Attribute version = new Attribute("version", "1.0");
		root.setAttribute(version);
		String pinFmt = String.format("%d", request.getPin());
		Attribute pin = new Attribute("pin", pinFmt);
		root.setAttribute(pin);
		String accountIdFmt = String.format("%d", request.getAccountId());
		Attribute accountId = new Attribute("account-id", accountIdFmt);
		root.setAttribute(accountId);
		
		dom = new Document(root);
		return dom;
	}	
	
	/**
	 * @param root containing attributes
	 * @return a newly created loginResponse
	 * @throws NumberFormatException for incorrect conversion 
	 */
	private static Week12Object getLoginResponseObject(Element root) throws NumberFormatException
	{
		String loggedInString = root.getAttributeValue("logged-in");
		String sessionIdString = root.getAttributeValue("session-id");
		boolean loggedIn = Boolean.parseBoolean(loggedInString);
		int accountId = Integer.parseInt(sessionIdString);
		return new LoginResponse(loggedIn, accountId);
	}
	
	/**
	 * @param root containing attributes
	 * @return a new created longRequest
	 */
	private static Week12Object getLoginObject(Element root)
	{
		String accountIdString = root.getAttributeValue("account-id");
		String pinString = root.getAttributeValue("pin");
		long accountId = Long.parseLong(accountIdString);
		int pin = Integer.parseInt(pinString);
		return new LoginRequest(pin, accountId);
	}
	
}
