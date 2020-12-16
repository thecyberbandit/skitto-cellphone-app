using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using DG.Tweening;

public class PromoDeals : MonoBehaviour {

    public GameObject scrollView;

    public RectTransform dataDashboard;
    public GameObject dataPieCircle;

    public RectTransform ListBox;
    public RectTransform ListBox1;
    public RectTransform ListBox2;
    public RectTransform ListBox3;
    public RectTransform ListBox4;

    private RadialProgressBar dataBar;


    private void Start()
    {
        dataBar = dataPieCircle.GetComponent<RadialProgressBar>();
    }

    public void OnPopupCancelClicked()
    {
        scrollView.GetComponent<ScrollRect>().horizontal = true;
    }

    public void OnCoolButtonClicked()
    {
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
}
