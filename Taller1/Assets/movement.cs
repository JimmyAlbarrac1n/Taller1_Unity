using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Transform player; // Asigna el objeto 'Personaje' desde el Inspector
    public Vector3 offset;   // Ajusta la posición de la cámara relativa al jugador

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
                transform.position = player.position + offset;

        
    }
}
