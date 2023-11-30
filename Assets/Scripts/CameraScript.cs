using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    //[SerializeField]
    //public GameObject player;
    [SerializeField]
    public GameObject sun;

    private float camEulerX;
    private float camEulerY;
    private Vector3 camSun;
    private float camSunEulerX;
    private float camSunEulerY;
    private Camera _camera;
    // Start is called before the first frame update
    void Start()
    {
        sun = GameObject.Find("Sun");
        camEulerX = this.transform.eulerAngles.x;
        camEulerY = this.transform.eulerAngles.y;
        camSun = sun.transform.position - this.transform.position;
        camSunEulerX = 0;
        camSunEulerY = 0;
        _camera = this.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        float mx = Input.GetAxis("Mouse X"); // це не координати, а дані
        float my = Input.GetAxis("Mouse Y"); // про пересування миші
        camEulerX -= my;
        camEulerY += mx;
        if(Input.GetMouseButton(0))
        {
            camSunEulerX -= my;
            camSunEulerY += mx;
        }
       
        //transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 6, player.transform.position.z - 2);
        //this.transform.Rotate(-my, mx, 0);
    }

    private void LateUpdate()
    {
        this.transform.eulerAngles = new Vector3(camEulerX, camEulerY, 0f);
        if (Input.GetMouseButton(0))
        {
            
            this.transform.position = 
                sun.transform.position - 
                Quaternion.Euler(camSunEulerX, camSunEulerY, 0) * camSun;
        }
        Vector2 scroll = Input.mouseScrollDelta;
        if (scroll != Vector2.zero)
        {
            float temp = _camera.fieldOfView - scroll.y;
            if (temp >= 5 && temp <= 120)
                _camera.fieldOfView = temp;
        }
    }
}
/* Управління камерою
 *  1. Обертання рухами миші
 *  
 */