using System.Collections;
using System.Collections.Generic;
//using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.EventSystems;

public class SingleColmnSelection : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
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
                for(int j = i*3; i*3==j; j++)
                {
                    Panel[j].SetActive(true);
                    Panel[j+1].SetActive(true);
                    Panel[j+2].SetActive(true);

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
                for (int j = i * 3; j < i * 3 + 3; j++)
                {
                    Panel[j].SetActive(false);
                }
            }
        }
        hoveredObject = null;  // Reset after exit
    }
}
