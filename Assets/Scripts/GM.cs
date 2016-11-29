using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GM : MonoBehaviour {
    public int coins = 0;
    public int lives = 3;

    public Text coinsText;
    public Text livesText;

    public GameObject winSign;
    public GameObject loseSign;

    // Use this for initialization
    void Start () {
        coinsText.text = coins.ToString();
        livesText.text = lives.ToString();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void CoinWasPickedUp(int worth)
    {
        coins+=worth;
        coinsText.text = coins.ToString();
    }

    public void LifeWasLost()
    {
      

        if(lives!=0)
        {
            lives--;
            livesText.text = lives.ToString();

        }
        else
        {
            loseSign.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
