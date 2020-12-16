using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockController : MonoBehaviour {

    public GameObject blurPanel;
    public GameObject itemContent;
    public Button expandButton;
    public Sprite moreImage;

    public GameObject lockedPopup;
    public GameObject popupPanel;
    public GameObject purchasePanel;
    public GameObject unlockPanel;

    public Text lockedText;
    public Text popupText;
    public Text purchaseText;
    public Text unlockText;

    public int serialNumber;

    public bool isLocked = true;

    private LukanoDealsContentCreator creator;


    private void Start()
    {
        creator = GetComponentInParent<LukanoDealsContentCreator>();
        //this.transform.Find("Header").GetComponentInChildren<Button>().onClick.AddListener(delegate { ButtonClicked(); });
    }

    private void Update()
    {
        if (!isLocked)
        {
            blurPanel.SetActive(false);
            expandButton.GetComponent<Image>().sprite = moreImage;
        }
    }

    public void ButtonClicked()
    {
        if (!isLocked)
        {
            expandButton.gameObject.SetActive(false);
            itemContent.SetActive(true);
            itemContent.GetComponentInChildren<Button>().onClick.AddListener(delegate { BuyButtonClicked(); });
        }

        else if (isLocked)
        {
            string title = creator.lockedTitle[serialNumber - 1];
            lockedText.text = "Buy lukano deal " + title + " to unlock this deal";
            lockedPopup.SetActive(true);
            Debug.Log("Lock clicked");
            Debug.Log("This item is locked");
            Debug.Log(serialNumber);
        }
    }

    public void BuyButtonClicked()
    {
        Debug.Log("Buy button clicked");
        popupText.text = "You will be using " + creator.lockedAmount[serialNumber] + " tk to purchase lukano deal " + creator.lockedTitle[serialNumber] + " with 3 days validity";
        purchaseText.text = "Yayyy! You just bought lukano deal " + creator.lockedTitle[serialNumber] + " with 3 days validity for " + creator.lockedAmount[serialNumber] + " tk";
        string t = creator.lockedTitle[serialNumber + 1];
        unlockText.text = "You have unlocked lukano deal " + t;
        popupPanel.SetActive(true);
        creator.contents[serialNumber + 1].GetComponent<LockController>().isLocked = false;
    }
}
