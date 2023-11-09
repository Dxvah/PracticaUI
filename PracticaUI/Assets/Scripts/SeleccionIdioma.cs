using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

public class SeleccionIdioma : MonoBehaviour
{
    public Button left;
    public Button right;
    int idiomaActual = 0;
    List<Locale> listaIdiomas;
    bool izq;



    void Start()
    {
        listaIdiomas = LocalizationSettings.AvailableLocales.Locales;
    }

    
    public void CambiarIdiomaIzquierda()
    {  
            LocalizationSettings.SelectedLocale = listaIdiomas[idiomaActual--];  
    }
    public void CambiarIdiomaDerecha()
    {
        LocalizationSettings.SelectedLocale = listaIdiomas[idiomaActual++];
    }
}
