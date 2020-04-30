using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateZ : MonoBehaviour
{
    public float speed = 75.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.left * speed * Time.deltaTime);
    }
}
