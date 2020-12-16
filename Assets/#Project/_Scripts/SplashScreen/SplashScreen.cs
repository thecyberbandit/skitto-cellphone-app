using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class SplashScreen : MonoBehaviour {

    public RectTransform balanceDashboard;


    public void OnExploreClicked()
    {
        balanceDashboard.DOAnchorPos(Vector2.zero, 0.25f);
    }
}
