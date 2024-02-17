using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarColorBoolean5 : MonoBehaviour
{
    bool variable;
    bool variable1;
    bool variable2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void FixedUpdate()
    {
        bool variable1 = GameObject.Find("CapsuleM7").GetComponent<CambiarColorBoolean3>().variable;
        bool variable2 = GameObject.Find("Capsule2M7").GetComponent<CambiarColorBoolean4>().variable;
        Debug.Log("GO5 > Variable1: " + variable1 + ", variable 2: " + variable2);
        //Operación: si variable1 es true se hace un "AND", si es false entonces se hace un "OR"
        if(variable1)
        {
            Debug.Log("GO5 > Se realiza un AND");
            variable = variable1 && variable2;
        } else
        {
            Debug.Log("GO5 > Se realiza un OR");
            variable = variable1 || variable2;
        }
        cambiarColor();
    }
    private void cambiarColor()
    {
        if (variable)
        {
            Debug.Log("GO5 > Entra a white");
            GetComponent<MeshRenderer>().material.color = Color.white;
        }
        else
        {
            Debug.Log("GO5 > Entra a black");
            GetComponent<MeshRenderer>().material.color = Color.black;
        }
    }
}
