using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
public class OneTo36 : MonoBehaviour, IPointerEnterHandler ,IPointerExitHandler
{
    public List<GameObject> Panel = new List<GameObject>();
    public List<GameObject> No = new List<GameObject>();
    public GameObject textForRatio;
    public BackValue backValue;
    //public ZeroTo36No ZeroTo36No;
   /* public GameObject panel0;
    public GameObject No0;*/
    
    // Start is called before the first frame update
    void Start()
    {
        //ReduceChipss[0].Chips[0]
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        for (int i = 0; i < Panel.Count; i++)
        {
            Panel[i].SetActive(false);
            textForRatio.SetActive(false);
        }
        for (int i = 0; i < No.Count; i++)
        {
            if (eventData.pointerEnter == No[i]) // Check if the hovered object matches this button
            {
                Panel[i].SetActive(true);
                textForRatio.SetActive(true);
                break; // Exit the loop once the correct panel is enabled
            }
        }

    }
    public void OnPointerExit(PointerEventData eventData)
    {
        textForRatio.SetActive(false );
        for (int i = 0;i < Panel.Count; i++)
        {
            Panel[i].SetActive(false);
        }
        
    }
    



}
