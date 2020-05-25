using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessTrigger : MonoBehaviour
{
    void OnTriggerEnter()
	{
        if (FindObjectOfType<GameManager>().gameHasEnded == false)
        {
            Debug.Log("Trigger");
            FindObjectOfType<levelGenerator>().Spawn();
        }
	}
}
