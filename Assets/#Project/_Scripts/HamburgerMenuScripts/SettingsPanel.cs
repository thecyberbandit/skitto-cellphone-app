using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class SettingsPanel : MonoBehaviour {

    public RectTransform settingsPanel;
    public RectTransform hamburgerMenu;

    public Text amountText;
    public Text payAsYouGoSliderText;
    public Text tkSliderText;
    public Text callSliderText;
    public Text missedCallSliderText;
    public Text smsSliderText;

    private int amount = 1;


    private void Start()
    {
        amountText.text = amount.ToString();
    }

    public void OnDownClicked()
    {
        amount--;

        if (amount < 1)
        {
            amount = 1;
        }

        amountText.text = amount.ToString();
    }

    public void OnUpClicked()
    {
        amount++;

        if (amount > 5)
        {
            amount = 5;
        }

        amountText.text = amount.ToString();
    }

    public void OnHeaderMenuClicked()
    {
        settingsPanel.DOAnchorPos(new Vector2(-1150f, 0f), 0.25f);
        hamburgerMenu.DOAnchorPos(Vector2.zero, 0.25f);
    }

    public void PayAsYouGoSlider(float value)
    {
        if (value == 0)
        {
            payAsYouGoSliderText.text = "off";
            payAsYouGoSliderText.color = new Color32(166, 166, 166, 255);
        }

        else if (value == 1)
        {
            payAsYouGoSliderText.text = "on";
            payAsYouGoSliderText.color = new Color32(247, 3, 142, 255);
        }
    }

    public void TkSlider(float value)
    {
        if (value == 0)
        {
            tkSliderText.text = "off";
            tkSliderText.color = new Color32(166, 166, 166, 255);
        }

        else if (value == 1)
        {
            tkSliderText.text = "on";
            tkSliderText.color = new Color32(247, 3, 142, 255);
        }
    }

    public void CallSlider(float value)
    {
        if (value == 0)
        {
            callSliderText.text = "off";
            callSliderText.color = new Color32(166, 166, 166, 255);
        }

        else if (value == 1)
        {
            callSliderText.text = "on";
            callSliderText.color = new Color32(247, 3, 142, 255);
        }
    }

    public void MissedCallSlider(float value)
    {
        if (value == 0)
        {
            missedCallSliderText.text = "off";
            missedCallSliderText.color = new Color32(166, 166, 166, 255);
        }

        else if (value == 1)
        {
            missedCallSliderText.text = "on";
            missedCallSliderText.color = new Color32(247, 3, 142, 255);
        }
    }

    public void SMSSlider(float value)
    {
        if (value == 0)
        {
            smsSliderText.text = "bn";
        }

        else if (value == 1)
        {
            smsSliderText.text = "en";
        }
    }
}
