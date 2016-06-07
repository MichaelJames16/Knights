using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    public GameObject player;
    public GameObject free_move_cylinder;

    private float camHeight = 1f;
    private float camDistance = 3f;
    private float cylinderOffset = 1f;
    private Vector3 lastPosition;

	// Use this for initialization
	void Start ()
    {
        free_move_cylinder.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + cylinderOffset, player.transform.position.z);
        transform.position = new Vector3(free_move_cylinder.transform.position.x, free_move_cylinder.transform.position.y + camHeight, free_move_cylinder.transform.position.z - camDistance);
        transform.rotation = player.transform.rotation;
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.LookAt(free_move_cylinder.transform);

        if (Input.GetKeyDown("e"))
        {
            centerCam();
        }

        lastPosition = player.transform.position;
    }

    private void centerCam()
    {
        this.transform.rotation = player.transform.rotation;
        this.transform.position = -player.transform.forward * camDistance;
        this.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + camHeight, player.transform.position.z - camDistance);
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Calling this");
        //not being called, I think it's because the script is attached to the camera and not to the cylinder. Go sharks
        Vector3 direction = transform.position - lastPosition;
        Vector3 localDirection = transform.InverseTransformDirection(direction);

        free_move_cylinder.transform.position = transform.position + localDirection;
    }
}
