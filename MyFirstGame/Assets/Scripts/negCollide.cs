using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class negCollide : MonoBehaviour
{
    void OnTriggerEnter (Collider other)
	{
        if (other.name == "Player")
		{
			Destroy(gameObject);
			FindObjectOfType<AudioManager>().Play("coinUp");
			FindObjectOfType<GameManager>().negCol();
		}
	}
}
