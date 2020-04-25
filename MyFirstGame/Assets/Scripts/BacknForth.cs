using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BacknForth : MonoBehaviour
{
    public float speed = 1.5f;
    public float range = 8;
    public float delay = 0;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    transform.position = new Vector3(Mathf.PingPong((Time.time + delay )* speed, range), transform.position.y, transform.position.z) + offset;
    }
}
