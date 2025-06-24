using System.Collections;
using System.Collections.Generic;
//using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.EventSystems;

public class OddSelection : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public List<GameObject> PanelsOdd = new List<GameObject>();
    public GameObject oddNo;
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
        if (oddNo.CompareTag("Odd"))
        {

            for (int i = 0; i < PanelsOdd.Count; i++)
            {
                PanelsOdd[i].SetActive(true);
                ratioOfGame.SetActive(true);
            }

        }
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        if (oddNo.CompareTag("Odd"))
        {
            for (int i = 0; i < PanelsOdd.Count; i++)
            {
                PanelsOdd[i].SetActive(false);
                ratioOfGame.SetActive(false);
            }
        }
    }
}
