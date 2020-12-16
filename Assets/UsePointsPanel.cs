using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UsePointsPanel : MonoBehaviour {

    public GameObject popupPanel;
    public GameObject purchasePanel;

    public RectTransform usePointPanel;

    public Text popupText;
    public Text purchaseText;


    public void OnCoolClicked()
    {
        Camera.main.backgroundColor = Color.yellow;
        usePointPanel.DOAnchorPos(new Vector2(1150f, 0f), 0f);
    }

    public void OnBuyButton1Clicked()
    {
        popupText.text = "You will be using 50 skitpoints to purchase reward pack 500 MB with 3 days validity";
        purchaseText.text = "You have used 50 skitpoints to purchase reward pack 500 MB with 3 days validity. yayyy!";
        popupPanel.SetActive(true);
    }

    public void OnBuyButton2Clicked()
    {
        popupText.text = "You will be using 300 skitpoints to purchase reward pack 1 GB with 3 days validity";
        purchaseText.text = "You have used 300 skitpoints to purchase reward pack 1 GB with 3 days validity. yayyy!";
        popupPanel.SetActive(true);
    }

    public void OnBuyButton3Clicked()
    {
        popupText.text = "You will be using 180 skitpoints to purchase reward pack 100 MB with 3 days validity";
        purchaseText.text = "You have used 180 skitpoints to purchase reward pack 100 MB with 3 days validity. yayyy!";
        popupPanel.SetActive(true);
    }
}
