using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class PromoDealsContentCreator : MonoBehaviour {

    public GameObject content;
    public GameObject popup;
    public GameObject purchase;
    public GameObject scrollView;


    void Start()
    {
        string[] files = Directory.GetFiles(@"C:\Offers\");

        for (int i = 0; i < files.Length; i++)
        {
            GameObject c = Instantiate(content, this.gameObject.transform);
            c.transform.SetParent(this.gameObject.transform);
            //c.GetComponent<RectTransform>().pivot = new Vector2(0.5f, 0.5f);
            c.GetComponent<RectTransform>().anchoredPosition = new Vector3(i * 778.8f, 0f, 0f);
            c.GetComponent<RectTransform>().sizeDelta = new Vector2(708.5328f, 730.3165f);


            byte[] byteArray = File.ReadAllBytes(@files[i]);

            Texture2D sampleTexture = new Texture2D(2, 2);

            bool isLoaded = sampleTexture.LoadImage(byteArray);

            if (isLoaded)
            {
                c.GetComponent<Image>().sprite = Sprite.Create(sampleTexture, new Rect(0.0f, 0.0f, sampleTexture.width, sampleTexture.height), new Vector2(0.5f, 0.5f), 100.0f);
            }

            string title = Path.GetFileNameWithoutExtension(files[i]);
            //Debug.Log(title);

            c.GetComponentInChildren<Button>().onClick.AddListener(delegate { ButtonClicked(title); });
        }

    }

    public void ButtonClicked(string dealName)
    {
        popup.GetComponentInChildren<Text>().text = "Sure you wanna purchase " + dealName + " pack? Trust me it's totally worth it";
        purchase.GetComponentInChildren<Text>().text = "You've successfully purchased " + dealName + " pack with 3 days validity. yayyyyy!";

        popup.SetActive(true);
        scrollView.GetComponent<ScrollRect>().horizontal = false;
    }
}
