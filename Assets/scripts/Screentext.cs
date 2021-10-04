using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screentext : MonoBehaviour
{


public string textScreen;
public TextMesh pantalla;

    // Update is called once per frame
    void Update()
    {
        clickMouse clickar = GetComponent<clickMouse>();
        textScreen = clickar.texto;

        pantalla = (TextMesh)GameObject.Find("mesh").GetComponent<TextMesh>();
        pantalla.text = ""+textScreen;
    }
}
