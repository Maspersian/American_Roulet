using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DobleSelection : MonoBehaviour ,IPointerEnterHandler, IPointerExitHandler
{
    public List<GameObject> Panel = new List<GameObject>();
    public List<GameObject> No = new List<GameObject>();
    private GameObject hoveredObject;  // Track the hovered object

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
        for (int i = 0; i < No.Count; i++)
        {
           hoveredObject = eventData.pointerEnter; // Store the current hovered object
            if (eventData.pointerEnter == No[i]) // Check if the hovered object matches this button
            {
                for (int j = i * 3; i * 3 == j; j++)
                {
                   // Debug.Log(j + "  j   " + "   i   "+i);
                    if (i == 0)
                    {
                     Panel[0].SetActive(true);
                     Panel[1].SetActive(true);
                     Panel[2].SetActive(true);
                     Panel[3].SetActive(true);
                     Panel[4].SetActive(true);
                    }
                    else
                    {
                        Panel[j].SetActive(true);
                        Panel[j + 1].SetActive(true);
                        Panel[j + 4].SetActive(true);
                        Panel[j + 3].SetActive(true);
                        Panel[j + 2].SetActive(true);
                        Panel[j - 1].SetActive(true);
                    }
                   
                }

            }

        }


    }
    public void OnPointerExit(PointerEventData eventData)
    {
        if (hoveredObject == null) return;  // Check if there was a hovered object
        for (int i = 0; i < No.Count; i++)
        {
            if (hoveredObject == No[i])
            {
                if (i == 0)
                {
                    Panel[0].SetActive(false);
                    Panel[1].SetActive(false);
                    Panel[2].SetActive(false);
                    Panel[3].SetActive(false);
                    Panel[4].SetActive(false);
                }
                else
                {
                    for (int j = i * 3; j == i * 3 ; j++)
                    {
                        Panel[j].SetActive(false);
                        Panel[j + 1].SetActive(false);
                        Panel[j + 4].SetActive(false);
                        Panel[j + 3].SetActive(false);
                        Panel[j + 2].SetActive(false);
                        Panel[j - 1].SetActive(false);
                    }
                }
               
            }
        }
      //  hoveredObject = null;  // Reset after exit
    }
}
