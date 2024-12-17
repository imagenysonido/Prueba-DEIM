using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class MovimientoCubo : MonoBehaviour
{
    private Transform miTransform = null;
    public float velocidad = 1.0f;
    public float giro=180.0f;
    

    private void Start()
    {
        miTransform = GetComponent<Transform>();
    }
    private void Update()
    {
            miTransform.Translate(Vector3.forward * velocidad * Time.deltaTime * Input.GetAxis("Vertical"));
            miTransform.Rotate(Vector3.up * giro * Time.deltaTime * Input.GetAxis("Horizontal"));
    }
}
