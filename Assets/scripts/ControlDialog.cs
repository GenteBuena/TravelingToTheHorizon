using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControlDialog : MonoBehaviour
{

    private Animator anim;
    private Queue <string> colaDialogos;
    Texto texto;
    [SerializeField] TextMeshProUGUI textoPantalla;


    public void ActivarCartel(Texto textoObjeto){
        Debug.Log("activar cartel+"+ textoObjeto);



        anim.SetBool("Cartel", true);
        texto = textoObjeto;
    }

    public void ActivaTexto(){
        Debug.Log(texto);
        Debug.Log(colaDialogos);
        colaDialogos.Clear();
        foreach (string textoGuardar in texto.arrayTextos){
            colaDialogos.Enqueue(textoGuardar);
        }
        SiguienteFrase();
    }

    public void SiguienteFrase()
    {
        if (colaDialogos.Count == 0)
        {
            CierraCartel();
            return;
        }

        string fraseActual = colaDialogos.Dequeue();
        textoPantalla.text = fraseActual;

        StartCoroutine(MostrarCarteres(fraseActual));

    }

    IEnumerator MostrarCarteres(string textoAMostrar)
    {
        textoPantalla.text = "";
        foreach (char caracter in textoAMostrar.ToCharArray())
        {
        textoPantalla.text += caracter;
        yield return new WaitForSeconds(0.02f);
        }

    }

    void CierraCartel(){
        anim.SetBool("Cartel", false);
    }

}
