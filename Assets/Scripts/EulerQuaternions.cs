using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EulerQuaternions : MonoBehaviour
{
    public Quaternion rotation;
    private void Start()
    {
        rotation = transform.rotation;

    }
    private void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
            rotation *= Quaternion.Euler(45 * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.DownArrow))
            rotation *= Quaternion.Euler(-45 * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.RightArrow))
            rotation *= Quaternion.Euler(0, 0, 45 * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow))
            rotation *= Quaternion.Euler(0, 0, -45 * Time.deltaTime);
        transform.rotation = rotation;
        
    }


}
