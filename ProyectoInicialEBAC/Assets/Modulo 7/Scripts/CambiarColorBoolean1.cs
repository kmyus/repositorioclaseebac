using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CambiarColorBoolean1 : MonoBehaviour
{
    public bool variable;
    public void Awake()
    {
        //Sólo lo pongo para que inicialice el color con referencia al valor de la variable boleana (falso)
        cambiarColor();
    }

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
        cambiarColor();
        variable = !variable;
    }

    private void cambiarColor()
    {
        if (variable)
        {
            GetComponent<MeshRenderer>().material.color = Color.white;
        }
        else
        {
            GetComponent<MeshRenderer>().material.color = Color.black;
        }
    }
}


