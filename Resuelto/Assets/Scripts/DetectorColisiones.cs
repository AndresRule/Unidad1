using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;


public class DetectorColisiones : MonoBehaviour
{
    public ControladorJugador ctrol;
    public void Start()
    {
        ctrol = FindObjectOfType<ControladorJugador>();

    }
    private void OnTriggerEnter(Collider other)
    {
        ctrol.alimenta2 = ctrol.alimenta2 + 1;
        Destroy(gameObject); // Chau pizza
        Destroy(other.gameObject); // Chau animal
        
       


    }
    
}