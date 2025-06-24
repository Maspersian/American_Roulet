using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class By3Column : MonoBehaviour, IPointerEnterHandler
{
    public int currentStoring;
    public SingleColumn SingleColumn;
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
        SingleColumn.storingBy3 = currentStoring;
    }
}
