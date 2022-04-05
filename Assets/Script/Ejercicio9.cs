using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio9 : MonoBehaviour
{
    // Start is called before the first frame update
    public string nombreA;
    public string nombreB;
    public string nombreC;

    public float capitalA;
    public float capitalB;
    public float capitalC;

   
    

    void Start()
    {
        float montoTotal = capitalA + capitalB + capitalC;
        float percentA = (capitalA / montoTotal) * 100;
        float percentB = (capitalB / montoTotal) * 100;
        float percentC = (capitalC / montoTotal) * 100;

        
        Debug.Log("Nombre: " + nombreA + ", Capital aportado: $" + capitalA + ", Porcentaje del capital: " + percentA +"% , Monto total aportado: $" + montoTotal);

        Debug.Log("Nombre: " + nombreB + ", Capital aportado: $" + capitalB + ", Porcentaje del capital: " + percentB + "% , Monto total aportado: $" + montoTotal);

        Debug.Log("Nombre: " + nombreC + ", Capital aportado: $" + capitalC + ", Porcentaje del capital: " + percentC + "% , Monto total aportado: $" + montoTotal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
