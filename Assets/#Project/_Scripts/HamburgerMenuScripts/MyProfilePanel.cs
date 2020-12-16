using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class MyProfilePanel : MonoBehaviour {

    public RectTransform hamburgerMenu;
    public RectTransform myProfilePanel;

    public Slider genderSlider;
    public Slider studentSlider;

    public GameObject collegeImage;

    public Text genderText;
    public Text studentText;


    private void Update()
    {
        if (genderSlider.value == 1 && studentSlider.value == 1)
        {
            collegeImage.SetActive(true);
        }

        else
        {
            collegeImage.SetActive(false);
        }
    }

    public void OnSaveClicked()
    {
        myProfilePanel.DOAnchorPos(new Vector2(-1150f, 0f), 0.5f);
        hamburgerMenu.DOAnchorPos(Vector2.zero, 0.25f);
    }

    public void OnCancelClicked()
    {
        myProfilePanel.DOAnchorPos(new Vector2(-1150f, 0f), 0.25f).SetDelay(0.5f);
    }

    public void OnHeaderMenuClicked()
    {
        myProfilePanel.DOAnchorPos(new Vector2(-1150f, 0f), 0.25f);
        hamburgerMenu.DOAnchorPos(Vector2.zero, 0.25f);
    }

    public void GenderSlider(float value)
    {
        if (value == 0)
        {
            genderText.text = "I am a girl";
        }

        else if (value == 1)
        {
            genderText.text = "I am a boy";
        }
    }

    public void StudentSlider(float value)
    {
        if (value == 0)
        {
            studentText.text = "I am not a student";
        }

        else if (value == 1)
        {
            studentText.text = "I am a student";
        }
    }
}
