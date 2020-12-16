using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RadialProgressBar : MonoBehaviour {

    public Image imageBackground;

    [Range(0, 100)]
    public int amount = 0;

    private Text pieCircleText;


    private void Start()
    {
        pieCircleText = GetComponentInChildren<Text>();
    }

    private void Update()
    {
        if (amount < 100)
        {
            pieCircleText.text = "0";
        }

        else if (amount >= 100)
        {
            pieCircleText.text = "35";
        }

        amount = amount + 2;
        float amountFillled = amount / 100f;
        imageBackground.fillAmount = amountFillled;
    }
}
