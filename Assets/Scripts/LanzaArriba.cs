using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanzaArriba : MonoBehaviour
{
    public float fuerzaImpulso = 10.0f;
    private void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.up * fuerzaImpulso, ForceMode.Impulse);
    }
    private void Update()
    {
        if (transform.position.y < -1.0f)
            Destroy(gameObject);
    }
}
