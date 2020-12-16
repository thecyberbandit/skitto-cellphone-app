using UnityEngine;
using UnityEngine.UI;

public class DisplaySelectedContent : MonoBehaviour
{
	public BaseListBank contentBank;
	public Text displayText;

	public void SetDisplayText(int contentID)
	{
		displayText.text = "Selected content: ";
		displayText.text += contentBank.GetListContent(contentID);
	}
}
