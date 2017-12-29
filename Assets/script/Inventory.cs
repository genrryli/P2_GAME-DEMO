using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {
    public static int charge = 0;
    public  AudioClip collcetSound;

    public Texture2D[] hudCharge;
    public GUITexture chargeHudGUI;

	// Use this for initialization
	void Start () {
        charge = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void CellPickup()
    {
        //AudioSource.PlayClipAtPoint(collcetSound, transform.position);
        GetComponent<AudioSource>().PlayOneShot(collcetSound);
        charge++;
        chargeHudGUI.texture = hudCharge[charge];
    }
}
