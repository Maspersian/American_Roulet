using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SecondTwoToOne : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public List<GameObject> panell = new List<GameObject>();
   // public GameObject panel2;
    public GameObject twoToOne2;
    public GameObject ratioOfgame;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (CompareTag("SecondTwoToOne"))
        {
            for (int i = 0; i < panell.Count; i++)
            {
                panell[i].SetActive(true);
                ratioOfgame.SetActive(true);
            }
        }
     
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        for (int i = 0; i < panell.Count; i++)
        {
            panell[i].SetActive(false);
            ratioOfgame.SetActive(false);
        }
       

    }
}

