using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TwotoOneBackValue : MonoBehaviour ,IPointerClickHandler,IPointerEnterHandler
{
    public ReduceChips reduceChips;

    //public List<GameObject> no = new List<GameObject>();
    // public bool sss=false;
    //public int i = 0;
    //public ZeroTo36No ZeroTo36No;
    public TwoToOne twoToOne;
    public FirstTwoToOne firstTwoToOne;
    AudioManagerr audioManager;

    // Start is called before the first frame update
    void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManagerr>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  
    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            if (twoToOne.maxBettingValue <= 50000)
            {
                reduceChips.Chips.Add(twoToOne.current);

            }
        }
        if (eventData.button == PointerEventData.InputButton.Right)
        {

            if (reduceChips.Chips.Count > 0) // Ensure the list is not empty
            {
                int lastIndex = reduceChips.Chips.Count - 1;
                int removedValue = reduceChips.Chips[lastIndex]; // Store the removed value

                reduceChips.Chips.RemoveAt(lastIndex);

                // Find the correct index in ZeroTo36No and update UI
                for (int i = twoToOne.twoToOneStore; i < twoToOne.upgradeCurrentPoint.Count; i++)
                {
                    if (twoToOne.upgradeCurrentPoint[i] >= removedValue)
                    {
                        twoToOne.upgradeCurrentPoint[twoToOne.twoToOneStore] -= removedValue;
                        twoToOne.transferValue2to1 -= removedValue;
                        audioManager.SoundPlayingg(audioManager.BettingChips);
                        BettingCoin.totalBalance += removedValue;
                        twoToOne.text1[twoToOne.twoToOneStore].text = twoToOne.upgradeCurrentPoint[twoToOne.twoToOneStore].ToString();

                        // If value becomes zero, disable the chip UI
                        if (twoToOne.upgradeCurrentPoint[twoToOne.twoToOneStore] <= 0)
                        {
                            twoToOne.twoToOneImage[twoToOne.twoToOneStore].SetActive(false);
                        }
                        break; // Stop after updating the first matching value
                    }
                }
            }
        }
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (eventData.pointerEnter.CompareTag("FirstTwoToOne"))
        {
            twoToOne.twoToOneStore = 0;
        }
        if (eventData.pointerEnter.CompareTag("SecondTwoToOne"))
        {
            twoToOne.twoToOneStore = 1;
        }
        if (eventData.pointerEnter.CompareTag("ThreeTwoToOne"))
        {
            twoToOne.twoToOneStore = 2;
        }
    }
}
