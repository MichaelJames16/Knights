using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    public GameObject player;

    private float camHeight = 1.75f;
    private float camDistance = 2.75f;
    private float facing;

	// Use this for initialization
	void Start ()
    {
        this.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + camHeight, player.transform.position.z - camDistance);
        this.transform.rotation = player.transform.rotation;


	}
	
	// Update is called once per frame
	void Update ()
    {
	    this.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + camHeight, player.transform.position.z - camDistance);

        if (Input.GetKeyDown("e"))
        {
            centerCam();
        }
    }

    private void centerCam()
    {
        this.transform.rotation = player.transform.rotation;
        this.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + camHeight, player.transform.position.z - camDistance);
    }
}
