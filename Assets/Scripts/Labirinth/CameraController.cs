using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private float camAngleX;
    private float camAngleY;
    private float rodAngleX;
    private float rodAngleY;
    private Vector3 camRod;
    // Start is called before the first frame update
    void Start()
    {
        camAngleX = this.transform.eulerAngles.x;
        camAngleY = this.transform.eulerAngles.y;
        camRod = transform.position;
        rodAngleX = rodAngleY = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        float mx = Input.GetAxis("Mouse X");
        float my = Input.GetAxis("Mouse Y");
        camAngleX -= my;
        camAngleY += mx;
        rodAngleX -= my;
        rodAngleY += mx;
    }
    private void LateUpdate()
    {
        this.transform.eulerAngles = new Vector3(camAngleX, camAngleY, 0);
        transform.position = Quaternion.Euler(rodAngleX, rodAngleY, 0) * camRod;
        float rotX = transform.rotation.x;
        float rotY = transform.position.y;
        transform.position = new Vector3(transform.position.x, transform.position.y, 0f);



    }
}
