using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class By3Panel : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject by3panel1;  // First panel
    public GameObject by3panel2;  // Second panel
    public GameObject by3panel3;
    public GameObject by3textPanel;

    public void OnPointerEnter(PointerEventData eventData)
    {
        by3panel1.SetActive(true);
        by3panel2.SetActive(true);
        by3panel3.SetActive(true);
        by3textPanel.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        by3panel1.SetActive(false);
        by3panel2.SetActive(false);
        by3panel3.SetActive(false);
        by3textPanel.SetActive(false);
    }
}
