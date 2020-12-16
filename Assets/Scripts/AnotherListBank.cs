using UnityEngine;

public class AnotherListBank : BaseListBank
{
	private int[] _contents = {
		1, 2, 3
	};

	public override string GetListContent(int index)
	{
		return _contents[index].ToString();
	}

	public override int GetListLength()
	{
		return _contents.Length;
	}
}
