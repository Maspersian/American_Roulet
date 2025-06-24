using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonPanelHandler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject panel1;  // First panel
    public GameObject panel2;  // Second panel
    public GameObject textPanel;

    public void OnPointerEnter(PointerEventData eventData)
    {
        panel1.SetActive(true);
        panel2.SetActive(true);
        textPanel.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        panel1.SetActive(false);
        panel2.SetActive(false);
        textPanel.SetActive(false);
    }
}
