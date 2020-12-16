using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;

public class SliderController : MonoBehaviour {

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

    private string pathRegular30;
    private string pathFacebook30;
    private string pathWhatsapp30;
    private string pathViber30;
    string[] textRegular30;
    string[] textFacebook30;
    string[] textWhatsapp30;
    string[] textViber30;


    private void Start()
    {
        pathRegular30 = @"C:\Skitto\30 Regular.txt".Replace('\\', Path.DirectorySeparatorChar);
        pathFacebook30 = @"C:\Skitto\30 Facebook.txt".Replace('\\', Path.DirectorySeparatorChar);
        pathWhatsapp30 = @"C:\Skitto\30 Whatsapp.txt".Replace('\\', Path.DirectorySeparatorChar);
        pathViber30 = @"C:\Skitto\30 Viber.txt".Replace('\\', Path.DirectorySeparatorChar);

        textRegular30 = File.ReadAllText(pathRegular30).Split(',');
        textFacebook30 = File.ReadAllText(pathFacebook30).Split(',');
        textWhatsapp30 = File.ReadAllText(pathWhatsapp30).Split(',');
        textViber30 = File.ReadAllText(pathViber30).Split(',');
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
            amount += 60;
            price += int.Parse(textRegular30[0]);
            dataText.text = "60 MB";
        }

        else if (value == 2)
        {
            amount += 110;
            price += int.Parse(textRegular30[1]);
            dataText.text = "110 MB";
        }

        else if (value == 3)
        {
            amount += 165;
            price += int.Parse(textRegular30[2]);
            dataText.text = "165 MB";
        }

        else if (value == 4)
        {
            amount += 275;
            price += int.Parse(textRegular30[3]);
            dataText.text = "275 MB";
        }

        else if (value == 5)
        {
            amount += 550;
            price += int.Parse(textRegular30[4]);
            dataText.text = "550 MB";
        }

        else if (value == 6)
        {
            amount += 850;
            price += int.Parse(textRegular30[5]);
            dataText.text = "850 MB";
        }

        else if (value == 7)
        {
            amount += 1200;
            price += int.Parse(textRegular30[6]);
            dataText.text = "1.2 GB";
        }

        else if (value == 8)
        {
            amount += 1600;
            price += int.Parse(textRegular30[7]);
            dataText.text = "1.6 GB";
        }

        else if (value == 9)
        {
            amount += 2200;
            price += int.Parse(textRegular30[8]);
            dataText.text = "2.2 GB";
        }

        else if (value == 10)
        {
            amount += 3000;
            price += int.Parse(textRegular30[9]);
            dataText.text = "3 GB";
        }

        else if (value == 11)
        {
            amount += 5500;
            price += int.Parse(textRegular30[10]);
            dataText.text = "5.5 GB";
        }

        else if (value == 12)
        {
            amount += 11000;
            price += int.Parse(textRegular30[11]);
            dataText.text = "11.0 GB";
        }

        else if (value == 13)
        {
            amount += 22000;
            price += int.Parse(textRegular30[12]);
            dataText.text = "22.0 GB";
        }

        dataTotal = amount;
        dataPrice = price;

        Debug.Log(total);
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
            price += int.Parse(textFacebook30[0]);
            facebookText.text = "55 MB";
        }

        else if (value == 2)
        {
            amount += 100;
            price += int.Parse(textFacebook30[1]);
            facebookText.text = "100 MB";
        }

        else if (value == 3)
        {
            amount += 150;
            price += int.Parse(textFacebook30[2]);
            facebookText.text = "150 MB";
        }

        else if (value == 4)
        {
            amount += 250;
            price += int.Parse(textFacebook30[3]);
            facebookText.text = "250 MB";
        }

        else if (value == 5)
        {
            amount += 500;
            price += int.Parse(textFacebook30[4]);
            facebookText.text = "500 MB";
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
            price += int.Parse(textWhatsapp30[0]);
            whatsappText.text = "55 MB";
        }

        else if (value == 2)
        {
            amount += 100;
            price += int.Parse(textWhatsapp30[1]);
            whatsappText.text = "100 MB";
        }

        else if (value == 3)
        {
            amount += 150;
            price += int.Parse(textWhatsapp30[2]);
            whatsappText.text = "150 MB";
        }

        else if (value == 4)
        {
            amount += 250;
            price += int.Parse(textWhatsapp30[3]);
            whatsappText.text = "250 MB";
        }

        else if (value == 5)
        {
            amount += 500;
            price += int.Parse(textWhatsapp30[4]);
            whatsappText.text = "500 MB";
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
            price += int.Parse(textViber30[0]);
            viberText.text = "55 MB";
        }

        else if (value == 2)
        {
            amount += 100;
            price += int.Parse(textViber30[1]);
            viberText.text = "100 MB";
        }

        else if (value == 3)
        {
            amount += 150;
            price += int.Parse(textViber30[2]);
            viberText.text = "150 MB";
        }

        else if (value == 4)
        {
            amount += 250;
            price += int.Parse(textViber30[3]);
            viberText.text = "250 MB";
        }

        else if (value == 5)
        {
            amount += 500;
            price += int.Parse(textViber30[4]);
            viberText.text = "500 MB";
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
