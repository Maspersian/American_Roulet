using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BlackRedStoring : MonoBehaviour, IPointerEnterHandler
{
    public int currentStoring;
    public BlackAndRed BlackAndRed;
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
        BlackAndRed.redAndBlackStore = currentStoring;
    }
}
