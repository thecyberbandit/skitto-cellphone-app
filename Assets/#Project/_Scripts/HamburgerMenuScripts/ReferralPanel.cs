using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ReferralPanel : MonoBehaviour {

    public RectTransform hamburgerMenu;
    public RectTransform referralPanel;

    public void OnHeaderMenuClicked()
    {
        referralPanel.DOAnchorPos(new Vector2(-1150f, 0f), 0.25f);
        hamburgerMenu.DOAnchorPos(Vector2.zero, 0.25f);
    }
}
