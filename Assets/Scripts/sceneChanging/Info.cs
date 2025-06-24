using System.Collections;
using System.Collections.Generic;
using UI.Dates;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Info : MonoBehaviour
{
    public AudioManagerr audioManager;

    public bool isCheckingMute=true;
    public bool isInfoPanelOn=false;
    public GameObject panelRules;
    public GameObject panelResult;
    public GameObject panelGameHistory;
    public GameObject panelReport;
    public GameObject panelInfo;
    public GameObject wheel;
    public GameObject wheelStand;
    public GameObject closeImage;
    public GameObject datePicker1;
    public GameObject datePicker2;
    public GameObject coinHighLights;
    public Timee Timee;

    public DatePicker DatePicker;
    public DatePicker datePickerTwo;
    public DatePicker datePickerThree;


    private GameObject currentDatePicker;
    private Vector3 datePickerOriginalPosition;
    private Transform datePickerOriginalParent;
    //public List<GameObject> winnerNumList = new List<GameObject>();
    public void ChenGingInfoPanel()
    {
       panelInfo.SetActive(true);
        coinHighLights.SetActive(false);
        isInfoPanelOn = true;
        wheel.SetActive(false);
        wheelStand.SetActive(false);
      
        for (int i = 0; Timee.winnerscreen.Count > i; i++)
        {
            Debug.Log(Timee.winnerscreen[i]+"Timee is working the inside of the game");
            Timee.winnerscreen[i].SetActive(false);
            Timee.winningNumList[i].SetActive(false);

        }


    }
    public void MuteButton()
    {
        if (isCheckingMute == true)
        {
            //.main.GetComponent<AudioListener>().enabled = false
            AudioListener.pause=true;
            closeImage.SetActive(true);
            isCheckingMute = false;
            audioManager.isMuted = true; // Update mute flag
        }
        else
        {
           // Camera.main.GetComponent<AudioListener>().enabled = true;
           AudioListener.pause = false;
            closeImage.SetActive(false);
            isCheckingMute = true;
            audioManager.isMuted = false; // Update mute flag
        }
    }
    public void CloseImage()
    {
        
        
        StartCoroutine(DatePickerOff());
        DatePicker.Hide();
        datePickerTwo.Hide();
        datePickerThree.Hide();
    }
    public void RulesPanelOn()
    {
        panelRules.SetActive(true);
        panelResult.SetActive(false);
        panelGameHistory.SetActive(false);
        panelReport.SetActive(false);
        /* datePicker1.SetActive(false);
         datePicker2.SetActive(false);*/
        DatePicker.Hide();
        datePickerTwo.Hide();
        datePickerThree.Hide();

    }
    public void ResultPanelOn()
    {
        panelRules.SetActive(false);
        panelResult.SetActive(true);
        panelGameHistory.SetActive(false);
        panelReport.SetActive(false);
        /*datePicker1.SetActive(false);
        datePicker2.SetActive(false);*/
        DatePicker.Hide();
        datePickerTwo.Hide();
    }
    public void HistoryPanelOn()
    {
        panelRules.SetActive(false);
        panelResult.SetActive(false);
        panelGameHistory.SetActive(true);
        panelReport.SetActive(false);
        /* datePicker1.SetActive(false);
         datePicker2.SetActive(false);*/
        DatePicker.Hide();
        datePickerTwo.Hide();
        datePickerThree.Hide();

    }
    public void ReportPanelOn()
    {
        panelRules.SetActive(false);
        panelResult.SetActive(false);
        panelGameHistory.SetActive(false);
        panelReport.SetActive(true);
        datePickerThree.Hide();

    }
    public IEnumerator DatePickerOff()
    {
        yield return new WaitForSeconds(0.3f);
        panelInfo.SetActive(false);
        coinHighLights.SetActive(true);
        wheel.SetActive(true);
        wheelStand.SetActive(true);
    }
}
