using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CoinSelection : MonoBehaviour, IPointerClickHandler
{
    public List<GameObject> coin = new List<GameObject>();
    public List<GameObject> coinSelection = new List<GameObject>();
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
        for (int i = 0; i < coin.Count; i++)
        {
            if (eventData.pointerClick == coin[i])
            {
                coinSelection[i].SetActive(true);
            }
            else
            {
                coinSelection[i].SetActive(false);
            }
        }
      
    }
}
