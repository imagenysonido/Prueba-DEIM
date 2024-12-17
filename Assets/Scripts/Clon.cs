using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clon : MonoBehaviour
{
    public GameObject bellota;
    public Transform posicionRotacion;
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //CrearObjetos();
            CrearObjetosConPosicion();
        }
        transform.Translate(Vector3.right * Input.GetAxis("Vertical")*4.0f * Time.deltaTime, Space.Self);
        transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * 180.0f * Time.deltaTime);
    }
    
    private void CrearObjetos() 
    {
        Instantiate(bellota);
    }
    private void CrearObjetosConPosicion() 
    {
        Instantiate(bellota, posicionRotacion.position, posicionRotacion.rotation);
    }
}
