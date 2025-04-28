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
        if (Peso > 100)
        {
            Debug.LogError("Error: El peso transportado no puede ser menor a cien kilos");
        }
        if (Distancia < 1)
        {
            Debug.LogError("Error: La distancia de transporte no puede ser menor a un kilometro");
        }

    }
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
