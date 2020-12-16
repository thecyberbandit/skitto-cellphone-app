using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ReadyPacksPanel : MonoBehaviour {

    public GameObject monthly;
    public GameObject weekly;
    public GameObject daily;
    public Scrollbar readypacksScrollbar;

    public GameObject bodyPanel1;
    public GameObject bodyPanel2;
    public GameObject bodyPanel3;

    public RectTransform readyPacksPanel;

    private Text monthlyText;
    private Text weeklyText;
    private Text dailyText;


    private void Start()
    {
        monthlyText = monthly.GetComponentInChildren<Text>();
        weeklyText = weekly.GetComponentInChildren<Text>();
        dailyText = daily.GetComponentInChildren<Text>();
    }

    private void Update()
    {
        if (readypacksScrollbar.value < 0.2f)
        {
            monthly.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
            daily.transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
            weekly.transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);

            monthlyText.color = new Color32(0, 252, 253, 255);
            weeklyText.color = Color.white;
            dailyText.color = Color.white;

            bodyPanel2.SetActive(true);
            bodyPanel1.SetActive(false);
            bodyPanel3.SetActive(false);
        }

        else if (readypacksScrollbar.value > 0.8f)
        {
            daily.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
            monthly.transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
            weekly.transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);

            dailyText.color = new Color32(0, 252, 253, 255);
            monthlyText.color = Color.white;
            weeklyText.color = Color.white;

            bodyPanel3.SetActive(true);
            bodyPanel1.SetActive(false);
            bodyPanel2.SetActive(false);
        }

        else
        {
            weekly.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
            monthly.transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
            daily.transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);

            weeklyText.color = new Color32(0, 252, 253, 255);
            monthlyText.color = Color.white;
            dailyText.color = Color.white;

            bodyPanel1.SetActive(true);
            bodyPanel2.SetActive(false);
            bodyPanel3.SetActive(false);
        }
    }

    public void OnCoolClicked()
    {
        Camera.main.backgroundColor = Color.yellow;
        readyPacksPanel.DOAnchorPos(new Vector2(1800f, 0f), 0f);
    }
}
