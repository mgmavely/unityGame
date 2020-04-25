using UnityEngine.UI;
using UnityEngine;

public class scoreCoins : MonoBehaviour
{
    public Text scoreText;
    public GameManager gm;
    void Update()
    {
        scoreText.text = gm.coins.ToString() + "/" + gm.coinsLim.ToString();
    }
}
