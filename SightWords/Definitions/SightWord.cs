using System;
using SightWords;

public class SightWord
{

    private DolchLevel _level;
    private string _word;

	public SightWord()
	{
	}

	public SightWord(DolchLevel level)
    {
		this._level = level;
    }

	public SightWord(string word)
    {
		this._word = word;
    }

    public string toString()
    {
		return this._word;
    }

}
