using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Red : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
    public List<GameObject> PanelRed = new List<GameObject>();
    public GameObject redNo;
    public GameObject redRatio;
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
        if (redNo.CompareTag("Red"))
        {

            for (int i = 0; i < PanelRed.Count; i++)
            {
                PanelRed[i].SetActive(true);
                redRatio.SetActive(true);
            }

        }
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        if (redNo.CompareTag("Red"))
        {
            for (int i = 0; i < PanelRed.Count; i++)
            {
                PanelRed[i].SetActive(false);
                redRatio.SetActive(false);
            }
        }
    }
}
