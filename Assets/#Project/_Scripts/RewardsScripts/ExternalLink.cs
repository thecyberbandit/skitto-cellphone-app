using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExternalLink : MonoBehaviour {

	public void OpenLink()
    {
        Application.OpenURL("https://yts.lt/");
    }
}
