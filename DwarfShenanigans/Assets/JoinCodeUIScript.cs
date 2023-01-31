using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class JoinCodeUIScript : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject clipboardPrompt;

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        GUIUtility.systemCopyBuffer = GetComponent<TMP_Text>().text;
        clipboardPrompt.SetActive(true);
        StartCoroutine(FadeOut());
    }

    public void setUICode(string joinCode)
    {
        GetComponent<TMP_Text>().text = joinCode;
        GetComponent<TMP_Text>().gameObject.SetActive(true);
    }

    IEnumerator FadeOut()
    {
        yield return new WaitForSecondsRealtime(2);
        clipboardPrompt.SetActive(false);
    }
    
}
