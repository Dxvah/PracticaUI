using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MenuOpciones : MonoBehaviour
{
    public Canvas canvasPrincipal;
    public Canvas canvasOpciones;
    public AudioSource clickAudio;
    public AudioClip soundClip;
    bool suenaclick = false;
    bool check = false;
    void Start()
    {
       
       suenaclick = false;
       check = false;
    }
    public void MostrarCanvasOpciones()
    {
        canvasPrincipal.gameObject.SetActive(false);
        canvasOpciones.gameObject.SetActive(true);
    }
    public void MostrarCanvasPrincipal()
    {
        
        canvasOpciones.gameObject.SetActive(false);
        canvasPrincipal.gameObject.SetActive(true);
    }
    public void ReproducirSonido()
    {
        if (clickAudio != null && soundClip != null)
        {

                clickAudio.clip = soundClip;
                clickAudio.Play();
                suenaclick = true;
        }
    }
    public void ToggleCambio()
    {
        if (check == true) 
        {
            MostrarCanvasPrincipal();
        }
        else
        {
            MostrarCanvasOpciones();
        }
    }
}
