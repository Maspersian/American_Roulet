using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TwoSideStoringValue : MonoBehaviour , IPointerEnterHandler
{
    public int currentStoring;
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
        TwoSide.twoSideStore = currentStoring;
    }
}
