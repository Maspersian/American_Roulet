using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class ForsomeSelection : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
    public List<GameObject> Panel = new List<GameObject>();
    public List<GameObject> No = new List<GameObject>();
    public GameObject ratioDisplay;
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
        // Disable all panels before enabling the required ones
        foreach (GameObject panel in Panel)
        {
            panel.SetActive(false);
            ratioDisplay.SetActive(false);
        }

        // Find the hovered button
        for (int i = 0; i < No.Count; i++)
        {
            if (eventData.pointerEnter == No[i]) // Check if hovered object matches a button
            {
                //Debug.Log("Hovered over button index: " + i);

                int startIndex = i * 4; // Each button controls 4 panels
                for (int j = 0; j < 4; j++)
                {
                    if (startIndex + j < Panel.Count) // Prevent out-of-range error
                    {
                        Panel[startIndex + j].SetActive(true);
                        ratioDisplay.SetActive(true);
                    }
                }
                break; // Stop checking once the correct panels are found
            }
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Disable all panels when mouse exits
        foreach (GameObject panel in Panel)
        {
            panel.SetActive(false);
            ratioDisplay.SetActive(false);

        }
        //Debug.Log("Mouse exited.");
    }

}
