using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class MovimientoFisico : MonoBehaviour
{

    public GameObject bala;
    public Transform mirilla;
    private Rigidbody rb;
    public float fuerzaLineal = 20.0f;
    public float fuerzaGiro = 10.0f;
    public float fuerzaDisparo = 1000.0f;
    public float fuerzaSalto = 20.0f;
        
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            StartCoroutine(Disparar(5,0.1f));
        if (Input.GetButtonDown("Jump") && rb.velocity.y < 0.01f)
            Salto();
    }

    private void FixedUpdate()
    {
        float aceleracion = Input.GetAxis("Vertical");
        float giro = Input.GetAxis("Horizontal");
        rb.AddRelativeForce(Vector3.forward * aceleracion * fuerzaLineal, ForceMode.Force);
        rb.AddTorque(Vector3.up * giro * fuerzaGiro);
        
    }
    IEnumerator Disparar(int disparos, float intervaloDisparos)
    {
        for (int i = 0; i < disparos; i++)
        {
            GameObject cloneBala = Instantiate(bala, mirilla.position, mirilla.rotation);
            Rigidbody rbBala = cloneBala.GetComponent<Rigidbody>();
            Vector3 anguloBala = new Vector3(0.0f, 0.0f, 1.0f);
            rbBala.AddRelativeForce(anguloBala * fuerzaDisparo);
            Destroy(cloneBala, 2);
            yield return new WaitForSeconds(intervaloDisparos);
        }
    }
    private void Salto()
    {
        rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
    }
    

}
