using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FXTriggerReset : MonoBehaviour
{
    void OnTriggerEnter()
    {
        Debug.Log("Playing BGMusic Again");
        FindObjectOfType<AudioManager>().Play("BGMusic");
    }
}