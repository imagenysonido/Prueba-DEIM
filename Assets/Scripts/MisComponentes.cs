using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisComponentes : MonoBehaviour
{
    public BoxCollider miCollider;
    private void Start()
    {
        miCollider = GetComponent<BoxCollider>();   
    }
    private void Update()
    {
        Debug.Log(miCollider.enabled);
    }
}
