using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Scenes: MonoBehaviour

{
  public GameObject logo;
  public GameObject texto;
  public int mainmenu;
   void Start()
    {
        LeanTween.moveY(texto.gameObject, 0.0f, 1.0f).setEase(LeanTweenType.easeOutBounce).setOnComplete(LoadSiguienteEscena);
        LeanTween.moveY(logo.gameObject, 0.0f, 2.0f).setEase(LeanTweenType.easeInBounce);
    }

   public void LoadSiguienteEscena()
   {
        
        SceneManager.LoadScene(mainmenu);
   }

}
