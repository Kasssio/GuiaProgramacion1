using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7 : MonoBehaviour
{
    public int num1;
    public int num2;
    public int num3;

    // Start is called before the first frame update
    void Start()
    {
        if (num1 > num2 && num1 > num3)
        {
            Debug.Log("El numero mas grande es " + num1 + "");
        }

        else if (num2 > num1 && num2 > num3)
        {
            Debug.Log("El numero mas grande es " + num2 + "");
        }

        else if (num1 == num2 && num1 == num3)
        {
            Debug.Log("Los numeros son iguales");
        }

        else
        {
            Debug.Log("El numero mas grande es " + num3 + "");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
