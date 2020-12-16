using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class SMSPanel : MonoBehaviour {

    public RectTransform SMSMainPanel;
    public RectTransform SMSDetailsPanel;
    public RectTransform hamburgerMenu;
    public RectTransform BuySMSPanel;

    public GameObject expandButton1;
    public GameObject expandButton2;

    public GameObject itemContent1;
    public GameObject itemContent2;


    public void OnSMSDetailsButtonClicked()
    {
        SMSDetailsPanel.DOAnchorPos(Vector2.zero, 0.25f);
        SMSMainPanel.DOAnchorPos(new Vector2(-1150f, 0f), 0.5f);
        //SMSMainPanel.gameObject.SetActive(false);
    }

    public void OnBuySMSButton1Clicked()
    {
        BuySMSPanel.DOAnchorPos(Vector2.zero, 0.25f);
        SMSMainPanel.DOAnchorPos(new Vector2(-1150f, 0f), 0.5f);
    }

    public void OnBuySMSBackButtonClicked()
    {
        BuySMSPanel.DOAnchorPos(new Vector2(1800f, 0f), 0.5f);

        itemContent1.SetActive(false);
        itemContent2.SetActive(false);

        expandButton1.SetActive(true);
        expandButton2.SetActive(true);
    }

    public void OnBuySMSButton2Clicked()
    {
        BuySMSPanel.DOAnchorPos(Vector2.zero, 0.25f);
        SMSDetailsPanel.DOAnchorPos(new Vector2(-1150f, 0f), 0.5f);
    }

    public void OnHeaderMenuClicked()
    {
        SMSMainPanel.DOAnchorPos(new Vector2(-1150f, 0f), 0.25f);
        hamburgerMenu.DOAnchorPos(Vector2.zero, 0.25f);
    }
}
