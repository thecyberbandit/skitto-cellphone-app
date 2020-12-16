using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;

public class BodyPanel1SliderController : MonoBehaviour {

    public Button buyButton;

    public Sprite inactiveBuy;
    public Sprite activeBuy;

    public Text totalText;
    public Text priceText;

    public Slider dataSlider;
    public Slider facebookSlider;
    public Slider whatsappSlider;
    public Slider viberSlider;

    public Text dataText;
    public Text facebookText;
    public Text whatsappText;
    public Text viberText;

    public Button dataPlusButton;
    public Button dataMinusButton;
    public Button facebookPlusButton;
    public Button facebookMinusButton;
    public Button whatsappPlusButton;
    public Button whatsappMinusButton;
    public Button viberPlusButton;
    public Button viberMinusButton;

    public float total = 0;
    private int priceTotal = 0;

    private float dataTotal = 0;
    private float facebookTotal = 0;
    private float whatsappTotal = 0;
    private float viberTotal = 0;
    private int dataPrice = 0;
    private int facebookPrice = 0;
    private int whatsappPrice = 0;
    private int viberPrice = 0;

    private string pathRegular3;
    private string pathFacebook3;
    private string pathWhatsapp3;
    private string pathViber3;
    string[] textRegular3;
    string[] textFacebook3;
    string[] textWhatsapp3;
    string[] textViber3;


    private void Start()
    {
        pathRegular3 = @"C:\Skitto\3 Regular.txt".Replace('\\', Path.DirectorySeparatorChar);
        pathFacebook3 = @"C:\Skitto\3 Facebook.txt".Replace('\\', Path.DirectorySeparatorChar);
        pathWhatsapp3 = @"C:\Skitto\3 Whatsapp.txt".Replace('\\', Path.DirectorySeparatorChar);
        pathViber3 = @"C:\Skitto\3 Viber.txt".Replace('\\', Path.DirectorySeparatorChar);

        textRegular3 = File.ReadAllText(pathRegular3).Split(',');
        textFacebook3 = File.ReadAllText(pathFacebook3).Split(',');
        textWhatsapp3 = File.ReadAllText(pathWhatsapp3).Split(',');
        textViber3 = File.ReadAllText(pathViber3).Split(',');
    }

    public void DataSlider(float value)
    {
        int amount = 0;
        int price = 0;

        if (value == 0)
        {
            amount += 0;
            dataText.text = "0 MB";

            price += 0;
        }

        else if (value == 1)
        {
            amount += 55;
            price += int.Parse(textRegular3[0]);
            dataText.text = "55 MB";
        }

        else if (value == 2)
        {
            amount += 100;
            price += int.Parse(textRegular3[1]);
            dataText.text = "100 MB";
        }

        else if (value == 3)
        {
            amount += 150;
            price += int.Parse(textRegular3[2]);
            dataText.text = "150 MB";
        }

        else if (value == 4)
        {
            amount += 250;
            price += int.Parse(textRegular3[3]);
            dataText.text = "250 MB";
        }

        else if (value == 5)
        {
            amount += 500;
            price += int.Parse(textRegular3[4]);
            dataText.text = "500 MB";
        }

        else if (value == 6)
        {
            amount += 750;
            price += int.Parse(textRegular3[5]);
            dataText.text = "750 MB";
        }

        else if (value == 7)
        {
            amount += 1000;
            price += int.Parse(textRegular3[6]);
            dataText.text = "1.0 GB";
        }

        else if (value == 8)
        {
            amount += 1500;
            price += int.Parse(textRegular3[7]);
            dataText.text = "1.5 GB";
        }

        dataTotal = amount;
        dataPrice = price;
    }

    public void FacebookSlider(float value)
    {
        int amount = 0;
        int price = 0;

        if (value == 0)
        {
            amount += 0;
            price += 0;
            facebookText.text = "0 MB";
        }

        else if (value == 1)
        {
            amount += 55;
            price += int.Parse(textFacebook3[0]);
            facebookText.text = "55 MB";
        }


        facebookTotal = amount;
        facebookPrice = price;

        Debug.Log(total);
    }

    public void WhatsappSlider(float value)
    {
        int amount = 0;
        int price = 0;

        if (value == 0)
        {
            amount += 0;
            price += 0;
            whatsappText.text = "0 MB";
        }

        else if (value == 1)
        {
            amount += 55;
            price += int.Parse(textWhatsapp3[0]);
            whatsappText.text = "55 MB";
        }

        whatsappTotal = amount;
        whatsappPrice = price;

        Debug.Log(total);
    }

    public void ViberSlider(float value)
    {
        int amount = 0;
        int price = 0;

        if (value == 0)
        {
            amount += 0;
            price += 0;
            viberText.text = "0 MB";
        }

        else if (value == 1)
        {
            amount += 55;
            price += int.Parse(textViber3[0]);
            viberText.text = "55 MB";
        }

        viberTotal = amount;
        viberPrice = price;

        Debug.Log(total);
    }

    public void OnDataPlusButtonClicked()
    {
        dataSlider.value += 1f;
    }

    public void OnDataMinusButtonClicked()
    {
        dataSlider.value -= 1f;
    }

    public void OnFacebookPlusButtonClicked()
    {
        facebookSlider.value += 1f;
    }

    public void OnFacebookMinusButtonClicked()
    {
        facebookSlider.value -= 1f;
    }

    public void OnWhatsappPlusButtonClicked()
    {
        whatsappSlider.value += 1f;
    }

    public void OnWhatsappMinusButtonClicked()
    {
        whatsappSlider.value -= 1f;
    }

    public void OnViberPlusButtonClicked()
    {
        viberSlider.value += 1f;
    }

    public void OnViberMinusButtonClicked()
    {
        viberSlider.value -= 1f;
    }

    void Update()
    {
        total = dataTotal + facebookTotal + whatsappTotal + viberTotal;
        priceTotal = dataPrice + facebookPrice + whatsappPrice + viberPrice;

        if (total < 1000)
        {
            totalText.text = total + " MB";
        }

        else
        {
            float temp = total / 1000;
            temp = (float)Math.Round(temp, 1);

            totalText.text = temp + " GB";

            Debug.Log("GB");
        }

        priceText.text = priceTotal.ToString();

        if (dataSlider.value == 0 && facebookSlider.value == 0 && whatsappSlider.value == 0 && viberSlider.value == 0)
        {
            buyButton.GetComponent<Image>().sprite = inactiveBuy;
        }

        else
        {
            buyButton.GetComponent<Image>().sprite = activeBuy;
        }
    }
}
