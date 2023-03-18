using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour

{

    public Rigidbody2D rb;
    public float jumpAmount = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public float jumpForce=20;
    public float gravity = -9.81f;
    public float gravityScale =1f;
    float velocity;
    void Update()
    {
        velocity += gravity * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space)){
            velocity = jumpForce;
            velocity += gravity * gravityScale *Time.deltaTime;
        }
        transform.Translate(new Vector3(0, velocity, 0) * Time.deltaTime);
    }   
}
