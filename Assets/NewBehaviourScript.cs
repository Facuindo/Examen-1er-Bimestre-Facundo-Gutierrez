using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int Distancia;
    public int Peso;
    // Start is called before the first frame update
    void Start()
    {
        if (Peso < 100)
        {
            Debug.LogError("Error: El peso transportado no puede ser menor a cien kilos");
        }
        if (Distancia < 1)
        {
            Debug.LogError("Error: La distancia de transporte no puede ser menor a un kilometro");
        }
        int Tiempo = Distancia / 25;
        int PrecioTotal;
        int DistanciaExtra = (Distancia % 25);
        if (Peso < 2000)
        {
            PrecioTotal = Tiempo * 3000;
            Debug.Log("Se necesita un Utilitario y va a salir " + PrecioTotal + " dolares");
        }
        if (Peso < 5000 && Peso > 2000)
        {
            PrecioTotal = Tiempo * 4500;
            Debug.Log("Se necesita una Pickup y va a salir " + PrecioTotal + " dolares");
        }
        else if (Peso < 10000 && Peso > 5000)
        {
            PrecioTotal = Tiempo * 7000;
            Debug.Log("Se necesita un Camion y va a salir " + PrecioTotal + " dolares");
        }

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
