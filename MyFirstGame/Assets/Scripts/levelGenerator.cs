using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelGenerator : MonoBehaviour
{
    private float time = 7f;
    private GameObject holder;
    [SerializeField] private GameObject levels;
    private void Awake()
	{
        holder = (GameObject) Instantiate(levels, new Vector3(3.174719f, 7.358368f, 60f), Quaternion.identity);
        Destroy(holder, time);
	}
    public void Spawn ()
	{
        holder = (GameObject) Instantiate(levels, new Vector3(3.174719f, 7.358368f, 60f), Quaternion.identity);
        Destroy(holder, time);
    }
}
