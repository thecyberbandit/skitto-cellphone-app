using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpMenu : MonoBehaviour {

    public RectTransform content;
    public RectTransform imageMain;
    public RectTransform imageHelp;


    public void OnHelpActivateClicked()
    {
        Vector3 contentPos = content.anchoredPosition;
        contentPos.y = 2765.1f;
        content.anchoredPosition = contentPos;
        content.sizeDelta = new Vector2(content.sizeDelta.x, 4470.7f);

        imageMain.offsetMax = new Vector2(imageMain.offsetMax.x, 183.7f);
        imageMain.offsetMin = new Vector2(imageMain.offsetMin.x, 399.79f);

        imageHelp.gameObject.SetActive(true);

        imageHelp.localPosition = new Vector3(-9.25f, -1887.8f, imageMain.localPosition.z);
        Vector3 helpPos = imageHelp.anchoredPosition;
        helpPos.x = -9.25f;
        helpPos.y = -1887.8f;
        imageHelp.anchoredPosition = helpPos;
        imageHelp.sizeDelta = new Vector2(1063f, 911.3f);
    }

    public void OnHelpDeactivateClicked()
    {
        Vector3 contentPos = content.anchoredPosition;
        contentPos.y = 2263.4f;
        content.anchoredPosition = contentPos;
        content.sizeDelta = new Vector2(content.sizeDelta.x, 3969f);

        imageMain.offsetMax = new Vector2(imageMain.offsetMax.x, 0f);
        imageMain.offsetMin = new Vector2(imageMain.offsetMin.x, 0f);

        imageHelp.gameObject.SetActive(false);
    }
}
