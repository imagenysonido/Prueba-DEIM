using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguimientoCamara : MonoBehaviour
{
    public GameObject GO;
    public Transform objetivoTransform;
    private void Start()
    {
        GO = GameObject.FindWithTag("Player");
        objetivoTransform = GO.transform;
    }
    private void Update()
    {
        transform.LookAt(objetivoTransform.position);
    }
}
