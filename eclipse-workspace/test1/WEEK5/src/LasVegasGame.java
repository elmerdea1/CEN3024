

import java.util.Random;

public class LasVegasGame {

	public enum GUESS {
		BETWEEN, NOT_BETWEEN
	
	}
	
	private boolean m_gamewon;
	private int m_hiInt = 0;
	private int m_losers = 0;
	private int m_lowInt = 0;
	private int m_nextInt = 0;
	private Random m_random = new Random();
	private int m_winners = 0;
	private final int MAX_RANGE = 100;
	private final String END_GAME = String.format("Winners %d, Losers %d",m_winners, m_losers);

	public int[] startGame() {
		generateRandomInts();
		m_lowInt = m_nextInt;
		generateRandomInts();
		m_hiInt = m_nextInt;
		if (m_lowInt == m_hiInt)
		{
			startGame();
		}
		if (m_lowInt > m_hiInt)
		{
			int tempLow = m_lowInt;
			m_lowInt = m_hiInt;
			m_hiInt = tempLow;
		}
		return new int[] {m_lowInt, m_hiInt};
	}

	public void startSession() {
		m_losers = 0;
		m_winners = 0;
		
	}

	public String endSession() {
		return END_GAME;
	}

	public int getWinnerCount() {
		return m_winners;
	}

	public int getLosersCount() {
		return m_losers;
	}

	public boolean guess(GUESS guess) 
	{
		generateRandomInts();
		if (guess.equals(GUESS.BETWEEN))
		{
			if (m_nextInt > m_lowInt && m_nextInt < m_hiInt)
			{
				m_winners+=1;
				return true;
			}
		}
		if (guess.equals(GUESS.NOT_BETWEEN))
		{
			if (m_nextInt > m_hiInt || m_nextInt < m_lowInt)
			{
				m_winners+=1;
				return true;
			}
		}
		m_losers+=1;
		return false;
	}
	
	private void generateRandomInts() {
		m_nextInt = m_random.nextInt(MAX_RANGE) + 1;	//avoids 0
	}
}
