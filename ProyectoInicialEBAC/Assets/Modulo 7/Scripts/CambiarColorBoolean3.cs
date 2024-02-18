using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CambiarColorBoolean3 : MonoBehaviour
{
    public bool variable;

    public CambiarColorBoolean1 script1;
    public CambiarColorBoolean2 script2;

    // Start is called before the first frame update
    void Start()
    {
        script1 = GameObject.Find("CubeM7").GetComponent<CambiarColorBoolean1>();
        script2 = GameObject.Find("SphereM7").GetComponent<CambiarColorBoolean2>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void FixedUpdate()
    {
        Debug.Log("GO3 > Variable1: " + script1.variable + ", variable 2: " + script2.variable);
        variable = script1.variable && script2.variable;
        cambiarColor();
    }
    private void cambiarColor()
    {
        if (variable)
        {
            Debug.Log("GO3 > Entra a white");
            GetComponent<MeshRenderer>().material.color = Color.white;
        }
        else
        {
            Debug.Log("GO3 > Entra a black");
            GetComponent<MeshRenderer>().material.color = Color.black;
        }
    }
}
