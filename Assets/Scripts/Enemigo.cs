using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    //OJO: acceso a otro Script
    public GameObject volcanGO;
    public Erupcion erupcionScript;
    public void Start()
    {
        volcanGO = GameObject.Find("volcano");
        erupcionScript = volcanGO.GetComponent<Erupcion>();
    }
    //
    private void OnCollisionEnter(Collision coll)
    {
        Renderer rd = GetComponent<Renderer>();
        if(coll.gameObject.tag == "Player")
            Destroy(coll.gameObject);
        if (coll.gameObject.tag == "Bala")
        {
            rd.material.color = Color.yellow;
            erupcionScript.StopCoroutine(erupcionScript.LaunchProjectileCoroutine);
            Debug.Log("HAS DETENIDO EL VOLCÁN");
    
            
        }


    }
    
}
