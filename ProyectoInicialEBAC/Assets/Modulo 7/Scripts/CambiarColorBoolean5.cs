using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarColorBoolean5 : MonoBehaviour
{
    bool variable;

    public CambiarColorBoolean3 script1;
    public CambiarColorBoolean4 script2;

    // Start is called before the first frame update
    void Start()
    {
        script1 = GameObject.Find("CapsuleM7").GetComponent<CambiarColorBoolean3>();
        script2 = GameObject.Find("Capsule2M7").GetComponent<CambiarColorBoolean4>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void FixedUpdate()
    {
        Debug.Log("GO5 > Variable1: " + script1.variable + ", variable 2: " + script2.variable);
        //Operación: si variable1 es true se hace un "AND", si es false entonces se hace un "OR"
        if(script1.variable)
        {
            Debug.Log("GO5 > Se realiza un AND");
            variable = script1.variable && script2.variable;
        } else
        {
            Debug.Log("GO5 > Se realiza un OR");
            variable = script1.variable || script2.variable;
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
