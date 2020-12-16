using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class LoadLocalMachine : MonoBehaviour {

    private Image[] offersImages;


    void Awake()
    {
        offersImages = GetComponentsInChildren<Image>();    
    }

    void Start()
    {
        byte[] byteArray;

        for (int i = 0; i < offersImages.Length; i++)
        {
            if (i == 0)
            {
                byteArray = File.ReadAllBytes(@"F:\Offers\1.png");
            }

            else if (i == 1)
            {
                byteArray = File.ReadAllBytes(@"F:\Offers\2.png");
            }

            else if (i == 2)
            {
                byteArray = File.ReadAllBytes(@"F:\Offers\3.png");
            }

            else if (i == 3)
            {
                byteArray = File.ReadAllBytes(@"F:\Offers\4.png");
            }

            else if (i == 4)
            {
                byteArray = File.ReadAllBytes(@"F:\Offers\5.png");
            }

            else if (i == 5)
            {
                byteArray = File.ReadAllBytes(@"F:\Offers\6.png");
            }

            else
            {
                byteArray = File.ReadAllBytes(@"F:\Offers\7.png");
            }

            Texture2D sampleTexture = new Texture2D(2, 2);

            bool isLoaded = sampleTexture.LoadImage(byteArray);

            if (isLoaded)
            {

                offersImages[i].sprite = Sprite.Create(sampleTexture, new Rect(0.0f, 0.0f, sampleTexture.width, sampleTexture.height), new Vector2(0.5f, 0.5f), 100.0f);
            }
        }
    }
}
