using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.UI;
using DG.Tweening;

public class ScreenVideoController : MonoBehaviour {

    private RectTransform videoPanel;

    public VideoClip clip1;
    public VideoClip clip2;
    public VideoClip clip3;
    public VideoClip clip4;
    public VideoClip clip5;
    public VideoClip clip6;
    public VideoClip clip7;

    public GameObject hamburgerMenu;
    public RectTransform balanceShrePanel;

    private HamburgerHomePanel hamburgerHome;


    private VideoPlayer videoPlayer;

    void Start ()
    {
        videoPanel = this.GetComponent<RectTransform>();
        videoPlayer = GetComponentInChildren<VideoPlayer>();
        hamburgerHome = hamburgerMenu.GetComponent<HamburgerHomePanel>();

        videoPlayer.loopPointReached += CheckOver;
    }
	
	public void PlayVideo(int id)
    {

        if (id == 1)
        {
            videoPlayer.clip = clip1;
        }

        else if (id == 2)
        {
            videoPlayer.clip = clip2;
        }

        else if (id == 3)
        {
            videoPlayer.clip = clip3;
        }

        else if (id == 4)
        {
            videoPlayer.clip = clip4;
        }

        else if (id == 5)
        {
            videoPlayer.clip = clip5;
        }

        else if (id == 6)
        {
            videoPlayer.clip = clip6;
        }

        else if (id == 7)
        {
            videoPlayer.clip = clip7;
        }


        if (videoPlayer.isPlaying)
        {
            videoPlayer.Stop();
            videoPanel.DOAnchorPos(Vector2.zero, 0f);
            videoPlayer.Play();
        }

        else
        {
            videoPanel.DOAnchorPos(Vector2.zero, 0f);
            videoPlayer.Play();
        }
    }

    void CheckOver(VideoPlayer vp)
    {
        videoPanel.DOAnchorPos(new Vector2(1150f, 0f), 0f);

        if (vp.clip == clip1 || vp.clip == clip2)
        {
            hamburgerHome.OnDataClicked();
        }

        if (vp.clip == clip4 || vp.clip == clip6)
        {
            hamburgerHome.OnBalanceClicked();
            balanceShrePanel.DOAnchorPos(new Vector2(-1150f, 0f), 0f);
        }
    }
}
