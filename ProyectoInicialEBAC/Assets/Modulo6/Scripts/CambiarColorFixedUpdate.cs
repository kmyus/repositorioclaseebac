using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarColorFixedUpdate : MonoBehaviour
{
    public static GameObject objeto;
    public void Awake()
    {
        
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
        Color c = new Color(Random.value, Random.value, Random.value);
        GetComponent<MeshRenderer>().material.color = c;
    }
}
