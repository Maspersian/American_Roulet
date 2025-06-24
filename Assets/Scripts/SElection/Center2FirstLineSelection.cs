using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Center2FirstLineSelection : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    //---------------First Line------------------------

    public List<GameObject> PanelCenter2First = new List<GameObject>();
    public List<GameObject> Center2First = new List<GameObject>();

    //---------------Second Line------------------------

    public List<GameObject> PanelCenter2Second = new List<GameObject>();
    public List<GameObject> Center2Second = new List<GameObject>();
    bool lastNum=true;

    //---------------Second Line------------------------


    public List<GameObject> PanelCenter2Third = new List<GameObject>();
    public List<GameObject> Center2Third = new List<GameObject>();
    //bool lastNum = true;

    //---------------First Down Line------------------------

    public List<GameObject> PanelCenter2FirstDown = new List<GameObject>();
    public List<GameObject> Center2FirstDown = new List<GameObject>();

    //---------------Second Down Line------------------------


    public List<GameObject> PanelCenter2SecondDown = new List<GameObject>();
    public List<GameObject> Center2SecondDown = new List<GameObject>();

    public GameObject textForRatio1;
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
        //-----------------------------First Line--------------------------------

        for (int i = 0; i < PanelCenter2First.Count; i++)
        {
            PanelCenter2First[i].SetActive(false);
            //textForRatio.SetActive(false);
        }
        for (int i = 0; i < Center2First.Count; i++)
        {
            if (eventData.pointerEnter == Center2First[i]) // Check if hovered object matches a button
            {
                Debug.Log("Hovered over button index: " + i);
                
                
                    if (i < PanelCenter2First.Count)
                    {
                        PanelCenter2First[i].SetActive(true);
                    textForRatio1.SetActive(true);

                }
                if (i + 1 < PanelCenter2First.Count) // Prevent out-of-range error
                    {
                        PanelCenter2First[i + 1].SetActive(true);
                    textForRatio1.SetActive(true);

                }

                break; // Stop checking once the correct panel is found
                

                // Enable the respective panels (i and i+1)
                

                
            }
        }

        //-----------------------------Second Line--------------------------------

        for (int i = 0; i < PanelCenter2Second.Count; i++)
        {
            PanelCenter2Second[i].SetActive(false);
           // textForRatio.SetActive(false);
        }
        
        for (int i = 0; i < Center2Second.Count; i++)
        {
            if (eventData.pointerEnter == Center2Second[i]) // Check if hovered object matches a button
            {
               // Debug.Log("Hovered over button index: " + i);
                if (i == 12 && lastNum == true)
                {
                    Debug.Log(i);
                    PanelCenter2Second[13].SetActive(true);
                    PanelCenter2Second[1].SetActive(true);
                    textForRatio1.SetActive(true);

                    //lastNum = false;
                    break;
                }
                
                    // Enable the respective panels (i and i+1)
                    if (i < PanelCenter2Second.Count)
                    {
                        PanelCenter2Second[i].SetActive(true);
                    textForRatio1.SetActive(true);

                }
                if (i + 1 < PanelCenter2Second.Count) // Prevent out-of-range error
                    {
                        PanelCenter2Second[i + 1].SetActive(true);
                    textForRatio1.SetActive(true);

                }

                break; // Stop checking once the correct panel is found
                
            }
        }

        //-----------------------------Third Line--------------------------------

        for (int i = 0; i < PanelCenter2Third.Count; i++)
        {
            PanelCenter2Third[i].SetActive(false);
            textForRatio1.SetActive(false);
        }

        for (int i = 0; i < Center2Third.Count; i++)
        {
            if (eventData.pointerEnter == Center2Third[i]) // Check if hovered object matches a button
            {
                //Debug.Log("Hovered over button index: " + i);
                

                // Enable the respective panels (i and i+1)
                if (i < PanelCenter2Third.Count)
                {
                    PanelCenter2Third[i].SetActive(true);
                    textForRatio1.SetActive(true);

                }
                if (i + 1 < PanelCenter2Third.Count) // Prevent out-of-range error
                {
                    PanelCenter2Third[i + 1].SetActive(true);
                    textForRatio1.SetActive(true);

                }

                break; // Stop checking once the correct panel is found

            }
        }

        //-----------------------------First Down Line--------------------------------

        for (int i = 0; i < PanelCenter2FirstDown.Count; i++)
        {
            PanelCenter2FirstDown[i].SetActive(false);
            textForRatio1.SetActive(false);
        }

        for (int i = 0; i < Center2FirstDown.Count; i++)
        {
            if (eventData.pointerEnter == Center2FirstDown[i]) // Check if hovered object matches a button
            {
                if (i == 0)
                {
                    PanelCenter2FirstDown[i].SetActive(true);
                    PanelCenter2FirstDown[i + 1].SetActive(true);
                    textForRatio1.SetActive(true);

                    break;
                }
                //Debug.Log("Hovered over button index: " + i);


                // Enable the respective panels (i and i+1)
                if (i < PanelCenter2FirstDown.Count)
                {
                    PanelCenter2FirstDown[i*2].SetActive(true);
                    PanelCenter2FirstDown[i*2+1].SetActive(true);
                    textForRatio1.SetActive(true);

                }


                break; // Stop checking once the correct panel is found

            }
        }

        //-----------------------------Second Down Line--------------------------------

        for (int i = 0; i < PanelCenter2SecondDown.Count; i++)
        {
            PanelCenter2SecondDown[i].SetActive(false);
            //textForRatio.SetActive(false);
        }

        for (int i = 0; i < Center2SecondDown.Count; i++)
        {
            if (eventData.pointerEnter == Center2SecondDown[i]) // Check if hovered object matches a button
            {
                if (i == 0)
                {
                    PanelCenter2SecondDown[i].SetActive(true);
                    PanelCenter2SecondDown[i + 1].SetActive(true);
                    textForRatio1.SetActive(true);
                    break;
                }
               // Debug.Log("Hovered over button index: " + i);


                // Enable the respective panels (i and i+1)
                if (i < PanelCenter2SecondDown.Count)
                {
                    PanelCenter2SecondDown[i * 2].SetActive(true);
                    PanelCenter2SecondDown[i * 2 + 1].SetActive(true);
                    textForRatio1.SetActive(true);
                }


                
                break; // Stop checking once the correct panel is found

            }
        }

    }
    public void OnPointerExit(PointerEventData eventData)
    {
        //textForRatio.SetActive(false);
        // Disable all panels when mouse exits
        foreach (GameObject panel in PanelCenter2First)
        {
            panel.SetActive(false);
        }
        foreach (GameObject panel in PanelCenter2Second)
        {
            panel.SetActive(false);
        }
        foreach (GameObject panel in PanelCenter2Third)
        {
            panel.SetActive(false);
        }
        foreach (GameObject panel in PanelCenter2FirstDown)
        {
            panel.SetActive(false);
        }
        foreach (GameObject panel in PanelCenter2SecondDown)
        {
            panel.SetActive(false);
        }

    }
}
