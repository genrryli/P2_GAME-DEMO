using UnityEngine;
using System.Collections;

public class TriggerZone : MonoBehaviour {
    public Light doorlight;
    public GUIText textHints;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Inventory.charge == 4) {
            doorlight.color = Color.green;
        }

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (Inventory.charge == 4)
            {
                transform.FindChild("door").SendMessage("DoorCheck");
            }
            else {
                textHints.SendMessage("ShowHint");
            }            
          
        }
    }
}
