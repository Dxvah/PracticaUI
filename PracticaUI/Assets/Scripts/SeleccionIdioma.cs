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
    public int numeroIdioma = 4;
    
   
    void Start()
    {
        List<Locale> listaIdiomas = LocalizationSettings.AvailableLocales.Locales;
    }

    
    void Update()
    {
        for (int i = 0; i < numeroIdioma; i++)
        {
            
        }
       
    }
}
