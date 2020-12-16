using UnityEngine;
using UnityEngine.UI;

public class GetCenteredContent : MonoBehaviour
{
	public ListPositionCtrl listA;
	public ListPositionCtrl listB;
	public ListPositionCtrl listC;
	public Text displayText;

	public void ShowSelectedContent()
	{
		string listAContent = listA.listBank.GetListContent(listA.GetCenteredContentID());
		string listBContent = listB.listBank.GetListContent(listB.GetCenteredContentID());
		string listCContent = listC.listBank.GetListContent(listC.GetCenteredContentID());

		displayText.text = "Selected content: ";
		displayText.text += listAContent + "-" + listBContent + "-" + listCContent;
	}
}
