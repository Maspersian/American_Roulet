using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SlotSetting : MonoBehaviour,IPointerClickHandler
{
    public List<int> values = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Right)
        {
            Debug.Log("haaai");
            for (int i = 0; i < values.Count; i++)
            {
                Debug.Log(values[i]);
            }

        }
    }
}
