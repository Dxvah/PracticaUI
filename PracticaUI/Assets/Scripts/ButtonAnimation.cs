using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonAnimation : MonoBehaviour
{
    private Vector3 originalPosition;

    public Button[] buttons;

    void Start()
    {
        originalPosition = buttons[0].transform.position;
    }

    public void OnPointerEnter(int buttonIndex)
    {
        
        LeanTween.scale(buttons[buttonIndex].gameObject, Vector3.one * 1.1f, 0.1f).setEase(LeanTweenType.easeOutQuad);
    }

    public void OnPointerExit(int buttonIndex)
    {
        
        LeanTween.scale(buttons[buttonIndex].gameObject, Vector3.one, 0.1f).setEase(LeanTweenType.easeOutQuad);
    }
}
