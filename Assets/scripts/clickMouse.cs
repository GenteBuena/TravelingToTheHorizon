using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickMouse : MonoBehaviour
{
    public string texto = "";



    // Update is called once per frame
    void Update()
    {
        OnMouseDown();
        
    }

    public void OnMouseDown(){
        if(Input.GetMouseButton(0)){
            texto = "mensaje sobre la nasa";
        }else{
            texto= "";
        }
    }
}
