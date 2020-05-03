using UnityEngine.UI;
using UnityEngine;

public class score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public int mod = 1;
    void Update()
    {
        if (FindObjectOfType<GameManager>().gameHasEnded == false) {
        scoreText.text = (mod * player.position.z).ToString("0");      
        }
    }
}
