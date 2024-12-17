using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguimientoEsfera : MonoBehaviour
{
    public GameObject objetivo;
    public Vector3 diferencia,
                   direccion;
    public float distancia,
                 velocidad;
    public bool mueve;
    private void Start()
    {
        objetivo = GameObject.Find("Cube");
    }
    private void Update()
    {
        diferencia = objetivo.transform.position - transform.position;
        distancia = diferencia.magnitude;
        direccion = diferencia.normalized;

        // Dibuja un vector que representa la dirección y distancia en la escena
        Debug.DrawLine(Vector3.zero, objetivo.transform.position, Color.white); // Línea blanca al objetivo
        Debug.DrawLine(Vector3.zero, transform.position, Color.white); // Línea blanca a la esfera
        Debug.DrawLine(transform.position, objetivo.transform.position, Color.yellow); // Línea roja al objetivo
        
        if (mueve)
        {
            transform.position += direccion * distancia * velocidad * Time.deltaTime; 
        }
    }
}
