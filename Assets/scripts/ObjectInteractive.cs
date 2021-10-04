using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteractive : MonoBehaviour
{

    public Texto textos;




   private void OnMouseDown() {

       FindObjectOfType<ControlDialog>().ActivarCartel(textos);
        
    }

}
