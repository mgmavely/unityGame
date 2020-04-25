using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FXTrigger : MonoBehaviour
{
    void OnTriggerEnter()
	{
        FindObjectOfType<AudioManager>().Play("Cliffhanger");
        FindObjectOfType<AudioManager>().StopPlaying("BGMusic");
        Debug.Log("Play da fx!");
    }
}
