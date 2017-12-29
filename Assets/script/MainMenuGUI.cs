using UnityEngine;
using System.Collections;

public class MainMenuGUI : MonoBehaviour {
    public AudioClip beep;
    public GUISkin menuSkin;
    public Rect menuArea;
    public Rect playButton;
    public Rect instructionsButton;
    public Rect quitButton;
    public Rect guidance;
    string menuPage = "main";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
     
	}

    void OnGUI()
    {
        GUI.skin = menuSkin;
        GUI.BeginGroup(menuArea);
        if (menuPage == "main")
        {
            if (GUI.Button(new Rect(playButton), "开始"))
            {
                StartCoroutine("ButtonAction", "island");
            }
            if (GUI.Button(new Rect(instructionsButton), "说明"))
            {
                GetComponent<AudioSource>().PlayOneShot(beep);
                menuPage = "guidance";
            }
            if (GUI.Button(new Rect(quitButton), "退出"))
            {
                StartCoroutine("ButtonAction", "quit");
            }
        }
        else if (menuPage == "guidance")
        {
            GUI.Label(new Rect(guidance), "点开的是傻逼！哈哈哈哈哈哈哈哈哈哈哈");
            if (GUI.Button(new Rect(quitButton), "返回"))
            {
                GetComponent<AudioSource>().PlayOneShot(beep);
                menuPage = "main";
            }
        }

        GUI.EndGroup();
    }

    IEnumerator ButtonAction(string levelName)
    {
        GetComponent<AudioSource>().PlayOneShot(beep);
        yield return new WaitForSeconds(0.35f);
        if (levelName != "quit")
        {
            Application.LoadLevel(levelName);
        }
        else
        {
            Application.Quit();
            Debug.Log("这个按钮有效！！");
        }

    }
}
