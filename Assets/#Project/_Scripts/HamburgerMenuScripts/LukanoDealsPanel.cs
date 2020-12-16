using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using DG.Tweening;

public class LukanoDealsPanel : MonoBehaviour {

    public RectTransform hamburgerMenu;
    public RectTransform lukanoDealsPanel;

    public GameObject emptyBodyPanel;
    public GameObject bodyPanel;
    public GameObject emptyHeaderPanel;
    public GameObject headerPanel;
    public Text date;

    string[] files;
    private string path;
    string dateText;


    private void Start()
    {
        files = Directory.GetFiles(@"C:\Skitto\Lukano Deals Header\");
        path = @"C:\Skitto\Lukano Deals Date.txt".Replace('\\', Path.DirectorySeparatorChar);
        dateText = File.ReadAllText(path);

        if (files.Length == 0)
        {
            emptyBodyPanel.SetActive(true);
            emptyHeaderPanel.SetActive(true);
            headerPanel.SetActive(false);
            bodyPanel.SetActive(false);
        }

        else
        {
            emptyBodyPanel.SetActive(false);
            emptyHeaderPanel.SetActive(false);
            headerPanel.SetActive(true);
            bodyPanel.SetActive(true);
            date.text = dateText;
        }
    }

    public void OnLukanoDealsClicked()
    {
        hamburgerMenu.DOAnchorPos(new Vector2(-1150f, 0f), 0.25f);
        lukanoDealsPanel.DOAnchorPos(Vector2.zero, 0.25f).SetDelay(0.5f);
    }

    public void OnLukanoDealsBackClicked()
    {
        lukanoDealsPanel.DOAnchorPos(new Vector2(-1150f, 0f), 0.25f);
    }

    public void OnHeaderMenuClicked()
    {
        lukanoDealsPanel.DOAnchorPos(new Vector2(-1150f, 0f), 0.25f);
        hamburgerMenu.DOAnchorPos(Vector2.zero, 0.25f);
    }
}
