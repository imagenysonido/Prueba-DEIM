using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public GameObject GO;
    public Transform objetoTransform;
    

    public Vector3 eje = Vector3.up;
    public float velAngular = 45.0f;
    void Start() {
        objetoTransform = GO.GetComponent<Transform>();    
    }


    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(objetoTransform.position, eje, velAngular*Time.deltaTime);   
    }
}
