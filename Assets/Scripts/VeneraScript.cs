using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VeneraScript : MonoBehaviour
{
    [SerializeField]
    private GameObject sun;
    private GameObject surface;
    private GameObject atmosphere;
    private float dayPeriod = 36f / 360f;
    private float skyPeriod = 72f / 360f;
    private float yearPeriod = 30f / 360f;
    // Start is called before the first frame update
    void Start()
    {
        surface = GameObject.Find("VeneraSurface");
        atmosphere = GameObject.Find("VeneraAtmosphere");
    }

    // Update is called once per frame
    void Update()
    {
        surface.transform.Rotate(Vector3.up, Time.deltaTime / dayPeriod, Space.Self);
        atmosphere.transform.Rotate(Vector3.up, Time.deltaTime / skyPeriod);

        this.transform.RotateAround(sun.transform.position, Vector3.up, Time.deltaTime / yearPeriod);
    }
}
