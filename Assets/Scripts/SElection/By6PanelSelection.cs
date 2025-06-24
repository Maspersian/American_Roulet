using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class By6PanelSelection : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject panel1;  // First panel
    public GameObject panel2;  // Second panel
    public GameObject panel3;
    public GameObject panel4;
    public GameObject panel5;
    public GameObject panel6;
    public GameObject textRatio;

    public void OnPointerEnter(PointerEventData eventData)
    {
        panel1.SetActive(true);
        panel2.SetActive(true);
        panel3.SetActive(true);
        panel4.SetActive(true);
        panel5.SetActive(true);
        panel6.SetActive(true);
        textRatio.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(false);
        panel4.SetActive(false);
        panel5.SetActive(false);
        panel6.SetActive(false);
        textRatio.SetActive(false);
    }
}
