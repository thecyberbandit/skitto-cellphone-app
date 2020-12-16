using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class HamburgerHomePanel : MonoBehaviour {

    public RectTransform hamburgerHomePanel;
    public RectTransform balanceSharePanel;
    public RectTransform dataMixerPanel;
    public RectTransform referralPanel;
    public RectTransform myProfilePanel;
    public RectTransform settingsPanel;
    public RectTransform dataSharePanel;

    public RectTransform SMSPanel;
    public GameObject pieCircle;
    public GameObject dataPieCircle;
    public GameObject rewardsPieCircle;
    public GameObject scrollPanel;
    public GameObject helpContent;

    public RectTransform balanceDashboard;
    public RectTransform dataDashboard;
    public RectTransform promoDealsDashboard;
    public RectTransform rewardsDashboard;
    public RectTransform usageHistoryDashboard;

    public RectTransform ListBox;
    public RectTransform ListBox1;
    public RectTransform ListBox2;
    public RectTransform ListBox3;
    public RectTransform ListBox4;

    private SMSRadialProgressBar smsBar;
    private RadialProgressBar dataBar;
    private RadialProgressBar rewardsBar;
    private Animator helpAnim;


    void Start()
    {
        smsBar = pieCircle.GetComponent<SMSRadialProgressBar>();
        dataBar = dataPieCircle.GetComponent<RadialProgressBar>();
        rewardsBar = rewardsPieCircle.GetComponent<RadialProgressBar>();
        helpAnim = helpContent.GetComponent<Animator>();
    }

    public void OnBalanceClicked()
    {
        usageHistoryDashboard.gameObject.SetActive(false);
        dataDashboard.gameObject.SetActive(false);
        promoDealsDashboard.gameObject.SetActive(false);
        rewardsDashboard.gameObject.SetActive(false);

        hamburgerHomePanel.DOAnchorPos(new Vector2(-1150f, 0f), 0.25f);
        balanceDashboard.DOAnchorPos(Vector2.zero, 0.5f);
        ListBox.anchoredPosition = new Vector3(-1270.58f, 0, 0);
        ListBox1.anchoredPosition = new Vector3(-635.294f, 0, 0);
        ListBox2.anchoredPosition = new Vector3(0, 0, 0);
        ListBox3.anchoredPosition = new Vector3(635.2941f, 0, 0);
        ListBox4.anchoredPosition = new Vector3(1270.588f, 0, 0);

        ListBox2.localScale = new Vector3(1.75f, 1.75f, 1.75f);
    }

    public void OnDataClicked()
    {
        balanceDashboard.gameObject.SetActive(false);
        usageHistoryDashboard.gameObject.SetActive(false);
        promoDealsDashboard.gameObject.SetActive(false);
        rewardsDashboard.gameObject.SetActive(false);

        hamburgerHomePanel.DOAnchorPos(new Vector2(-1150f, 0f), 0.25f);
        dataDashboard.gameObject.SetActive(true);
        dataBar.amount = 0;
        dataDashboard.DOAnchorPos(Vector2.zero, 0.5f);
        ListBox.anchoredPosition = new Vector3(1270.58f, 0, 0);
        ListBox1.anchoredPosition = new Vector3(-1270.58f, 0, 0);
        ListBox2.anchoredPosition = new Vector3(-635.294f, 0, 0);
        ListBox3.anchoredPosition = new Vector3(0, 0, 0);
        ListBox4.anchoredPosition = new Vector3(635.294f, 0, 0);

        ListBox3.localScale = new Vector3(1.75f, 1.75f, 1.75f);
    }

    public void OnPromoDealsClicked()
    {
        balanceDashboard.gameObject.SetActive(false);
        dataDashboard.gameObject.SetActive(false);
        usageHistoryDashboard.gameObject.SetActive(false);
        rewardsDashboard.gameObject.SetActive(false);

        hamburgerHomePanel.DOAnchorPos(new Vector2(-1150f, 0f), 0.25f);
        promoDealsDashboard.gameObject.SetActive(true);
        promoDealsDashboard.DOAnchorPos(Vector2.zero, 0.5f);
        ListBox.anchoredPosition = new Vector3(635.294f, 0, 0);
        ListBox1.anchoredPosition = new Vector3(1270.58f, 0, 0);
        ListBox2.anchoredPosition = new Vector3(-1270.58f, 0, 0);
        ListBox3.anchoredPosition = new Vector3(-635.294f, 0, 0);
        ListBox4.anchoredPosition = new Vector3(0, 0, 0);

        ListBox4.localScale = new Vector3(1.75f, 1.75f, 1.75f);
    }

    public void OnRewardsClicked()
    {
        balanceDashboard.gameObject.SetActive(false);
        dataDashboard.gameObject.SetActive(false);
        promoDealsDashboard.gameObject.SetActive(false);
        usageHistoryDashboard.gameObject.SetActive(false);

        hamburgerHomePanel.DOAnchorPos(new Vector2(-1150f, 0f), 0.25f);
        rewardsDashboard.gameObject.SetActive(true);
        rewardsBar.amount = 0;
        rewardsDashboard.DOAnchorPos(Vector2.zero, 0.5f);
        ListBox.anchoredPosition = new Vector3(0, 0, 0);
        ListBox1.anchoredPosition = new Vector3(635.294f, 0, 0);
        ListBox2.anchoredPosition = new Vector3(1270.58f, 0, 0);
        ListBox3.anchoredPosition = new Vector3(-1270.58f, 0, 0);
        ListBox4.anchoredPosition = new Vector3(-635.294f, 0, 0);

        ListBox.localScale = new Vector3(1.75f, 1.75f, 1.75f);
    }

    public void OnUsageHistoryClicked()
    {
        balanceDashboard.gameObject.SetActive(false);
        dataDashboard.gameObject.SetActive(false);
        promoDealsDashboard.gameObject.SetActive(false);
        rewardsDashboard.gameObject.SetActive(false);

        hamburgerHomePanel.DOAnchorPos(new Vector2(-1150f, 0f), 0.25f);
        usageHistoryDashboard.gameObject.SetActive(true);
        usageHistoryDashboard.DOAnchorPos(Vector2.zero, 0.5f);
        ListBox.anchoredPosition = new Vector3(-635.294f, 0, 0);
        ListBox1.anchoredPosition = new Vector3(0, 0, 0);
        ListBox2.anchoredPosition = new Vector3(635.294f, 0, 0);
        ListBox3.anchoredPosition = new Vector3(1270.58f, 0, 0);
        ListBox4.anchoredPosition = new Vector3(-1270.58f, 0, 0);

        ListBox1.localScale = new Vector3(1.75f, 1.75f, 1.75f);
    }

    public void OnBalanceShareClicked()
    {
        hamburgerHomePanel.DOAnchorPos(new Vector2(-1150f, 0f), 0.25f);
        balanceSharePanel.DOAnchorPos(Vector2.zero, 0.25f).SetDelay(0.5f);
    }

    public void OnDataShareClicked()
    {
        hamburgerHomePanel.DOAnchorPos(new Vector2(-1150f, 0f), 0.25f);
        dataSharePanel.DOAnchorPos(Vector2.zero, 0.25f).SetDelay(0.5f);
    }

    public void OnSMSClicked()
    {
        hamburgerHomePanel.DOAnchorPos(new Vector2(-1150f, 0f), 0.25f);
        //SMSPanel.gameObject.SetActive(true);
        SMSPanel.DOAnchorPos(Vector2.zero, 0.25f).SetDelay(0.5f);
        StartCoroutine(ShowPieCircle());
    }

    public void OnDataMixerClicked()
    {
        hamburgerHomePanel.DOAnchorPos(new Vector2(-1150f, 0f), 0.25f);
        dataMixerPanel.DOAnchorPos(Vector2.zero, 0.25f).SetDelay(0.5f);

        balanceDashboard.gameObject.SetActive(false);
        dataDashboard.gameObject.SetActive(true);
        promoDealsDashboard.gameObject.SetActive(false);
        rewardsDashboard.gameObject.SetActive(false);
        usageHistoryDashboard.gameObject.SetActive(false);

        dataBar.amount = 0;
        dataDashboard.DOAnchorPos(Vector2.zero, 0.25f);
        ListBox.anchoredPosition = new Vector3(1270.58f, 0, 0);
        ListBox1.anchoredPosition = new Vector3(-1270.58f, 0, 0);
        ListBox2.anchoredPosition = new Vector3(-635.294f, 0, 0);
        ListBox3.anchoredPosition = new Vector3(0, 0, 0);
        ListBox4.anchoredPosition = new Vector3(635.294f, 0, 0);

        dataDashboard.gameObject.SetActive(false);
        scrollPanel.SetActive(false);

        Camera.main.backgroundColor = Color.white;
    }

    public void OnReferralClicked()
    {
        hamburgerHomePanel.DOAnchorPos(new Vector2(-1150f, 0f), 0.25f);
        referralPanel.DOAnchorPos(Vector2.zero, 0.25f).SetDelay(0.5f);
    }

    public void OnMyProfileClicked()
    {
        hamburgerHomePanel.DOAnchorPos(new Vector2(-1150f, 0f), 0.25f);
        myProfilePanel.DOAnchorPos(Vector2.zero, 0.25f).SetDelay(0.5f);
    }

    public void OnSettingsClicked()
    {
        hamburgerHomePanel.DOAnchorPos(new Vector2(-1150f, 0f), 0.25f);
        settingsPanel.DOAnchorPos(Vector2.zero, 0.25f).SetDelay(0.5f);
    }

    public void OnHelpActivateClicked()
    {
        helpAnim.SetTrigger("activatehelp");
    }

    IEnumerator ShowPieCircle()
    {
        yield return new WaitForSeconds(0.5f);
        smsBar.amount = 0;
    }
}
