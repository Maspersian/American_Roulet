using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FourSideStore : MonoBehaviour, IPointerEnterHandler
{
    public CenterPoint CenterPoint;
    public int CurrentStoring;
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
        CenterPoint.centerPointStore = CurrentStoring;
    }
}
