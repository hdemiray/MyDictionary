using System;
using System.Collections.Generic;
using System.Text;

public class MyDictionary<TKey, TValue>
{
	//Create 2 array for key and value
	TKey[] Keys;
	TValue[] Values;

	public MyDictionary()
	{
		Keys = new TKey[0];
		Values = new TValue[0];
	}

	public void Add(TKey key, TValue value)
	{
		TKey[] tempKey = Keys;
		TValue[] tempValue = Values;

		Keys = new TKey[Keys.Length + 1];
		Values = new TValue[Values.Length + 1];

		for (int i = 0; i < tempKey.Length; i++)
		{
			Keys[i] = tempKey[i];
			Values[i] = tempValue[i];
		}

		Keys[Keys.Length - 1] = key;
		Values[Values.Length - 1] = value;
	}
	public int Count { get { return Keys.Length; } }
	
	public TValue GetValue(int key)
	{
		return Values[key];
	}
}