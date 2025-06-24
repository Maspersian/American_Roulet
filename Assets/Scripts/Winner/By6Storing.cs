using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class By6Storing : MonoBehaviour, IPointerEnterHandler
{
    public int currentStoring;
    public DoubleColumn DoubleColumn;
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
        DoubleColumn.storeBy6 = currentStoring;
    }
}
