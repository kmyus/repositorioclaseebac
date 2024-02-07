using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearCuboOnDisableOnEnable : MonoBehaviour
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
        
    }

    public void OnDisable()
    {
        numCubos++;
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCubeFromEmpty);
        tempGameObject.name = "CuboNumber" + numCubos;
    }

    public void OnEnable()
    {
        numCubos++;
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCubeFromEmpty);
        tempGameObject.name = "CuboNumber" + numCubos;
    }
}
