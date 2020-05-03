using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessTrigger : MonoBehaviour
{
    void OnTriggerEnter()
	{
        Debug.Log("Trigger");
        FindObjectOfType<levelGenerator>().Spawn();
	}
}
