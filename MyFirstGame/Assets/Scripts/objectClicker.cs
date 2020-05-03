using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectClicker : MonoBehaviour
{
    public GameObject gameManager;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
		{
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100.0f))
			{
                if (hit.transform)
				{
                    if (hit.transform.gameObject.tag == "Clickable")
                    {
                        Destroy(hit.transform.gameObject);
                        FindObjectOfType<AudioManager>().Play("coinUp");
                        FindObjectOfType<GameManager>().coinCol();
                    }
                    else if (hit.transform.gameObject.tag == "clickWall")
					{
                        Destroy(hit.transform.gameObject);
                        FindObjectOfType<AudioManager>().Play("Crash");
                    }
				}
			}
		}
    }
}
