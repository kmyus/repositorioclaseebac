using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesBooleanas : MonoBehaviour
{
    bool variable1;
    bool variable2;
    bool variable3;

    // Start is called before the first frame update
    void Start()
    {
        variable1 = true;
        variable2 = false;
        if(variable1 && variable2)
        {
            Debug.Log("la operación dió resultado verdadero");
        } else
        {
            Debug.Log("la operación dió resultado falso");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
