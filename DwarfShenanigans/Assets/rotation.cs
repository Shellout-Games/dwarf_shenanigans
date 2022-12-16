using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            right
        }
        if (Input.GeyKeyDown(KeyCode.Q))
        {
            left
        }
    }
    void right()
    { 
        transform.Rotate(Vector3.forward, 10.0f * Time.deltaTime);
    }
    void left()
    { 
        
    }

}
