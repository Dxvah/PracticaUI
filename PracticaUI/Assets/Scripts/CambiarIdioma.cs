using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CambiarIdioma : MonoBehaviour
{
   public List<string> listaIdiomas;
   public Button[] botonesIdioma;
   public Text[] textosBotonesIdioma;
   

   void Start()
   {
        for (int i = 0; i < botonesIdioma.Length; i++)
        {
            int index = i;
            if (index < listaIdiomas.Count)
            {
                 botonesIdioma[i].onClick.AddListener(() => ActualizarIdioma(listaIdiomas[index]));
             }
        }
   }

   public void ActualizarIdioma(string nuevoIdioma)
   {
        
        for (int i = 0; i < botonesIdioma.Length; i++)
        {
            textosBotonesIdioma[i].text = nuevoIdioma;
        }
   }
}
