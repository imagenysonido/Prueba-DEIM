using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguimientoCamara2 : MonoBehaviour
{
    public GameObject GO;
    
    private void Update()
    {
        Transform objetivoTransform = GO.transform;
        transform.LookAt(objetivoTransform.position);
    }
}
