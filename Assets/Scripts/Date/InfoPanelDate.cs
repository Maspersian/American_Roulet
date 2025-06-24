using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InfoPanelDate : MonoBehaviour
{
    public TextMeshProUGUI infoFromDate;
    public TextMeshProUGUI infoTodate;
    public TextMeshProUGUI resultDate;
    // Start is called before the first frame update
    void Start()
    {
        string date = System.DateTime.UtcNow.ToLocalTime().ToString("dd-MM-yyyy"); 
        infoFromDate.text = date;
        infoTodate.text = date;
        resultDate.text = date;
    }

}
