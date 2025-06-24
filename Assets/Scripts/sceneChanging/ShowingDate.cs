using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShowingDate : MonoBehaviour
{
    public TextMeshProUGUI fromDate;
    public TextMeshProUGUI toDate;

    void Start()
    {
        string currentDate = System.DateTime.Now.ToString("dd/MM/yyyy");
        fromDate.text = currentDate;
        toDate.text = currentDate;
    }
}

   

    

