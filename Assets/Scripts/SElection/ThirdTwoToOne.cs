using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class ThirdTwoToOne : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public List<GameObject> panel3 = new List<GameObject>();
    public GameObject twoToOne;
    public GameObject ratioOfGame;

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
        if (twoToOne.CompareTag("ThreeTwoToOne"))
        {
            for (int i = 0; i < panel3.Count; i++)
            {
                panel3[i].SetActive(true);
                ratioOfGame.SetActive(true);
            }

            Debug.Log("Mouse is over the button! Panel activated.");
        }

    }
    public void OnPointerExit(PointerEventData eventData)
    {
        if (twoToOne.CompareTag("ThreeTwoToOne"))
        {

            for (int i = 0; i < panel3.Count; i++)
            {
                panel3[i].SetActive(false);
                ratioOfGame.SetActive(false);
            }
            Debug.Log("Left MOUSE BUTTON");
        }
    }

}