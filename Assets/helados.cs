using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helados : MonoBehaviour
{
    public string gusto;
    public int cantidadgramos;
    float costo;


    // Start is called before the first frame update
    void Start()
    { 
        if (cantidadgramos<250 || cantidadgramos>3000)
        {
            Debug.Log("Error");
        }
        else 
        {
          if(gusto == "CHO")
            {
              costo = cantidadgramos * (500/1000);

                Debug.Log("El costo de la cantidad de chocolate que ha pedido es de" + costo + "pesos");

            }
            else if (gusto == "FRU")
            {
                costo =(cantidadgramos * (500 / 1000)) * (90/100);
                Debug.Log("El costo de la cantidad de frutilla que ha pedido es de" + costo + "pesos");
           
            }
            else if (gusto == "DDL")
            {
                costo = cantidadgramos * (500 / 1000);
                Debug.Log("El costo de la cantidad de Dulce De Leche que ha pedido es de" + costo + "pesos");

            }
            else
            {
                Debug.Log("Error");
            }
           
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
