using System;
using System.Collections.ObjectModel;
using SightWords;

public class WordList
{
	private ObservableCollection<SightWord> _list;

	public WordList()
	{
		this._list = new ObservableCollection<SightWord>();

		this.initializeList();
	}

	internal void initializeList()
    {
		this._list.Add(new SightWord("a"));
    }

	public string toString()
    {
		return this._list[0].toString();
    }
}
