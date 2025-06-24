using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Center4Selection : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public List<GameObject> PanelsCenter4 = new List<GameObject>();
    public List<GameObject> Center41 = new List<GameObject>();
    public GameObject center4;
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
        for (int i = 0; i < PanelsCenter4.Count; i++)
        {

        }

    }
    public void OnPointerExit(PointerEventData eventData)
    {
        if (center4.CompareTag("Third12"))
        {
            for (int i = 0; i < PanelsCenter4.Count; i++)
            {
                PanelsCenter4[i].SetActive(false);
            }
        }
    }
}
