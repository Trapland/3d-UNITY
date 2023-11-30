using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Ball : MonoBehaviour
{
    private Rigidbody rb;
    private float forceFactor = 400f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float kh = Input.GetAxis("Horizontal");
        float kv = Input.GetAxis("Vertical");
        Vector3 forceDirection = new Vector3(kh, 0, kv);
        rb.AddForce(forceFactor * Time.deltaTime * forceDirection);
    }
}
