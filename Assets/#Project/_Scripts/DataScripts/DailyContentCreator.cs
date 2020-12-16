using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class DailyContentCreator : MonoBehaviour {

    public GameObject content;

    string[] headerFiles;
    string[] itemContentFiles;

    public GameObject popupPanel;
    public GameObject purchasePanel;

    public Text popupText;
    public Text purchaseText;


    void Start()
    {
        headerFiles = Directory.GetFiles(@"C:\Skitto\Daily Header\");
        itemContentFiles = Directory.GetFiles(@"C:\Skitto\Daily Content\");


        for (int i = 0; i < headerFiles.Length; i++)
        {
            GameObject header;
            GameObject itemContent;

            GameObject c = Instantiate(content);
            c.transform.SetParent(this.gameObject.transform);


            header = c.transform.Find("Header").gameObject;
            itemContent = c.transform.Find("Item Content").gameObject;

            byte[] byteArray1 = File.ReadAllBytes(@headerFiles[i]);
            byte[] byteArray2 = File.ReadAllBytes(@itemContentFiles[i]);

            Texture2D sampleTexture1 = new Texture2D(2, 2);

            bool isLoaded1 = sampleTexture1.LoadImage(byteArray1);

            if (isLoaded1)
            {
                header.GetComponent<Image>().sprite = Sprite.Create(sampleTexture1, new Rect(0.0f, 0.0f, sampleTexture1.width,
                    sampleTexture1.height), new Vector2(0.5f, 0.5f), 100.0f);
            }

            Texture2D sampleTexture2 = new Texture2D(2, 2);

            bool isLoaded2 = sampleTexture2.LoadImage(byteArray2);

            string[] title = Path.GetFileNameWithoutExtension(headerFiles[i]).Split('.');
            string[] popupTitle = Path.GetFileNameWithoutExtension(itemContentFiles[i]).Split(',');

            Text amount = header.transform.Find("Amount").gameObject.GetComponent<Text>();

            amount.text = title[1] + " tk";
            //Debug.Log(title);

            c.GetComponentInChildren<Button>().onClick.AddListener(delegate { ButtonClicked(c, sampleTexture2, isLoaded2); });
            itemContent.GetComponentInChildren<Button>().onClick.AddListener(delegate { BuyButtonClicked(title[1], popupTitle[1]); });

            //Debug.Log(itemContent.name);
        }

        //this.gameObject.GetComponentInParent<RectTransform>().anchorMin = new Vector2(0f, 0f);
        //this.gameObject.GetComponentInParent<RectTransform>().anchorMin = new Vector2(1f, 1f);
    }

    public void ButtonClicked(GameObject content, Texture2D tex, bool loaded)
    {
        GameObject itemContent = content.transform.Find("Item Content").gameObject;

        if (loaded)
        {
            itemContent.GetComponent<Image>().sprite = Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width,
                tex.height), new Vector2(0.5f, 0.5f), 100.0f);
        }
    }

    public void BuyButtonClicked(string tk, string mb)
    {
        popupText.text = "Sure you wanna purchase " + mb + " " + tk + " pack? Trust me it's totally worth it.";
        purchaseText.text = "You have successfully purchased " + mb + " " + tk + " pack. yayyy!";
        popupPanel.SetActive(true);

        Debug.Log(tk);
        Debug.Log(mb);
    }
}
