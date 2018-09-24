using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointe : MonoBehaviour
{

    // Use this for initialization
    public GameObject point;

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 direction = transform.position - point.transform.position;

        Rigidbody rb = transform.GetComponent<Rigidbody>();

        rb.AddForce(direction);
    }
}
