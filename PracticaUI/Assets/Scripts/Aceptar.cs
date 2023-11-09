using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Aceptar : MonoBehaviour
{
    public Canvas canvasPrincipal;
    public Canvas canvasIdioma;
    public void MostrarCanvasPrincipal()
    {
        canvasPrincipal.gameObject.SetActive(true);
        canvasIdioma.gameObject.SetActive(true);

    }
    public void ToggleCambio(bool activado)
    {
        if (activado == true)
        {
            MostrarCanvasPrincipal();
            canvasIdioma.gameObject.SetActive(false);

        }
        else
        {
            canvasIdioma.gameObject.SetActive(true);

        }
    }

}
