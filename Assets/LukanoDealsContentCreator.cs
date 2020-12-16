using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class LukanoDealsContentCreator : MonoBehaviour {

    public GameObject lockedContent;
    public GameObject[] contents;
    public string[] lockedTitle;
    public string[] lockedAmount;

    public GameObject lockedPanel;
    public GameObject popupPanel;
    public GameObject purchasePanel;
    public GameObject unlockPanel;

    public Text lockedText;
    public Text popupText;
    public Text purchaseText;
    public Text unlockText;

    string[] headerFiles;
    string[] itemContentFiles;


    void Start()
    {
        headerFiles = Directory.GetFiles(@"C:\Skitto\Lukano Deals Header\");
        itemContentFiles = Directory.GetFiles(@"C:\Skitto\Lukano Deals Content\");

        lockedTitle = new string[headerFiles.Length];
        lockedAmount = new string[headerFiles.Length];
        contents = new GameObject[headerFiles.Length];


        for (int i = 0; i < headerFiles.Length; i++)
        {
            GameObject header;
            GameObject itemContent;

            GameObject c = Instantiate(lockedContent);
            contents[i] = c;
            c.transform.SetParent(this.gameObject.transform);
            c.GetComponent<LockController>().serialNumber = i;

            if (i == 0)
            {
                c.GetComponent<LockController>().isLocked = false;
            }


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

            if (isLoaded2)
            {
                itemContent.GetComponent<Image>().sprite = Sprite.Create(sampleTexture2, new Rect(0.0f, 0.0f, sampleTexture2.width,
                    sampleTexture2.height), new Vector2(0.5f, 0.5f), 100.0f);
            }

            string[] title = Path.GetFileNameWithoutExtension(headerFiles[i]).Split('.');
            string[] mb = Path.GetFileNameWithoutExtension(itemContentFiles[i]).Split(',');
            lockedTitle[i] = mb[1];
            lockedAmount[i] = title[1];

            Text amount = header.transform.Find("Amount").gameObject.GetComponent<Text>();

            amount.text = title[1] + " tk";
            //Debug.Log(title);

            //c.GetComponentInChildren<Button>().onClick.AddListener(delegate { ButtonClicked(c, sampleTexture2, isLoaded2); });
            //itemContent.GetComponentInChildren<Button>().onClick.AddListener(delegate { BuyButtonClicked(title[1], mb[1], i); });
            c.transform.Find("Header").GetComponentInChildren<Button>().onClick.AddListener(delegate { ButtonClicked(c); });

            //Debug.Log(lockedTitle[i]);
        }
    }

    

    public void ButtonClicked(GameObject c)
    {
        LockController locked = c.GetComponent<LockController>();

        if (!locked.isLocked)
        {
            c.transform.Find("Header").GetComponentInChildren<Button>().gameObject.SetActive(false);
            c.transform.Find("Item Content").gameObject.SetActive(true);
            c.transform.Find("Item Content").gameObject.GetComponentInChildren<Button>().onClick.AddListener(delegate { BuyButtonClicked(c); });
        }

        else if (locked.isLocked)
        {
            string title = lockedTitle[locked.serialNumber - 1];
            lockedText.text = "Buy lukano deal " + title + " to unlock this deal";
            lockedPanel.SetActive(true);
            Debug.Log("Lock clicked");
        }
    }

    public void BuyButtonClicked(GameObject c)
    {
        Debug.Log("Click");
        LockController locked = c.GetComponent<LockController>();
        popupText.text = "You will be using " + lockedAmount[locked.serialNumber] + " tk to purchase lukano deal " + lockedTitle[locked.serialNumber] + " with 3 days validity";
        purchaseText.text = "Yayyy! You just bought lukano deal " + lockedTitle[locked.serialNumber] + " with 3 days validity for " + lockedAmount[locked.serialNumber] + " tk";
        string t = lockedTitle[locked.serialNumber + 1];
        unlockText.text = "You have unlocked lukano deal " + t;
        popupPanel.SetActive(true);
        unlockPanel.GetComponentInChildren<Button>().onClick.AddListener(delegate { UnlockClicked(locked.serialNumber); });
        //Debug.Log(tk);
        //Debug.Log(mb);
    }

    public void UnlockClicked(int num)
    {
        contents[num + 1].GetComponent<LockController>().isLocked = false;
    }
}
