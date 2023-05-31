using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    float moveSpeed = 0.1f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float hValue = Input.GetAxis("Horizontal") * moveSpeed;
        float vValue = Input.GetAxis("Vertical") * moveSpeed;

        Debug.Log(hValue);

        transform.Rotate(0, 0, vValue);
        transform.Translate(hValue, 0, 0);
    }
}
