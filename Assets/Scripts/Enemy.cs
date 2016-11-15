using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    Vector3 direction = new Vector3(-1,-.1f);
    // Update is called once per frame
    void Update()
    {
        //deltaTime is a float
        /* transform.position += direction * Time.deltaTime;

         if(transform.position.x <= 0)
         {
             // direction = Vector3.right;
             direction = new Vector3(1, -0.1f);
         }
         if (transform.position.x >= 5)
         {
             // direction = Vector3.right;
             direction = new Vector3(-1, -0.1f);
         }
         */

        //transform.position = Vector3.MoveTowards(transform.position, FindObjectOfType<Player>().transform.position,Time.deltaTime);
        transform.position = Vector3.Slerp(transform.position, FindObjectOfType<Player>().transform.position, Time.deltaTime);
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        // var player get the reference from the collision 
        var player = collision.gameObject.GetComponent<Player>();
        if (player != null)
        {
            player.Die();
        }
    }

}
