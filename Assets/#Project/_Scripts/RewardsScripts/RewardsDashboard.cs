using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class RewardsDashboard : MonoBehaviour {


    private RadialProgressBar bar;
    private Animator anim;

    public GameObject goBackButton;
    public RectTransform usePointsPanel;
    public RectTransform rewardsDashboard;

    public GameObject itemContent1;
    public GameObject itemContent2;
    public GameObject itemContent3;

    public GameObject expandButton1;
    public GameObject expandButton2;
    public GameObject expandButton3;


    private void Start()
    {
        anim = GetComponentInChildren<Animator>();
        bar = GetComponentInChildren<RadialProgressBar>();
    }

    public void OnTapForDetailsClicked()
    {
        anim.SetTrigger("fadeout");
        goBackButton.SetActive(true);
    }

    public void OnGoBackClicked()
    {
        anim.SetTrigger("fadein");
        goBackButton.SetActive(false);
        bar.amount = 0;
        Debug.Log("Button is clicked");
    }

    public void OnUsePointsClicked()
    {
        usePointsPanel.DOAnchorPos(Vector2.zero, 0.25f);
        rewardsDashboard.DOAnchorPos(new Vector2(-1150f, 0f), 0.5f);
        Camera.main.backgroundColor = Color.white;
    }

    public void OnHeaderBackClicked()
    {
        rewardsDashboard.DOAnchorPos(Vector2.zero, 0.25f);
        usePointsPanel.DOAnchorPos(new Vector2(1150f, 0f), 0.5f);
        Camera.main.backgroundColor = Color.yellow;

        itemContent1.SetActive(false);
        itemContent2.SetActive(false);
        itemContent3.SetActive(false);

        expandButton1.SetActive(true);
        expandButton2.SetActive(true);
        expandButton3.SetActive(true);
    }
}
