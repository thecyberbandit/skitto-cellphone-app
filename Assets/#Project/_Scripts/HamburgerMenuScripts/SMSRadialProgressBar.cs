using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SMSRadialProgressBar : MonoBehaviour {

    public Image imageBackground;

    [Range(0, 100)]
    public int amount = 0;


    private void Update()
    {
        amount = amount + 2;
        float amountFillled = amount / 100f;
        imageBackground.fillAmount = amountFillled;
    }
}
