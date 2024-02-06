using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearCubosUpdate : MonoBehaviour
{
    public GameObject PrefabCubeFromEmpty;
    public int numCubos = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        numCubos++;
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCubeFromEmpty);
        tempGameObject.name = "CuboNumero" + numCubos;
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
        tempGameObject.transform.position = Random.insideUnitSphere;
    }
}
