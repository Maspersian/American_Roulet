using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Second12 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public List<GameObject> Panels12 = new List<GameObject>();
    public GameObject second12;
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
        if (second12.CompareTag("Second12"))
        {

            for (int i = 0; i < Panels12.Count; i++)
            {
                Panels12[i].SetActive(true);
                ratioOfGame.SetActive(true);
            }

        }

    }
    public void OnPointerExit(PointerEventData eventData)
    {
        if (second12.CompareTag("Second12"))
        {
            for (int i = 0; i < Panels12.Count; i++)
            {
                Panels12[i].SetActive(false);
                ratioOfGame.SetActive(false);
            }
        }
    }
}
