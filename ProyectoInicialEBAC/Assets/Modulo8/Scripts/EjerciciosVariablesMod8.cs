using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    int contadorEntero;
    float factorFlotante;
    float contadorFlotante;

    // Start is called before the first frame update
    void Start()
    {
        //Parte 1 Punto 1
        contadorEntero = 0;
        factorFlotante = 2f;
        contadorFlotante = 1f;

        //Parte 1 Punto 2
        float a = 5.5f;
        float b = 2.5f;
        int c = (int)(a * b);
        Debug.Log($"El valor entero de {a} * {b} es: {c}");

        //Parte 1 Punto 5
        float pi = 3.14159f;
        string piString = pi.ToString("0.0000");
        Debug.Log($"Float a cadena: {piString}");

        //Parte 1 Punto 6
        string nombreCompleto = "Alejandro De La Rosa Sanchez";
        string nombre = nombreCompleto.Substring(0, 9);
        string paterno = nombreCompleto.Substring(10, 10);
        string materno = nombreCompleto.Substring(21, 7);
        Debug.Log($"Nombre: {nombre}");
        Debug.Log($"Paterno: {paterno}");
        Debug.Log($"Materno: {materno}");
        List<string> nombreEnLista = nombreCompleto.Split(" ").ToList();
        int contador = 0;
        foreach(string n in nombreEnLista)
        {
            contador++;
            Debug.Log($"Token {contador}: {n}");
        }

        //**************************
        //Parte 2 Punto 1
        string numero1 = "1596";
        string numero2 = "3578";
        int n1 = 0;
        int n2 = 0;
        if(int.TryParse(numero1, out n1) && int.TryParse(numero2, out n2))
        {
            Debug.Log($"El resultado de multiplicar {n1} * {n2} es: {n1*n2}");
        }

        //Parte 2 Punto 2
        string enunciado = "Hola Mundo";
        Debug.Log($"El enunciado original es: \"{enunciado}\"");
        for (int i = 0; i < enunciado.Length - 1; i++)
        {
            if((i % 2) == 0)
            {
                Debug.Log($"Letra par: {enunciado[i]}");
            }
        }

        //Parte 2 Punto 3
        string enunciado2 = "programas";
        Debug.Log($"El enunciado \"{enunciado2}\" sin los 5 primeros caracteres es: \"{enunciado2.Substring(5)}\"");


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void FixedUpdate()
    {
        //Parte 1 Punto 1
        contadorEntero++;
        contadorFlotante *= factorFlotante;
        Debug.Log("Contador entero: " + contadorEntero);
        Debug.Log($"Contador flotante: {contadorFlotante}");

        //Parte 1 Punto 3 y 4
        string parImpar = "";
        if ((contadorEntero % 2) == 0)
        {
            Debug.Log($"{contadorEntero} es par");
            parImpar = "par";
        }
        else
        {
            Debug.Log($"{contadorEntero} es impar");
            parImpar = "impar";
        }

        switch (parImpar)
        {
            case "par":
                GetComponent<MeshRenderer>().material.color = Color.white;
                break;
            case "impar":
                GetComponent<MeshRenderer>().material.color = Color.black;
                break;
            default:
                GetComponent<MeshRenderer>().material.color = Color.blue;
                break;
        }
    }

}
