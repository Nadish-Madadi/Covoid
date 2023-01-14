using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CoinPicker : MonoBehaviour
{
    private float coin = 0;
    

    public TextMeshProUGUI textCoins;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.transform.tag == "Coin")
        {
            coin ++;
            if (coin == 3)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            if (coin == 5)
            {
                SceneManager.LoadScene(0);
            }
            textCoins.text = ("Score: " + coin.ToString());

            Destroy(other.gameObject);
        }
    }
}
