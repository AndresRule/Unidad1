using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class CantDeAlimentados : MonoBehaviour
{
    public Text text;
    public ControladorJugador ctrol;
    public void UpdateText()
    {
        text.text = ctrol.alimenta2.ToString();
     }
}

