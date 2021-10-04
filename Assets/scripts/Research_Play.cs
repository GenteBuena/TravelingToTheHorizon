using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Research_Play : MonoBehaviour
{
    public float research = 100;

    public Image barraReser;

    void Update()
    {
        research = Mathf.Clamp(research, 0,100);
        barraReser.fillAmount = research / 100;
    }
}
