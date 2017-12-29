using UnityEngine;
using System.Collections;

public class shooter : MonoBehaviour {
    public Rigidbody bullet;
    public float power = 1500.0f;
    public AudioClip shootshound;

    private Rigidbody instance;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonUp("Fire1")){            
            instance = Instantiate(bullet, transform.position+new Vector3(0,1f,0), transform.rotation)as Rigidbody;   
            Vector3 fwd = transform.TransformDirection(Vector3.forward);
            GetComponent<AudioSource>().PlayOneShot(shootshound);
            instance.AddForce(fwd*power);
            
        }
	}
}
