using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGStop : MonoBehaviour
{
    void OnTriggerEnter()
    {
        FindObjectOfType<AudioManager>().StopPlaying("BGMusic");
    }
}
