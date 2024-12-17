using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCoroutine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Test());
    }

    IEnumerator Test()
    {
        Debug.Log("Hola");
        yield return new WaitForSeconds(3.0f);
        Debug.Log("Esto es una corrutina");
    }
}
