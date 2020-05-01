using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endMusic : MonoBehaviour
{
    public void bwahaha ()
	{
        FindObjectOfType<AudioManager>().creditsMusic();

    }
}
