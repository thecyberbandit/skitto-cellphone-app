using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


public class UIManager : MonoBehaviour {

    public RectTransform dataMixerPanel;
    public RectTransform readyPacksPanel;
    public RectTransform dataDashboard;
    public GameObject dataPieCircle;

    public RectTransform usageHistoryDashboard;
    public RectTransform reloadHistoryPanel;
    public RectTransform generalHistoryPanel;

    public RectTransform hamburgerHomePanel;

    //public GameObject itemContent1;
    //public GameObject itemContent2;
    //public GameObject itemContent3;
    //public GameObject itemContent4;

    //public GameObject expandButton1;
    //public GameObject expandButton2;
    //public GameObject expandButton3;
    //public GameObject expandButton4;

    //public GameObject scrollPanel;

    private RadialProgressBar dataBar;


    private void Start()
    {
        dataBar = dataPieCircle.GetComponent<RadialProgressBar>();
    }

    public void OnDataMixerButtonClicked()
    {
        dataMixerPanel.DOAnchorPos(Vector2.zero, 0.25f);
        dataDashboard.DOAnchorPos(new Vector2(-1150f, 0f), 0.5f);
        Camera.main.backgroundColor = Color.white;
    }

    public void OnDataMixerBackButtonClicked()
    {
        dataDashboard.gameObject.SetActive(true);

        dataDashboard.DOAnchorPos(Vector2.zero, 0.25f);
        dataMixerPanel.DOAnchorPos(new Vector2(1150f, 0f), 0.5f);
        Camera.main.backgroundColor = Color.yellow;
        dataBar.amount = 0;
    }

    public void OnReadyPacksButtonClicked()
    {
        readyPacksPanel.DOAnchorPos(Vector2.zero, 0.25f);
        dataDashboard.DOAnchorPos(new Vector2(-1150f, 0f), 0.5f);
        Camera.main.backgroundColor = Color.white;
    }

    public void OnReadyPacksBackButtonClicked()
    {
        dataDashboard.DOAnchorPos(Vector2.zero, 0.25f);
        readyPacksPanel.DOAnchorPos(new Vector2(1800f, 0f), 0f);
        Camera.main.backgroundColor = Color.yellow;
        dataBar.amount = 0;

        //itemContent1.SetActive(false);
        //itemContent2.SetActive(false);
        //itemContent3.SetActive(false);
        //itemContent4.SetActive(false);

        //expandButton1.SetActive(true);
        //expandButton2.SetActive(true);
        //expandButton3.SetActive(true);
        //expandButton4.SetActive(true);
    }

    public void OnReloadHistoryButtonClicked()
    {
        reloadHistoryPanel.DOAnchorPos(Vector2.zero, 0.25f);
        usageHistoryDashboard.DOAnchorPos(new Vector2(-1150f, 0f), 0.5f);
    }

    public void OnReloadHiBackButtonClicked()
    {
        usageHistoryDashboard.DOAnchorPos(Vector2.zero, 0.25f);
        reloadHistoryPanel.DOAnchorPos(new Vector2(1150f, 0f), 0.5f);
    }

    public void OnGeneralHistoryButtonClicked()
    {
        generalHistoryPanel.DOAnchorPos(Vector2.zero, 0.25f);
        usageHistoryDashboard.DOAnchorPos(new Vector2(-1150f, 0f), 0.5f);
    }

    public void OnGeneralHistoryBackButtonClicked()
    {
        usageHistoryDashboard.DOAnchorPos(Vector2.zero, 0.25f);
        generalHistoryPanel.DOAnchorPos(new Vector2(1150f, 0f), 0.5f);
    }

    public void OnHamburgerMenuClicked()
    {
        hamburgerHomePanel.DOAnchorPos(Vector2.zero, 0.25f);
    }

    public void OnHamburgerCancelClicked()
    {
        hamburgerHomePanel.DOAnchorPos(new Vector2(-1150f, 0f), 0.25f);
    }

    public void OpenFAQPage()
    {
        Application.OpenURL("https://www.skitto.com/faq");
    }
}
