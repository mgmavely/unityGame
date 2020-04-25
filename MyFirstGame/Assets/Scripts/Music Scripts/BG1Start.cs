using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG1Start : MonoBehaviour
{
        void OnTriggerEnter()
        {
            Debug.Log("Playing BGMusic Again");
        float cond = FindObjectOfType<AudioManager>().pitchVal("BGMusic");
        Debug.Log(cond);
        if (cond == 1f)
		{
            FindObjectOfType<AudioManager>().PitchD("BGMusic");
            FindObjectOfType<AudioManager>().Play("BGMusic");
        }
    }
}
