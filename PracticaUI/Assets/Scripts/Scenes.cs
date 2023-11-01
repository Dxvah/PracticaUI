using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Scenes: MonoBehaviour

{
  public GameObject logo;
  public GameObject texto;
  public GameObject canvaInicio;
  void Start()
  {
        LeanTween.moveY(logo.GetComponent<RectTransform>(), 0, 1.5f).setDelay(2.5f).setEase(LeanTweenType.easeOutQuart);
        LeanTween.moveY(texto.gameObject, 0, 1.5f).setDelay(1.5f).setEase(LeanTweenType.easeInBack).setOnComplete(BajarAlpha);
        
  }
  private void BajarAlpha()
  {
      LeanTween.alpha(canvaInicio.GetComponent<RectTransform>(), 0f, 1f).setDelay(1f);
      canvaInicio.GetComponent<CanvasGroup>().blocksRaycasts = false;
  }
}
