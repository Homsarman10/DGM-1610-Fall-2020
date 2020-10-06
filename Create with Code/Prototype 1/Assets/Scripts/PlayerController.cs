
using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // private variables
    private float speed = 15.0f;
    private float turnSpeed = 30.0f;
    private float horizontalInput;
    private float forwardInput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    //player input
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
        // We'll take Bikini Bottom and push it somewhere else!
        transform.Translate (Vector3.forward * (Time.deltaTime * speed * forwardInput));
        transform.Rotate(Vector3.up * (Time.deltaTime * turnSpeed * horizontalInput));
    }
}
