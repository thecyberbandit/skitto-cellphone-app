using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using DG.Tweening;

public class ContentCreator : MonoBehaviour {


    public GameObject content;
    public RectTransform _center;
    public ScrollRect _RectPanel;
    public GameObject popup;
    public GameObject purchase;

    private Image[] offers;
    private float[] _distance;
    private int bttnDistance;
    private int minButtonNum;


    void Start ()
    {
        string[] files = Directory.GetFiles(@"C:\Skitto\Offers\");

        int temp = files.Length;

        this.gameObject.GetComponent<RectTransform>().offsetMax =
            new Vector2(temp * 778.8f + 230f, this.gameObject.GetComponent<RectTransform>().offsetMax.y);
        this.gameObject.GetComponent<RectTransform>().offsetMin =
            new Vector2(0f, this.gameObject.GetComponent<RectTransform>().offsetMin.y);



        for (int i = 0; i < files.Length; i++)
        {
            GameObject c = Instantiate(content, this.gameObject.transform);
            c.transform.SetParent(this.gameObject.transform);
            c.GetComponent<RectTransform>().anchoredPosition = new Vector3(i*778.8f+ 144f, 0f, 0f);
            c.GetComponent<RectTransform>().sizeDelta = new Vector2(708.5328f, 730.3165f);


            byte[] byteArray = File.ReadAllBytes(@files[i]);

            Texture2D sampleTexture = new Texture2D(2, 2);

            bool isLoaded = sampleTexture.LoadImage(byteArray);

            if (isLoaded)
            {
                c.GetComponent<Image>().sprite = Sprite.Create(sampleTexture, new Rect(0.0f, 0.0f, sampleTexture.width, sampleTexture.height), new Vector2(0.5f, 0.5f), 100.0f);
            }

            string[] title = Path.GetFileNameWithoutExtension(files[i]).Split('.');

            c.GetComponentInChildren<Button>().onClick.AddListener(delegate { ButtonClicked(title[1]); });
        }

        offers = this.GetComponentsInChildren<Image>();
        int bttnLenght = offers.Length;
        _distance = new float[bttnLenght];

        bttnDistance = 778;
    }

    public void ButtonClicked(string dealName)
    {
        popup.GetComponentInChildren<Text>().text = "Sure you wanna purchase " + dealName + " pack? Trust me it's totally worth it";
        purchase.GetComponentInChildren<Text>().text = "You've successfully purchased " + dealName + " pack with 3 days validity. yayyyyy!";

        popup.SetActive(true);
        _RectPanel.horizontal = false;
    }

    void Update()
    {

        for (int i = 0; i < offers.Length; i++)
        {

            _distance[i] = Mathf.Abs(_center.anchoredPosition.x - offers[i].transform.position.x);


        }

        float minDistance = Mathf.Min(_distance);

        for (int k = 0; k < offers.Length; k++)
        {

            if (minDistance == _distance[k])
            {

                minButtonNum = k;

                Debug.Log(k);

                ScaleUpAndScaleDown(k);
            }
        }


        //if ((!isRunning))
        //{

        //    LerpToTargetPosition(minButtonNum * -bttnDistance);
        //}

    }

    //public void Onvaluechange()
    //{
    //    //		if (_RectPanel.velocity.x > 0f)
    //    {
    //        //			Debug.Log (_RectPanel.velocity);

    //        if (Mathf.Abs(_RectPanel.velocity.x) > 250.0f)
    //        {

    //            isRunning = true;
    //        }
    //        else
    //        {

    //            isRunning = false;
    //        }
    //    }

    //    isEnable = true;
    //}

    //void LerpToTargetPosition(int pos)
    //{



    //    float newX = Mathf.Lerp(ScrollPanel.anchoredPosition.x, pos, Time.deltaTime * 5f);

    //    Vector2 newPosition = new Vector2(newX, ScrollPanel.anchoredPosition.y);

    //    ScrollPanel.anchoredPosition = newPosition;

    //}

    Vector3 scale = new Vector3(0.0085f, 0.0085f, 0.0085f);

    void ScaleUpAndScaleDown(int index)
    {

        for (int i = 0; i < offers.Length; i++)
        {

            if (i == index)
            {
                if (offers[i].GetComponent<RectTransform>().localScale.x <= 1.0f)
                {

                    offers[i].GetComponent<RectTransform>().localScale += Vector3.Lerp(scale, offers[i].GetComponent<RectTransform>().localScale, Time.deltaTime * 0.5f);


                }

            }
            else
            {
                if (offers[i].GetComponent<RectTransform>().localScale.x >= 0.85f)
                {

                    offers[i].GetComponent<RectTransform>().localScale -= Vector3.Lerp(scale, offers[i].GetComponent<RectTransform>().localScale, Time.deltaTime * 0.5f);
                    //					
                }

            }

        }

    }
}
