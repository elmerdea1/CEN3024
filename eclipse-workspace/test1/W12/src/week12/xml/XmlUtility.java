package week12.xml;


import java.io.StringReader;

import org.jdom2.Document;
import org.jdom2.input.SAXBuilder;

import week12.Week12Exception;
import week12.Week12Object;

public class XmlUtility 
{
	public XmlUtility()
	{
		
	}
	
	static Document objectToXml(Week12Object obj) throws Week12Exception
	{
		
	}
	
	static Week12Object xmlToObject(Document dom) throws Week12Exception
	{
		String myxml = dom;
		SAXBuilder sax = new SAXBuilder();
		Document doc;
		doc = sax.build(new StringReader(myxml));

		return doc;
	}
	
	
	
}
