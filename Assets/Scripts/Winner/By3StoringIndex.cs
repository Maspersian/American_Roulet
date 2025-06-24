using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class By3StoringIndex : MonoBehaviour, IPointerEnterHandler
{
        public By3AddBEttingPointt by3AddBEttingPointt;
        public int storeIndex;

        public void OnPointerEnter(PointerEventData eventData)
        {
            by3AddBEttingPointt.By3PointStore = storeIndex;
            Debug.Log("Hovered Image -> By3PointStore: " + storeIndex);
        }
    
}
