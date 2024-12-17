using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverTrigger : MonoBehaviour
{
    public float hoverForce = 12.0f;
    private void OnTriggerStay(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        rb.AddForce(Vector3.up * hoverForce, ForceMode.Acceleration);
    }
}
