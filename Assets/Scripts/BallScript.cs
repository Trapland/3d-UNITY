using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    private Rigidbody rb;
    private float forceFactor = 250f;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * Time.timeScale * forceFactor);
        }
        if(Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * Time.timeScale * 1);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.back * Time.timeScale * 1);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * Time.timeScale * 1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * Time.timeScale * 1);
        }
    }
}
