using UnityEngine;
using System.Collections;

public class PatrolMovement : MonoBehaviour {

    Vector3 direction = new Vector3(-1, -.1f);
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += direction * Time.deltaTime;
        if (transform.position.x <= 0)
        {
            direction = new Vector3(1, .1f);
        }
        if (transform.position.x >= 5)
        {
            direction = new Vector3(-1, -.1f);
        }
    }
}
