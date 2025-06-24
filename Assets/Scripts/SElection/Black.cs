using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class Black : MonoBehaviour,IPointerEnterHandler, IPointerExitHandler
{
    public List<GameObject> PanelBlack = new List<GameObject>();
    public GameObject blackNo;
    public GameObject twoIsToOne;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (blackNo.CompareTag("Black"))
        {

            for (int i = 0; i < PanelBlack.Count; i++)
            {
                PanelBlack[i].SetActive(true);
                twoIsToOne.SetActive(true);
            }

        }
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        if (blackNo.CompareTag("Black"))
        {
            for (int i = 0; i < PanelBlack.Count; i++)
            {
                PanelBlack[i].SetActive(false);
                twoIsToOne.SetActive(false);
            }
        }
    }
}
