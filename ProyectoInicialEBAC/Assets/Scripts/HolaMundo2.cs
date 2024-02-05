using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo2 : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Hola Mundo desde Awake...");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.LogWarning("Hola Mundo desde Start...");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hola Mundo desde Update...");
    }

    private void FixedUpdate()
    {
        Debug.LogError("Hola Mundo desde FixedUpdate...");
    }

    private void LateUpdate()
    {
        Debug.LogWarning("Hola Mundo desde LateUpdate...");
    }

    private void OnDisable()
    {
        Debug.LogWarning("Hola Mundo desde OnDisable...");
    }

    private void OnEnable()
    {
        Debug.Log("Hola Mundo desde OnEnable...");
    }
}
