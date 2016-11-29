using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour
{
    public int worth = 1;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.gameObject.GetComponentInParent<Player>();//get player component
        if (player != null)
        {
            gameObject.SetActive(false);
            FindObjectOfType<GM>().CoinWasPickedUp(worth);
        }
    }
}
