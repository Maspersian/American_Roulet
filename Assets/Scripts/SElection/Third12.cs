using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Third12 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public List<GameObject> Panels12Third = new List<GameObject>();
    public GameObject third12;
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
        if (third12.CompareTag("Third12"))
        {

            for (int i = 0; i < Panels12Third.Count; i++)
            {
                Panels12Third[i].SetActive(true);
                ratioOfGame.SetActive(true);
            }

        }

    }
    public void OnPointerExit(PointerEventData eventData)
    {
        if (third12.CompareTag("Third12"))
        {
            for (int i = 0; i < Panels12Third.Count; i++)
            {
                Panels12Third[i].SetActive(false);
                ratioOfGame.SetActive(false);
            }
        }
    }
}
