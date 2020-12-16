using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class DataMixerPanel : MonoBehaviour {

    public Text seven;
    public Text thirty;
    public Text three;
    public Scrollbar dataScrollbar;

    public GameObject headerPanel3;
    public GameObject headerPanel7;
    public GameObject headerPanel30;

    public RectTransform bodyPanel1;
    public RectTransform bodyPanel2;
    public RectTransform bodyPanel3;

    public Slider body1DataSlider;
    public Slider body2DataSlider;
    public Slider body3DataSlider;

    public Slider body1FacebookSlider;
    public Slider body2FacebookSlider;
    public Slider body3FacebookSlider;

    public Slider body1WhatsappSlider;
    public Slider body2WhatsappSlider;
    public Slider body3WhatsappSlider;

    public Slider body1ViberSlider;
    public Slider body2ViberSlider;
    public Slider body3ViberSlider;


    private SliderController sliderController;


    private void Start()
    {
        sliderController = this.GetComponent<SliderController>();
    }

    private void Update()
    {
        if (dataScrollbar.value < 0.3)
        {
            three.color = Color.yellow;
            seven.color = Color.white;
            thirty.color = Color.white;
            bodyPanel2.DOAnchorPos(new Vector2(1150f, 0f), 0f);
            bodyPanel3.DOAnchorPos(new Vector2(1150f, 0f), 0f);
            bodyPanel1.DOAnchorPos(Vector2.zero, 0f);

            headerPanel3.SetActive(true);
            headerPanel7.SetActive(false);
            headerPanel30.SetActive(false);

            body2DataSlider.value = 0f;
            body2FacebookSlider.value = 0f;
            body2WhatsappSlider.value = 0f;
            body2ViberSlider.value = 0f;

            body3DataSlider.value = 0f;
            body3FacebookSlider.value = 0f;
            body3WhatsappSlider.value = 0f;
            body3ViberSlider.value = 0f;
        }


        else if (dataScrollbar.value > 0.8)
        {
            thirty.color = Color.yellow;
            three.color = Color.white;
            seven.color = Color.white;
            bodyPanel1.DOAnchorPos(new Vector2(1150f, 0f), 0f);
            bodyPanel2.DOAnchorPos(new Vector2(1150f, 0f), 0f);
            bodyPanel3.DOAnchorPos(Vector2.zero, 0f);

            headerPanel3.SetActive(false);
            headerPanel7.SetActive(false);
            headerPanel30.SetActive(true);

            body2DataSlider.value = 0f;
            body2FacebookSlider.value = 0f;
            body2WhatsappSlider.value = 0f;
            body2ViberSlider.value = 0f;

            body1DataSlider.value = 0f;
            body1FacebookSlider.value = 0f;
            body1WhatsappSlider.value = 0f;
            body1ViberSlider.value = 0f;
        }


        else
        {
            seven.color = Color.yellow;
            three.color = Color.white;
            thirty.color = Color.white;
            bodyPanel1.DOAnchorPos(new Vector2(1150f, 0f), 0f);
            bodyPanel3.DOAnchorPos(new Vector2(1150f, 0f), 0f);
            bodyPanel2.DOAnchorPos(Vector2.zero, 0f);

            headerPanel3.SetActive(false);
            headerPanel7.SetActive(true);
            headerPanel30.SetActive(false);

            body1DataSlider.value = 0f;
            body1FacebookSlider.value = 0f;
            body1WhatsappSlider.value = 0f;
            body1ViberSlider.value = 0f;

            body3DataSlider.value = 0f;
            body3FacebookSlider.value = 0f;
            body3WhatsappSlider.value = 0f;
            body3ViberSlider.value = 0f;
        }
    }
}
