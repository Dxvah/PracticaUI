using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ButtonAnimation : MonoBehaviour
{
    public Button play;
    public Button options;
    public Button exit;

    private Vector3 originalScale;

    private void Start()
    {
        originalScale = play.transform.localScale;
    }

    public void OnPointerEnter(int buttonIndex)
    {
        LeanTween.scale(play.gameObject, originalScale * 1.1f, 0.1f).setEase(LeanTweenType.easeOutQuad);
        LeanTween.scale(options.gameObject, originalScale * 1.1f, 0.1f).setEase(LeanTweenType.easeOutQuad);
        LeanTween.scale(exit.gameObject, originalScale * 1.1f, 0.1f).setEase(LeanTweenType.easeOutQuad);
    }

    public void OnPointerExit(int buttonIndex)
    {
        LeanTween.scale(play.gameObject, originalScale, 0.1f).setEase(LeanTweenType.easeOutQuad);
        LeanTween.scale(options.gameObject, originalScale, 0.1f).setEase(LeanTweenType.easeOutQuad);
        LeanTween.scale(exit.gameObject, originalScale, 0.1f).setEase(LeanTweenType.easeOutQuad);
    }
}
