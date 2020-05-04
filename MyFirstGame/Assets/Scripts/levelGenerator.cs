using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelGenerator : MonoBehaviour
{
    private int rng;
    private float time = 7f;
    private GameObject holder;
    [SerializeField] private GameObject level_1;
    [SerializeField] private GameObject level_2;
    [SerializeField] private GameObject level_3;
    [SerializeField] private GameObject level_4;
    private void Awake()
	{
        holder = (GameObject) Instantiate(level_1, new Vector3(3.174719f, 7.358368f, 60f), Quaternion.identity);
        Destroy(holder, time);
	}
    public void Spawn()
    {
        rng = Random.Range(0, 4);
        Debug.Log(rng);
        if (rng == 0)
        {
            holder = (GameObject)Instantiate(level_1, new Vector3(3.174719f, 7.358368f, 60f), Quaternion.identity);
            Destroy(holder, time);
        } else if (rng == 1)
		{
            holder = (GameObject)Instantiate(level_2, new Vector3(3.174719f, 7.358368f, 60f), Quaternion.identity);
            Destroy(holder, time);
        } else if (rng == 2)
        {
            holder = (GameObject)Instantiate(level_3, new Vector3(3.174719f, 7.358368f, 60f), Quaternion.identity);
            Destroy(holder, time);
        } else if (rng == 3)
        {
            holder = (GameObject)Instantiate(level_4, new Vector3(3.174719f, 7.358368f, 60f), Quaternion.identity);
            Destroy(holder, time);
        }

    }
}
