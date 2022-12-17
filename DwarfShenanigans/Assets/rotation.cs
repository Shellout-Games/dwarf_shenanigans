using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{

    public Transform cameraJig;
    public float rotateSpeed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            transform.RotateAround(cameraJig.position, Vector3.up, rotateSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.RotateAround(cameraJig.position, -Vector3.up, rotateSpeed * Time.deltaTime);
        }
    }

}
