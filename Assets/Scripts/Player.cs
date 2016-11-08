using UnityEngine;
using System.Collections;
using System;

public class Player : MonoBehaviour {
    const float DEAD_ZONE_HEIGHT = -2;
    public float maxSpeed=3;
    private Vector3 startPosition;
    private new Rigidbody2D rigidbody2D;
    public float jumpForce=5;

    // Use this for initialization
    void Start () {
        rigidbody2D = GetComponent<Rigidbody2D>();
        startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	   if(transform.position.y < DEAD_ZONE_HEIGHT)
        {
            Die();
        }

        var x_force = Input.GetAxis("Horizontal");
        rigidbody2D.velocity += Vector2.right * x_force; //take the current velocity and add to it
        rigidbody2D.velocity = Vector2.ClampMagnitude(rigidbody2D.velocity, maxSpeed);//clamp means limit magnitude

        // if(Input.GetButtonDown("Jump")&& rigidbody2D.velocity.y==0) allow to fly
        if (Input.GetButtonDown("Jump") && rigidbody2D.velocity.y == 0)
        {
            rigidbody2D.velocity += Vector2.up*jumpForce; 
        }

        if (rigidbody2D.velocity.x > 0)
        {
            transform.rotation = new Quaternion(0,0,0,0);

        }
        else if(rigidbody2D.velocity.x<0)
        {
            transform.rotation = new Quaternion(0, 180, 0, 0);
        }
    }

    public void Die()
    {
        transform.position = startPosition;
        rigidbody2D.velocity = new Vector2();
        FindObjectOfType<GM>().LifeWasLost();
    }
}
