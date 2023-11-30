using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gates1Script : MonoBehaviour
{
    private float swingPeriod = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float factor = Time.deltaTime / swingPeriod;
        if(!LabirinthState.checkPoint1Passed)
        {
            factor *= 0.03f;
        }
        Vector3 newPosition = this.transform.position + factor * Vector3.down;
        if (newPosition.y <= -0.6f || newPosition.y >= 0.56f)
        {
            newPosition.y = Mathf.Clamp(newPosition.y, -0.6f, 0.56f);

            swingPeriod = -swingPeriod;
        }
        this.transform.position = newPosition;

    }
}
