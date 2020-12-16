using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class SMSDetailsPanel : MonoBehaviour {

    public RectTransform SMSMainPanel;
    public RectTransform SMSDetailPanel;
    public GameObject smsPieCircle;

    private SMSRadialProgressBar bar;


    private void Start()
    {
        bar = smsPieCircle.GetComponent<SMSRadialProgressBar>();
    }

    public void OnSMSDetailsBackButtonClicked()
    {
        bar.amount = 0;
        SMSMainPanel.DOAnchorPos(Vector2.zero, 0.25f);
        SMSDetailPanel.DOAnchorPos(new Vector2(-1150f, 0f), 0.5f);
    }
}
