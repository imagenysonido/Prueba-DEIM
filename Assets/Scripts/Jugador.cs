using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public GameObject enemigoGO;
    public Enemigo enemigoScript;
    public bool destruir;
    private void Start()
    {
        enemigoGO = GameObject.Find("ElEnemigo");
        enemigoScript = enemigoGO.GetComponent<Enemigo>();
    }
    private void Update()
    {
        if (destruir == true)
            Destroy(enemigoGO);
        destruir = false;
    }
}
