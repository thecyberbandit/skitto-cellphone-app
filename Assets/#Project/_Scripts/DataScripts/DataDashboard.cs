using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class DataDashboard : MonoBehaviour {

    public GameObject bodyPanel;
    public GameObject fadePanel1;
    public GameObject fadePanel2;

    public GameObject buyDataButton;
    public GameObject backButton;
    public GameObject moreButton;
    public GameObject goBackButton;
    public GameObject pieCircle;

    public RectTransform readyPacksPanel;
    public RectTransform dataDashboard;

    private Animator bodyAnim;
    private Animator fadeAnim;

    private RadialProgressBar bar;



    private void Start()
    {
        bodyAnim = bodyPanel.GetComponent<Animator>();
        fadeAnim = fadePanel1.GetComponent<Animator>();
        bar = pieCircle.GetComponent<RadialProgressBar>();
    }

    public void OnTapForDetailsClicked()
    {
        bodyAnim.SetTrigger("fadeout");
        backButton.SetActive(true);
        buyDataButton.SetActive(true);
    }

    public void OnBuyDataClicked()
    {
        readyPacksPanel.DOAnchorPos(Vector2.zero, 0.25f);
        dataDashboard.DOAnchorPos(new Vector2(-1150f, 0f), 0.5f);
        Camera.main.backgroundColor = Color.white;
    }

    public void OnBackClicked()
    {
        bodyAnim.SetTrigger("fadein");
        bar.amount = 0;
        backButton.SetActive(false);
        buyDataButton.SetActive(false);
    }

    public void OnMoreClicked()
    {
        fadeAnim.SetTrigger("fadeout");
        buyDataButton.SetActive(false);
        backButton.SetActive(false);
        moreButton.SetActive(false);
        goBackButton.SetActive(true);
    }

    public void OnGoBackClicked()
    {
        fadeAnim.SetTrigger("fadein");
        buyDataButton.SetActive(true);
        backButton.SetActive(true);
        moreButton.SetActive(true);
        goBackButton.SetActive(false);
    }
}
