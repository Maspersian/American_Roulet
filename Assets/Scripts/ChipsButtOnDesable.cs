using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChipsButtOnDesable : MonoBehaviour
{
   // public List<Button> buttonDesable = new List<Button>();
    public List<GameObject> buttonObjects = new List<GameObject>();

    //public GameObject buttonn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    

   /* public void DisableButton()
    {
        for (int i = 0; i < buttonObjects.Count; i++)
        {
            Button btn = buttonObjects[i].GetComponent<Button>();

            if (btn != null)
            {
                btn.enabled = false;  // Completely disables the Button component
                Debug.Log("Button Component Disabled");
            }
        }
    }

    public void ActiveChipsButton()
    {
        for (int i = 0; i < buttonObjects.Count; i++)
        {
            Button btn = buttonObjects[i].GetComponent<Button>();

            if (btn != null)
            {
                btn.enabled = true;  // Enables the Button component again
                Debug.Log("Button Component Enabled");
            }
        }
    }*/
}
