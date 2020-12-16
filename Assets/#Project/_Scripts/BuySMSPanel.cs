using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class BuySMSPanel : MonoBehaviour {

    public GameObject weekly;
    public GameObject daily;
    public Scrollbar buySMSScrollbar;

    public RectTransform buySMSPanel;
    public RectTransform smsMainPanel;

    public GameObject smsPieCircle;

    public GameObject bodyPanel1;
    public GameObject bodyPanel2;

    public GameObject weeklyPopupPanel;
    public GameObject weeklyPurchasePanel;
    public GameObject dailyPopupPanel;
    public GameObject dailyPurchasePanel;

    public GameObject itemContent1;
    public GameObject itemContent2;

    public GameObject expandButton1;
    public GameObject expandButton2;

    private Text weeklyText;
    private Text dailyText;

    private SMSRadialProgressBar smsBar;

    private void Start()
    {
        weeklyText = weekly.GetComponentInChildren<Text>();
        dailyText = daily.GetComponentInChildren<Text>();

        smsBar = smsPieCircle.GetComponent<SMSRadialProgressBar>();
    }

    private void Update()
    {
        if (buySMSScrollbar.value < 0.2f)
        {
            weekly.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
            daily.transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);

            weeklyText.color = new Color32(255, 243, 0, 255);
            dailyText.color = Color.white;

            bodyPanel1.SetActive(true);
            bodyPanel2.SetActive(false);
        }

        else if (buySMSScrollbar.value > 0.8f)
        {
            daily.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
            weekly.transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);

            dailyText.color = new Color32(255, 243, 0, 255);
            weeklyText.color = Color.white;

            bodyPanel1.SetActive(false);
            bodyPanel2.SetActive(true);
        }
    }

    public void OnWeeklyBuyClicked()
    {
        weeklyPopupPanel.SetActive(true);
    }

    public void OnDailyBuyClicked()
    {
        dailyPopupPanel.SetActive(true);
    }

    public void OnWeeklyYupClicked()
    {
        weeklyPopupPanel.SetActive(false);
        weeklyPurchasePanel.SetActive(true);
    }

    public void OnDailyYupClicked()
    {
        dailyPopupPanel.SetActive(false);
        dailyPurchasePanel.SetActive(true);
    }

    public void OnShowMeClicked()
    {
        buySMSPanel.DOAnchorPos(new Vector2(1800f, 0f), 0.25f);
        smsMainPanel.DOAnchorPos(Vector2.zero, 0.25f);

        smsBar.amount = 0;

        weeklyPurchasePanel.SetActive(false);
        dailyPurchasePanel.SetActive(false);

        itemContent1.SetActive(false);
        itemContent2.SetActive(false);

        expandButton1.SetActive(true);
        expandButton2.SetActive(true);
    }
}
