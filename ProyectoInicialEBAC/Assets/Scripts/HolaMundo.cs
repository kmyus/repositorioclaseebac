using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    int x;

    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        print("Algo pasó");
        
        Debug.LogWarning("Algo salió medianamente mal");
        Debug.LogError("Algo salio muy mal.");
    }

    // Update is called once per frame
    void Update()
    {
        //x++;
        //Debug.Log(x);

        Debug.Log("Hola desde update");
    }

    private void FixedUpdate()
    {
        Debug.LogWarning("Hola desde fixed update cada 50 frames");
    }

    private void LateUpdate()
    {
        Debug.Log("Hola desdelate update");
    }

    private void OnEnable()
    {
        Debug.LogWarning("el objeto ha sido habilitado");
    }

    private void OnDisable()
    {
        Debug.LogWarning("el objeto ha sido inhabilitado");
    }
}
