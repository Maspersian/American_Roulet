using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class By3Panelselection : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject panel1;  // First panel
    public GameObject panel2;  // Second panel
    public GameObject panel3;
    public GameObject textRatio;

    public void OnPointerEnter(PointerEventData eventData)
    {
        panel1.SetActive(true);
        panel2.SetActive(true);
        panel3.SetActive(true);
        textRatio.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(false);
        textRatio.SetActive(false);
    }
}
