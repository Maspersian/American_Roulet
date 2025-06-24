using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PanelsOn : MonoBehaviour, IPointerEnterHandler , IPointerExitHandler
{
    public List<GameObject> Panel2center = new List<GameObject>();
    public List<GameObject> Center2No = new List<GameObject>();
    public TwoSide TwoSide;
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


        for (int i = 0; i < Center2No.Count; i++)
        {
            if (eventData.pointerEnter == Center2No[i]) // Check if hovered object matches a button
            {
                Debug.Log("Enter");
                Panel2center[i].SetActive(true);
                Panel2center[i+1].SetActive(true);
                //TwoSide.twoSideStore = i;
                break;
            }
        }
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        GameObject currentObject = eventData.pointerCurrentRaycast.gameObject; // Correct way to check
        for (int i = 0; i < Center2No.Count; i++)
        {
            if (currentObject != Center2No[i]) // If the mouse is NOT over the same object
            {
                Debug.Log("Exit: " + Center2No[i].name);
                Panel2center[i].SetActive(false);
                if (i + 1 < Panel2center.Count) // Prevent out-of-bounds
                {
                    Panel2center[i + 1].SetActive(false);
                }
            }
        }
    }
}
