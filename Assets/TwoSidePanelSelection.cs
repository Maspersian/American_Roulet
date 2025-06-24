using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class TwoSidePanelSelection : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
    public List<GameObject> Panel2center = new List<GameObject>();
    public List<GameObject> Center2No = new List<GameObject>();

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
        //-----------------------------First Line--------------------------------


        for (int i = 0; i < Center2No.Count; i++)
        {
            if (eventData.pointerEnter == Center2No[i]) // Check if hovered object matches a button
            {
                Debug.Log("Hovered over button index: " + i);

                Panel2center[i].SetActive(true);
                Panel2center[i + 1].SetActive(true);
            }
            if (eventData.pointerEnter == null)
            {
                for(i= 0; i < Panel2center.Count; ++i)
                {
                    Panel2center[i].SetActive(false);
                }
            }
        }
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        //-----------------------------First Line--------------------------------


        for (int i = 0; i < Center2No.Count; i++)
        {
            if (eventData.pointerEnter == Center2No[i]) // Check if hovered object matches a button
            {
                Debug.Log("Hovered over button index: " + i);

                Panel2center[i].SetActive(false);
                Panel2center[i + 1].SetActive(false);
            }
        }
    }

}



