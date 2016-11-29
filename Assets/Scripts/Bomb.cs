using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        var enemies = FindObjectsOfType<Enemy>();// will give array of type enemy
       foreach(var e in enemies)
        {
            e.gameObject.SetActive(false);
        }
        gameObject.SetActive(false);
    

    }
   
    
}
