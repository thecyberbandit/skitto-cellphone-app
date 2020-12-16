using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class InputFieldController : MonoBehaviour
{
    public Image numberImage;
    public Image amountImage;

    public Button reloadButton;
    public Sprite activeSprite;

    public RectTransform hamburgerMenu;
    public RectTransform balanceSharePanel;


    public void ChangeColorNumber()
    {
        numberImage.color = Color.yellow;
        amountImage.color = Color.white;

        reloadButton.GetComponent<Image>().sprite = activeSprite;
    }

    public void ChangeColorAmount()
    {
        amountImage.color = Color.yellow;
        numberImage.color = Color.white;

        reloadButton.GetComponent<Image>().sprite = activeSprite;
    }

    public void OnMenuClicked()
    {
        hamburgerMenu.DOAnchorPos(Vector2.zero, 0.25f);
        balanceSharePanel.DOAnchorPos(new Vector2(-1150f, 0f), 0.25f);
    }
}
