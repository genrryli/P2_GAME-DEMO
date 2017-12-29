using UnityEngine;
using System.Collections;

public class myTextHint : MonoBehaviour {

    float timer = 0.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (GetComponent<GUIText>().enabled)
        {
            timer += Time.deltaTime;
            if (timer >= 4)
            {
                GetComponent<GUIText>().enabled = false;
                timer = 0.0f;
            }
        }
	}

    void ShowHint()
    {
        GetComponent<GUIText>().text = "傻逼！这扇门似乎要收集所有的能源才能打开！";
        if (!GetComponent<GUIText>().enabled)
        {
            GetComponent<GUIText>().enabled = true;
        }
    }
}
