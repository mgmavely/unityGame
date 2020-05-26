using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelGenerator : MonoBehaviour
{
    public GameObject player;
    private int rng;
    private float time = 3f;
    private GameObject holder;
    private float spawnX = 3.12f;
    private float spawnY = 1f;
    private float spawnZ = 63f;
    [SerializeField] private GameObject level_1;
    [SerializeField] private GameObject level_2;
    [SerializeField] private GameObject level_3;
    [SerializeField] private GameObject level_4;
    [SerializeField] private GameObject level_5;
    private void Awake()
	{
        holder = (GameObject) Instantiate(level_1, new Vector3(spawnX, spawnY, spawnZ + player.transform.position.z), Quaternion.identity);
        Destroy(holder, time);
	}
    public void Spawn()
    {
        rng = Random.Range(0, 5);
        Debug.Log(rng);
        if (rng == 0)
        {
            holder = (GameObject)Instantiate(level_1, new Vector3(spawnX, spawnY, spawnZ + player.transform.position.z), Quaternion.identity);
            Destroy(holder, time);
        } else if (rng == 1)
		{
            holder = (GameObject)Instantiate(level_2, new Vector3(spawnX, spawnY, spawnZ + player.transform.position.z), Quaternion.identity);
            Destroy(holder, time);
        } else if (rng == 2)
        {
            holder = (GameObject)Instantiate(level_3, new Vector3(spawnX, spawnY, spawnZ + player.transform.position.z), Quaternion.identity);
            Destroy(holder, time);
        } else if (rng == 3)
        {
            holder = (GameObject)Instantiate(level_4, new Vector3(spawnX, spawnY, spawnZ + player.transform.position.z), Quaternion.identity);
            Destroy(holder, time);
        } else if (rng == 4)
        {
            holder = (GameObject)Instantiate(level_5, new Vector3(spawnX, spawnY, spawnZ + player.transform.position.z), Quaternion.identity);
            Destroy(holder, time);
        }

    }
}
