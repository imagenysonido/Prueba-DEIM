using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    public Vector3 eulerRotation;
    public Quaternion rotation;
    public bool metodoQuaternion = false,
                metodoEuler = false,
                metodoRotate = false;
    public void Start()
    {
        rotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        //Por defecto la propiedad rotation (del componente Transform) muestra Quaternions
        //Los cuaternions tienen 4 valores: ángulo de rotación (W) y eje de rotación (X, Y, Z)
        Debug.Log(transform.rotation);
        //Podemos mostrar su valor Euler en grados
        //Los grados Euler tienen 3 valores en grados del giro de cada eje.
        //Sus rotaciones pueden enredarse dando lugar al efecto Gimbal Lock
        Debug.Log(transform.eulerAngles);
        
        //Metodo 1: método Rotation - Global (usamos quaterniones convirtiendo desde grados Euler) 
        if (metodoQuaternion == true)
        {
            if (Input.GetKey(KeyCode.UpArrow))
                rotation *= Quaternion.Euler(50 * Time.deltaTime, 0, 0);
            if (Input.GetKey(KeyCode.DownArrow))
                rotation *= Quaternion.Euler(-50 * Time.deltaTime, 0, 0);
            if (Input.GetKey(KeyCode.RightArrow))
                rotation *= Quaternion.Euler(0,0, 50 * Time.deltaTime);
            if (Input.GetKey(KeyCode.LeftArrow))
                rotation *= Quaternion.Euler(0,0, 50 * Time.deltaTime);
            transform.rotation = rotation;
        }
        //Metodo 2: ángulos Euler - Global
        if (metodoEuler == true)
        {
            transform.eulerAngles = eulerRotation;

            if (Input.GetKey(KeyCode.UpArrow))
                eulerRotation.x += 50 * Time.deltaTime;
            if (Input.GetKey(KeyCode.DownArrow))
                eulerRotation.x -= 50 * Time.deltaTime;
            if (Input.GetKey(KeyCode.RightArrow))
                eulerRotation.z += 50 * Time.deltaTime;
            if (Input.GetKey(KeyCode.LeftArrow))
                eulerRotation.z -= 50 * Time.deltaTime;
        }
        
        //Metodo 3: método Rotate - Global o local (usa internamiente quaterniones)
        if (metodoRotate == true) 
        {
            if (Input.GetKey(KeyCode.UpArrow))
                transform.Rotate(90 * Time.deltaTime, 0, 0, Space.Self); 
            if (Input.GetKey(KeyCode.DownArrow))
                transform.Rotate(-90 * Time.deltaTime, 0, 0, Space.Self);
            if (Input.GetKey(KeyCode.RightArrow))
                transform.Rotate(0, 0, 90 * Time.deltaTime, Space.Self);
            if (Input.GetKey(KeyCode.LeftArrow))
                transform.Rotate(0, 0, -90 * Time.deltaTime, Space.Self);
        }

        Debug.DrawLine(transform.position, transform.position + transform.right, Color.red);   // Eje X (local)
        Debug.DrawLine(transform.position, transform.position + transform.up, Color.green);   // Eje Y (local)
        Debug.DrawLine(transform.position, transform.position + transform.forward, Color.blue); // Eje Z (local)
    }
}
