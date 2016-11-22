using UnityEngine;
using System.Collections;

public class RunningMovement : MonoBehaviour
{
     new  Rigidbody2D rigidbody2D;
    float startingX;
    public float speed = .5f;
    public float distance = 2;
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        startingX = transform.position.x;
 

    }
    
    void FixedUpdate()
    {
        if(transform.position.x < startingX - distance)
        {
            speed = -speed;
           // speed *= -1;
        }
        if(transform.position.x > startingX)
        {
            speed = -speed;
        }

        var v = rigidbody2D.velocity; //velocity cannot change when it is in used
        v.x = -speed;         //wanting to run to left
        rigidbody2D.velocity = v;
    //    rigidbody2D.velocity = new Vector2(-speed, rigidbody2D.velocity.y); a different option

    }
}
