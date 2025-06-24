using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Winnerstampb : MonoBehaviour
{
    public Timee Timee;
    public List<GameObject> stamb = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StambEnable()
    {
        for (int i =Timee.winnerNum ; i < stamb.Count; i++)
        {
            stamb[Timee.winnerNum].SetActive(true);
        }
    }
    public void StambDesable()
    {
        for (int i =0; i < stamb.Count; i++)
        {
            stamb[i].SetActive(false);
        }
    }
}
