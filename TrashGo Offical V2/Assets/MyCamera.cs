using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCamera : MonoBehaviour
{

    public float Yaxis;
    public float Xaxis;
    public float RotationSensitivity = 8f;

    public float RotationMin;
    public float RotationMax;

    public Transform target;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Yaxis += Input.GetAxis("Mouse X") * RotationSensitivity;
        Xaxis -= Input.GetAxis("Mouse Y") * RotationSensitivity;

        Xaxis = Mathf.Clamp(Xaxis, RotationMin, RotationMax);
        Vector3 targetRotation = new Vector3(Xaxis, Yaxis);
        transform.eulerAngles = targetRotation;

        transform.position = target.position - transform.forward * 2f;


    }
}
