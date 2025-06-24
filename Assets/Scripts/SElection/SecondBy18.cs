using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SecondBy18 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public List<GameObject> Panels19To36 = new List<GameObject>();
    public GameObject nineTo36;
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
        if (nineTo36.CompareTag("19to36"))
        {

            for (int i = 0; i < Panels19To36.Count; i++)
            {
                Panels19To36[i].SetActive(true);
                ratioOfGame.SetActive(true);
            }

        }

    }
    public void OnPointerExit(PointerEventData eventData)
    {
        if (nineTo36.CompareTag("19to36"))
        {
            for (int i = 0; i < Panels19To36.Count; i++)
            {
                Panels19To36[i].SetActive(false);
                ratioOfGame.SetActive(false);
            }
        }
    }
}
