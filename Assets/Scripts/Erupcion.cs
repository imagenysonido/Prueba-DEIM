using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Erupcion : MonoBehaviour
{
    public GameObject objetoTemporal;
    public Transform crater;
    public float frecuenciaLava = 1.0f;
    
    public Coroutine LaunchProjectileCoroutine;

    private void Start()
    {
        LaunchProjectileCoroutine = StartCoroutine(LaunchProjectile(frecuenciaLava));
    }
    public IEnumerator LaunchProjectile(float frecuencia)
    {
        yield return new WaitForSeconds(2.0f);
        while (true)
        {
            GameObject GO = Instantiate(objetoTemporal, crater.position, Random.rotation);
            Rigidbody rb = GO.GetComponent<Rigidbody>();
            rb.velocity = (Random.insideUnitSphere * 10);
            yield return new WaitForSeconds(frecuencia);
        }
    }
}
