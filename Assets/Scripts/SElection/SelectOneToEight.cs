using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectOneToEight : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public List<GameObject> Panels1To18 = new List<GameObject>();
    public GameObject oneToEighteen;
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
        if (oneToEighteen.CompareTag("1to18"))
        {

            for (int i = 0; i < Panels1To18.Count; i++)
            {
                Panels1To18[i].SetActive(true);
                ratioOfGame.SetActive(true);
            }

        }

    }
    public void OnPointerExit(PointerEventData eventData)
    {
        if (oneToEighteen.CompareTag("1to18"))
        {
            for (int i = 0; i < Panels1To18.Count; i++)
            {
                Panels1To18[i].SetActive(false);
                ratioOfGame.SetActive(false);
            }
        }
    }
}
