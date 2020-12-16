using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ScrollPanel : MonoBehaviour {

    public RectTransform balanceDashboard;
    public RectTransform dataDashboard;
    public RectTransform promoDealsDashboard;
    public RectTransform rewardsDashboard;
    public RectTransform usageHistoryDashboard;

    public GameObject pieCircle;
    public GameObject pieCircle2;

    public Text nameText;

    private ListPositionCtrl positionCtrl;
    private int lastCentreID = 0;

    private RadialProgressBar bar;
    private RadialProgressBar dataBar;


    void Start()
    {
        positionCtrl = GetComponentInChildren<ListPositionCtrl>();
        bar = pieCircle.GetComponent<RadialProgressBar>();
        dataBar = pieCircle2.GetComponent<RadialProgressBar>();
    }

    void Update()
    {
        int currentCenterID = positionCtrl.GetCenteredContentID();

        if (currentCenterID == 0)
        {
            nameText.text = "balance";

            if (lastCentreID == 4)
            {
                balanceDashboard.gameObject.SetActive(true);
                balanceDashboard.DOAnchorPos(new Vector2(1150f, 0f), 0f);
                balanceDashboard.DOAnchorPos(Vector2.zero, 0.25f);
                usageHistoryDashboard.DOAnchorPos(new Vector2(-1150f, 0f), 0.5f);
            }

            else if (lastCentreID == 1)
            {
                balanceDashboard.gameObject.SetActive(true);
                balanceDashboard.DOAnchorPos(Vector2.zero, 0.25f);
                dataDashboard.DOAnchorPos(new Vector2(1150f, 0f), 0.5f);
                dataDashboard.gameObject.SetActive(false);
                dataBar.amount = 0;
            }

            //lastCentreID = currentCenterID;
        }

        else if (currentCenterID == 1)
        {
            nameText.text = "data";

            if (lastCentreID == 0)
            {
                dataDashboard.DOAnchorPos(new Vector2(1150f, 0f), 0f);
                dataDashboard.gameObject.SetActive(true);
                dataDashboard.DOAnchorPos(Vector2.zero, 0.25f);
                balanceDashboard.DOAnchorPos(new Vector2(-1150f, 0f), 0.5f);
            }

            else if (lastCentreID == 2)
            {
                dataDashboard.DOAnchorPos(new Vector2(-1150f, 0f), 0f);
                dataDashboard.gameObject.SetActive(true);
                dataDashboard.DOAnchorPos(Vector2.zero, 0.25f);
                promoDealsDashboard.DOAnchorPos(new Vector2(1150f, 0f), 0.5f);
                promoDealsDashboard.gameObject.SetActive(false);
            }

            //lastCentreID = currentCenterID;
        }

        else if (currentCenterID == 2)
        {
            nameText.text = "promo deals!";

            if (lastCentreID == 1)
            {
                promoDealsDashboard.DOAnchorPos(new Vector2(1150f, 0f), 0f);
                promoDealsDashboard.gameObject.SetActive(true);
                promoDealsDashboard.DOAnchorPos(Vector2.zero, 0.25f);
                dataDashboard.DOAnchorPos(new Vector2(-1150f, 0f), 0.5f);
                dataDashboard.gameObject.SetActive(false);
                dataBar.amount = 0;
            }

            else if (lastCentreID == 3)
            {
                promoDealsDashboard.DOAnchorPos(new Vector2(-1150f, 0f), 0f);
                promoDealsDashboard.gameObject.SetActive(true);
                promoDealsDashboard.DOAnchorPos(Vector2.zero, 0.25f);
                rewardsDashboard.DOAnchorPos(new Vector2(1150f, 0f), 0.5f);
                rewardsDashboard.gameObject.SetActive(false);
                bar.amount = 0;
            }

            //lastCentreID = currentCenterID;
        }

        else if (currentCenterID == 3)
        {
            nameText.text = "rewards";

            if (lastCentreID == 2)
            {
                rewardsDashboard.DOAnchorPos(new Vector2(1150f, 0f), 0f);
                rewardsDashboard.gameObject.SetActive(true);
                rewardsDashboard.DOAnchorPos(Vector2.zero, 0.25f);
                promoDealsDashboard.DOAnchorPos(new Vector2(-1150f, 0f), 0.5f);
                promoDealsDashboard.gameObject.SetActive(false);
            }

            else if (lastCentreID == 4)
            {
                rewardsDashboard.DOAnchorPos(new Vector2(-1150f, 0f), 0f);
                rewardsDashboard.gameObject.SetActive(true);
                rewardsDashboard.DOAnchorPos(Vector2.zero, 0.25f);
                usageHistoryDashboard.DOAnchorPos(new Vector2(1150f, 0f), 0.5f);
            }

            //lastCentreID = currentCenterID;
        }

        else if (currentCenterID == 4)
        {
            nameText.text = "usage history";

            if (lastCentreID == 3)
            {
                usageHistoryDashboard.gameObject.SetActive(true);
                usageHistoryDashboard.DOAnchorPos(new Vector2(1150f, 0f), 0f);
                usageHistoryDashboard.DOAnchorPos(Vector2.zero, 0.25f);
                rewardsDashboard.DOAnchorPos(new Vector2(-1150f, 0f), 0.5f);
                rewardsDashboard.gameObject.SetActive(false);
                bar.amount = 0;
            }

            else if (lastCentreID == 0)
            {
                usageHistoryDashboard.gameObject.SetActive(true);
                usageHistoryDashboard.DOAnchorPos(new Vector2(-1150f, 0f), 0f);
                usageHistoryDashboard.DOAnchorPos(Vector2.zero, 0.25f);
                balanceDashboard.DOAnchorPos(new Vector2(1150f, 0f), 0.5f);
            }

            //lastCentreID = currentCenterID;
        }

        lastCentreID = currentCenterID;

        ///Debug.Log(lastCentreID);
    }
}
