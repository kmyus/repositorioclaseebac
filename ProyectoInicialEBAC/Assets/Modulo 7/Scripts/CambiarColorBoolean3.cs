using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CambiarColorBoolean3 : MonoBehaviour
{
    public bool variable;
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
        bool variable1 = GameObject.Find("CubeM7").GetComponent<CambiarColorBoolean1>().variable;
        bool variable2 = GameObject.Find("SphereM7").GetComponent<CambiarColorBoolean2>().variable;
        Debug.Log("GO3 > Variable1: " + variable1 + ", variable 2: " + variable2);
        variable = variable1 && variable2;
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
