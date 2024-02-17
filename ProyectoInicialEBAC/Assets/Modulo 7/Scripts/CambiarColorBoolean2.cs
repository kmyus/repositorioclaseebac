using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarColorBoolean2 : MonoBehaviour
{
    public bool variable;
    public void Awake()
    {
        //Sólo lo pongo para que inicialice el color con referencia al valor de la variable boleana (true)
        variable = true;
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
        //Agrego esta función para que el segundo objeto vaya generando aleatoriamente true o false
        int valor = Random.Range(0, 2);
        variable = (valor == 1 ? true : false);
        cambiarColor();
        
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
