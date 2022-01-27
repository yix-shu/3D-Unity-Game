using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform player;
    public float smoothSpeed = 0.125f;
    public Vector3 offset; //this will be the distance the camera maintains from the player

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate() //runs a little after
    {
        transform.position = player.position + offset;
    }
}
