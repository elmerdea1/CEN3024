package week11;

import java.io.File;
import java.io.FileWriter;
import java.io.BufferedWriter;
import java.io.IOException;
import java.nio.charset.Charset;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;

/**
 * @author Elmer Dea
 *
 */
public class FileProcessor 
{
	String FILENAME = "Week11.txt";
	
	/**
	 * constructor
	 */
	public FileProcessor()
	{
		
	}
	
	/**
	 * @param text to write to file
	 * @return path and file name
	 * @throws FileProcessingException
	 */
	public String saveTextContent(String text) throws FileProcessingException
	{
//		String path = Paths.get(System.getProperty("user.home") + File.separator + FILENAME);
//		Files.createFile(path);
		try (BufferedWriter writer = new BufferedWriter(new FileWriter(FILENAME))) 
		{
		    writer.write(text, 0, text.length());
		} 
		catch (IOException x) 
		{
		    System.err.format("IOException: %s%n", x);
		}	
		return FILENAME;
	}
}

