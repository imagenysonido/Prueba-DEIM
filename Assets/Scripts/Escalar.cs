using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escalar : MonoBehaviour
{
    
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            HacerGrande();
        if (Input.GetButtonDown("Fire2"))
            HacerNormal();
    }
    private void HacerGrande()
    {
        transform.localScale = new Vector3(2,2,2);
    }
    private void HacerNormal()
    {
        transform.localScale = new Vector3(1, 1, 1);
    }
}
