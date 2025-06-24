using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Chips : MonoBehaviour
{
    public GameObject chips1;
    public GameObject button;
    public TextMeshProUGUI text1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Button2()
    {

        Instantiate(chips1,button.transform.position, transform.rotation);
        Instantiate(text1, chips1.transform.position, transform.rotation);
       //chips1.transform.position = button.transform.position;
    }
}
