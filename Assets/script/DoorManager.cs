using UnityEngine;
using System.Collections;

public class DoorManager : MonoBehaviour {

    bool doorIsOpen = false;
    float doorTimer = 0.0f;

    public float doorOpenTime = 3.0f;
    public AudioClip doorOpenSound;
    public AudioClip doorShutSound;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (doorIsOpen)
        {
            doorTimer += Time.deltaTime;
            if (doorTimer > doorOpenTime)
            {
                DoorShut();
                doorTimer = 0.0f;
            }
             
        }
	
	}

    void DoorCheck()
    {
        if (!doorIsOpen)
        {
            DoorOpen();
        }
    }

    void DoorOpen()
    {
        transform.parent.GetComponent<Animation>().Play("dooropen");
        GetComponent<AudioSource>().PlayOneShot(doorOpenSound);
        doorIsOpen = true;
    }

    void DoorShut()
    {
        transform.parent.GetComponent<Animation>().Play("doorshut");
        GetComponent<AudioSource>().PlayOneShot(doorShutSound);
        doorIsOpen = false;
    }
}
