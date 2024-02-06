using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearCuboAwake : MonoBehaviour
{
    public GameObject PrefabCubeFromEmpty;
    public void Awake()
    {
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCubeFromEmpty);
        tempGameObject.name = "CuboFromEmptyPrefabAwake";
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
        tempGameObject.transform.position = Random.insideUnitSphere;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
