using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EvenSelection : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
    public List<GameObject> PanelsEven = new List<GameObject>();
    public GameObject evenNo;
    public GameObject ratioOfGame;
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
        if (evenNo.CompareTag("Even"))
        {

            for (int i = 0; i < PanelsEven.Count; i++)
            {
                PanelsEven[i].SetActive(true);
                ratioOfGame.SetActive(true);
            }

        }
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        if (evenNo.CompareTag("Even"))
        {
            for (int i = 0; i < PanelsEven.Count; i++)
            {
                PanelsEven[i].SetActive(false);
                ratioOfGame.SetActive(false);
            }
        }
    }
}
