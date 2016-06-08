using UnityEngine;
using System.Collections;

public class player_follow : MonoBehaviour {

    public GameObject player;

    private Vector3 lastPosition;
    private float speed;

    void Update()
    {
        //lastPosition = transform.
        speed = 5f;
    }

    void OnTriggerExit(Collider other)
    {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed);
        Debug.Log("Calling this");
        //not being called, I think it's because the script is attached to the camera and not to the cylinder. Go sharks
        //Vector3 direction = transform.position - lastPosition;
        //Vector3 localDirection = transform.InverseTransformDirection(direction);

        //transform.position = transform.position + localDirection;
    }
}
