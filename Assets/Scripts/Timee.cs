//using Microsoft.Unity.VisualStudio.Editor;
using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UI.Dates;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Timee : MonoBehaviour
{
    public static Timee instance;
    [SerializeField] private UnityEngine.UI.Image uiFill;
    [SerializeField] private TextMeshProUGUI uiText;
    public float timer;
    public float timeDuration = 60;
    public TextMeshProUGUI textVisible;
    public TextMeshProUGUI historyText;

    public List<GameObject> winnerscreen = new List<GameObject>();
    public List<GameObject> slotee = new List<GameObject>();
    public List<GameObject> winningNumList = new List<GameObject>();
    public GameObject panelForButtondeactive;


    //--------Call Another Script------------
    public ZeroTo36No bettingScript;
    public TwoToOne twoToOne;
    public By12 by12;
    public OneToEight by18;
    public EvenandOdd evenandOdd;
    public BlackAndRed blackAndRed;
    public CenterPoint center4Selection;
    public TwoSide TwoSide;
    public DoubleColumn DoubleColumn;
    public SingleColumn SingleColumn;
    public By3AddBEttingPointt by3AddBEttingPointt;

    public OneTo36 OneTo36;
    public Center2FirstLineSelection Center2FirstLineSelection;
    public ForsomeSelection Forsome;
    public Black Black;
    public First12 First12;
    public Second12 Second12;
    public Third12 Third12;
    public EvenSelection EvenSelection;
    public OddSelection OddSelection;
    public SelectOneToEight selectOneToEight;
    public SecondBy18 SecondBy18;
    public Red red;
    public SingleColmnSelection SingleColmnSelection;
    public FirstTwoToOne firstTwoToOne;
    public SecondTwoToOne secondTwoToOne;
    public ThirdTwoToOne thirdTwoToOne;
    public DobleSelection DobleSelection;

    public ReduceChips ReduceChips;

    public DatePicker DatePicker;
    public DatePicker DatePicker1;
    public DatePicker DatePicker2;

    public Winnerstampb Winnerstampb;

    public Info info;

    //---------------------------------------------------------------------------Reduce Values Rest----------------------------------------------------------------------------
    public List<BackValue> backValues = new List<BackValue>();
    public List<FourCenterBackValue> centerPoint = new List<FourCenterBackValue>();
    public List<TwoSideBackVAlye> by2 = new List<TwoSideBackVAlye>();
    public List<By6BackValue> by6backvalues = new List<By6BackValue>();
    public List<By3BackValues> by3backValues = new List<By3BackValues>();
    public List<TwotoOneBackValue> TwoToOnebackValues = new List<TwotoOneBackValue>();
    public List<TwelveByBackValue> by12backValues = new List<TwelveByBackValue>();
    public List<OneBy18BackValue> by18backValues = new List<OneBy18BackValue>();
    public List<OddAndEvenBackValue> oddAndEvenbackValues = new List<OddAndEvenBackValue>();
    public List<BlackAndRedBackValue> BandRbackValues = new List<BlackAndRedBackValue>();
    public List<By3BackValueReducePoint>by3BackValueReducePoints = new List<By3BackValueReducePoint>();



    //----------------------------Ui Buttons----------------------------
    public GameObject repeatButton;
    public GameObject clearButton;
    public GameObject doubleButton;

    //public BackValue BackValue;

    public List<Animator> animators = new List<Animator>();

    public List<GameObject> WheelAnimation = new List<GameObject>();


    public ChipsButtOnDesable ChipsButtOnDesable = new ChipsButtOnDesable();
    public int historyof;

    //--------ZerotoOne------------
    public int playerGet;

    //--------Two2One--------------
    public int playerGetFirstLine2to1;
    public int PlayerGetSecondLine2to1;
    public int PlayerGetThirdLine2to1;

    //------------By3============
    public int by3FirstBn;
    public int by3SecondBn;
    public int by3ThirdBn;
    

    //--------By 12----------------
    public int by12First;
    public int by12Second;
    public int by12Third;

    //--------By 18----------------

    public int by18First;
    public int by18Second;

    //--------Odd Or Even----------------

    public int oddNumber;
    public int evenNumber;

    //--------Black And Red----------------

    public int blackresult;
    public int redresult;

    //--------Center 4 Selection----------------
    public int center4;
    public List<int> numbersStored = new List<int>();
   /* int rows = 12;   
    int columns = 3;*/
    int k = 0;
    

    //--------Center 2 Selection----------------

    public int center2 = 0;
    public int center2SecondLine = 0; 
    public int t = 26;
    public int q = 49;

    //--------Center 2 Selection----------------

    public int center2ThirdLine = 0;

    //--------Center 2 Selection Down----------------

    public int Check1 = 12;
    public int Check2 = 37;
    //public int Check3 = 14;
    public int centerFirstDownLine;
    public int centerLastDownLine;
    //public int centerMidileUpLine;


    //--------SingleColumn----------------
    public int singlecoumnValue;

    //--------DoubleColumn----------------

    public int doublecoumnValue;


    public int totalWinningAmount = 0;
    //--------DisplayTotalWinning Amount And Betting Amount----------------

    public TextMeshProUGUI totalWinningAmountText;
    public TextMeshProUGUI totalBettingAmountText;
    public TextMeshProUGUI toatalPlayingMatch;
    public GameObject noMoreBets;
    public int noOfPlayGame=1;
    public int bettingAmountCalculation=0;
    //public Anim anim;

    //----------------Repeat Button---------------------


    public int isChekingRepeat=0;
    //---------------2Side-------------------------

  public  List<int> repeatValuesss = new List<int>(61);
    public List<int> reduceValueBy2 = new List<int>();
    public int checkValueCheking;
    public bool checkingRepeating=false;

    //---------------4 Side-------------------------

    public List<int> repeatValuesss4Side = new List<int>(61);

    //---------------Black And Red-------------------------

    public List<int> repeatvaluesssBlackAndWight = new List<int>();

    //---------------Even And Odd-------------------------

    public List<int> repeatvaluesssEvenandOdd = new List<int>();

    //---------------By18------------------------

    public List<int> repeatvaluesssBy18 = new List<int>();

    //---------------By12------------------------

    public List<int> repeatvaluesssBy12 = new List<int>();

    //---------------2to1------------------------

    public List<int> repeatvaluesss2to1 = new List<int>();

    //-----------------By3-------------------------

    public List<int> repeatValueBy3 = new List<int>();
    //---------------0 to 37------------------------

    public List<int> repeatvaluesss0to37 = new List<int>();

    //---------------Singlw columns------------------------

    public List<int>repeatvaluesSimgleColumns = new List<int>();

    //---------------Double columns------------------------

    public List<int> repeatvaluesDoubleColumns = new List<int>();


    public bool isSoundPlayOneTime=true;

    //-------------------------------------------------Clear button cheking Null Not with use bool Variables-------------
    public bool clearBy37;
    public bool clearBy2;
    public bool clearBy3;
    public bool clearBy4;
    public bool clearBy18;
    public bool clearBy12;
    public bool clearBy6;
    public bool clear2to1;
    public bool clearBlackAndWight;
    public bool clearEvenandOdd;
    public bool clearBy3By3;
   

    public int firstLineTwoToOne = 0;
    public int secondLineTwoToOne = 0;
    public int thirdLineTwoToOne = 0;
    public int winningPoints;
    public int toatalWinningAmount;
    public int winnerNum;

    private List<int> historyList = new List<int>();  // Store winning history

    private HashSet<int> redNumbers = new HashSet<int> { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
    private HashSet<int> greenNumbers = new HashSet<int> { 0, 37 };

    public TextMeshProUGUI redHistoryText;  // Left column for red numbers
    public TextMeshProUGUI yellowHistoryText; // Right column for yellow numbers
    public TextMeshProUGUI greenHistoryText; // Center column for green numbers

    private List<string> redHistoryList = new List<string>();
    private List<string> yellowHistoryList = new List<string>();
    private List<string> greenHistoryList = new List<string>();


    public GameObject playNow;
    public bool redTrue;
    public bool yellowTrue;

    public Animator animator;
    public Animator animatorpivote;
    public GameObject innerBall;
    public GameObject outerBall;
    public bool isChecking=true;
    public int animCount;
    /* public AnimationClip clip;
     public AnimationClip clip0;*/
    AudioManagerr audioManager;


    public bool gameRunning = false; // Flag to check if the game is running
    
    private void Awake()
    {
        instance = this;
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManagerr>();
        repeatButton.SetActive(false);
        noOfPlayGame = 1;
        toatalPlayingMatch.text =noOfPlayGame.ToString();
        //animatorpivote.Play("FirstLine");


    }
    // Start is called before the first frame update
    void Start()
    {

        audioManager.SoundPlayingg(audioManager.betPlease);
        InitializeHistory();

        /* for(int i = 0; i < bettingScript.ZeroTo36Chips.Count; i++)
         {
             Button button = bettingScript.ZeroTo36Chips[i].GetComponent<Button>();
         }*/
        ResetTimer();
        noMoreBets.SetActive(false);
        //animator = GetComponent<Animator>();
        animator.Play("Wheel 2");
        outerBall.SetActive(false);
        playNow.SetActive(true);
        //DesableAnimation();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameRunning)
        {
            // Countdown the timer
            timer -= Time.deltaTime;
            uiText.text=$"{timeDuration/ 60:00} : {timeDuration % 60:00}";
            uiFill.fillAmount = Mathf.InverseLerp(0,timeDuration,timer);
            ClearBnDesable();
            /*if(timer <=9)
            {
                Debug.Log("Timer is less than 10 seconds");
                DatePickerFunction();
               
            }*/
            if (timer < 7&&timer>3)
            {
                DeactiveNumbersAfterFive();
               // noMoreBets.transform.SetAsLastSibling();
               playNow.SetActive(false);
                noMoreBets.SetActive(true);
                //audioManager.SoundPlayingg(audioManager.noMoreBets);


            }
            // Update the timer UI
            UpdateTimerUI();
           
            // Check if time is up
            if (timer < 1)
            {
                audioManager.SoundPlayingg(audioManager.WheelRotate);
                noMoreBets.SetActive(false );
                timer = 0; // Ensure timer doesn't go negative
        //animator.Play("Pivote");
                gameRunning = false;
                isChecking = true;
                StartCoroutine(ResetGameAfterDelay(10f)); // Delay before resetting the game
            }
        }
        //CallAllBAttingAmount();
    }
    private IEnumerator ResetGameAfterDelay(float delay)
    {
        winnerNum = Random.Range(0, 38);
        //call the starting animation here
        outerBall.SetActive(true);
        PlayStartinganimation();
        audioManager.SoundPlayingg(audioManager.winnerSound);

        Debug.Log("Time's up! Resetting the game...");

        yield return new WaitForSeconds(delay);
        //outerBall.SetActive(false) ;
        //animator.Play("Wheel 5");
        WinningNum();
        PlayAnimation();
       // AnimationWorking();
        WinningBettingAmount();
       
        if (timer <= 6 && timer >= 1)
        {
            //noMoreBets.SetActive(true);

            //Debug.Log("No More Bets");
            for (int i = 0; i < winnerscreen.Count; i++)
            {
                // OneTo36.No[i].SetActive(false);
                winnerscreen[i].SetActive(false);
                winningNumList[i].SetActive(false);
                //Debug.Log("All Winner Bord is false");
            }
            DeactiveNumbersAfterFive();
            //animatorpivote.enabled = true;

            // ChipsButtOnDesable.DisableButton();
            //RepeatValues();
        }

        yield return new WaitForSeconds(delay);

        Winnerstampb.StambDesable();

        ResetGame();

        ResetTimer();

        //----------------------------The variables Assighn Zero For next level------------------------------------------
        toatalWinningAmount = 0;
        playerGet = 0;
        playerGetFirstLine2to1 = 0;
        PlayerGetSecondLine2to1= 0;
        PlayerGetThirdLine2to1= 0;
        by12First = 0;
        by12Second = 0;
        by12Third = 0;
        by18First = 0;
        by18Second = 0;
        evenNumber = 0;
        oddNumber = 0;
        blackresult = 0;
        redresult = 0;
        center4 = 0;
        center2 = 0;
        center2SecondLine = 0;
        center2ThirdLine = 0;
        centerFirstDownLine = 0;
        centerLastDownLine = 0;
        doublecoumnValue = 0;
        singlecoumnValue = 0;
        by3FirstBn = 0;
        by3SecondBn = 0;
        by3ThirdBn = 0;
        ClearAllMembers();
        ActiveNumbers();

    }

    public void ResetTimer()
    {
        timer = timeDuration;
        gameRunning = true;

    }
    private void UpdateTimerUI()
    {
        bettingAmountCalculation = by3AddBEttingPointt.transferValueBy3;
        bettingAmountCalculation += SingleColumn.transferBettingSingleColmn;
        bettingAmountCalculation += DoubleColumn.transferDoubleColumnsValue;
        bettingAmountCalculation += TwoSide.translate2Side;
        bettingAmountCalculation += center4Selection.transferValueCenterpoint;
        bettingAmountCalculation += blackAndRed.transferValueRedAndBlack;
        bettingAmountCalculation += evenandOdd.transferValueEvenOrOdd;
        bettingAmountCalculation += by12.transferValueBy12;
        bettingAmountCalculation += twoToOne.transferValue2to1;
        bettingAmountCalculation += bettingScript.transferValue0to36;
        bettingAmountCalculation += by18.transferValue1to18;
        
        totalBettingAmountText.text = bettingAmountCalculation.ToString();
        //int minutes = Mathf.FloorToInt(timer / 60);
        int seconds = Mathf.FloorToInt(timer % 60);
        textVisible.text = $"{seconds:00}"; // Format MM:SS
    }
    private void ResetGame()
    {

        Debug.Log("Game reset! Ready for the next round.");
        noOfPlayGame++;
        noMoreBets.SetActive(false);
        toatalPlayingMatch.text =noOfPlayGame.ToString();
        playerGet = 0;
        checkingRepeating=true;
        ResetReduceChips();
        audioManager.SoundPlayingg(audioManager.betPlease);
        isSoundPlayOneTime = true;
        if (isChekingRepeat != 0)
        {
            repeatButton.SetActive(true);
        }
        else
        {
            isChekingRepeat = 0;
            repeatButton.SetActive(false);
        }
        isChekingRepeat = 0;
        playNow.SetActive(true );

        /*for(int i = 0; i < ReduceChips.Chips.Count; i++)
        {
           
        }*/
        //bettingAmountCalculation = 0;
        //totalBettingAmountText.text = bettingAmountCalculation.ToString();




        // Add your game reset logic here (e.g., clear bets, reset wheel, etc.)
    }
    private void WinningNum()
    {
       
        Debug.Log("Winner Number is " + winnerNum);
        Winnerstampb.StambEnable();


        //-------------------------------------------History-----------------------------------------


        if (redNumbers.Contains(winnerNum))
        {
            redHistoryList.Insert(0, $"<color=red>{winnerNum}</color>"); // Add red number
            yellowHistoryList.Insert(0, ""); // Keep right side empty for alignment
            greenHistoryList.Insert(0, "");
        }
        else if (greenNumbers.Contains(winnerNum))
        {
            string displaNum = winnerNum == 0 ? "0" : "00";

                greenHistoryList.Insert(0, $"<color=green>{displaNum}</color>");
            
            redHistoryList.Insert(0, "");
            yellowHistoryList.Insert(0, "");
        }
        else
        {
            yellowHistoryList.Insert(0, $"<color=yellow>{winnerNum}</color>"); // Add yellow number
            redHistoryList.Insert(0, ""); // Keep left side empty for alignment
            greenHistoryList.Insert(0, "");
        }

        // Keep history to last 10 entries
        if (redHistoryList.Count > 10) redHistoryList.RemoveAt(redHistoryList.Count - 1);
        if (yellowHistoryList.Count > 10) yellowHistoryList.RemoveAt(yellowHistoryList.Count - 1);
        if (greenHistoryList.Count > 10) greenHistoryList.RemoveAt (greenHistoryList.Count - 1);

        // Update UI
        redHistoryText.text = string.Join("\n", redHistoryList);
        yellowHistoryText.text = string.Join("\n", yellowHistoryList);
        greenHistoryText.text = string.Join("\n", greenHistoryList);


        for (int i = 0; i < winnerscreen.Count; i++)
        {
            if (i == winnerNum)
            {
                winnerscreen[i].SetActive(true);
                winningNumList[i].SetActive(true);
                Debug.Log(winningNumList[i]);
            }
            else
            {
                winnerscreen[i].SetActive(false);
                winningNumList[i].SetActive(false);

            }
        }
        
    }
    
    public void WinningBettingAmount()
    {

        //----------------------------0 To 37 Number Ratio Selection------------------------------------------

        if (bettingScript.upgradeCurrentPOint.Count > winnerNum)
        {
            int winningPoints = bettingScript.upgradeCurrentPOint[winnerNum];


            if (winningPoints > 0)
            {
                playerGet += winningPoints;
                playerGet += winningPoints * 35;
                BettingCoin.totalBalance += playerGet;
                
            }
            else
            {
               // Debug.Log("the player not assighned any points");
               // Debug.Log("You lose the match");
            }

        }

        //-----------------------------------By3 Number Ratio selection-------------------------------------------

        for (int i = 0; i < by3AddBEttingPointt.upgradeCurrentPointBy3.Count; i++)
        {
            if (i == 0&& by3AddBEttingPointt.upgradeCurrentPointBy3[i]>0)
            {
                if(winnerNum==3 || winnerNum==37 || winnerNum== 2)
                {
                    by3FirstBn += by3AddBEttingPointt.upgradeCurrentPointBy3[i];
                    by3FirstBn += 11 * by3AddBEttingPointt.upgradeCurrentPointBy3[i];
                    BettingCoin.totalBalance += by3FirstBn;
                }
            }
            else if( i==1 && by3AddBEttingPointt.upgradeCurrentPointBy3[i] > 0)
            {
                if(winnerNum == 0 || winnerNum==37 || winnerNum == 2)
                {
                    by3SecondBn += by3AddBEttingPointt.upgradeCurrentPointBy3[i];
                    by3SecondBn += 11 * by3AddBEttingPointt.upgradeCurrentPointBy3[i];
                    BettingCoin.totalBalance += by3SecondBn;
                }
            }
            else if (i==2 && by3AddBEttingPointt.upgradeCurrentPointBy3[i] > 0)
            {
                if ( winnerNum == 0 || winnerNum == 2 || winnerNum == 1)
                {
                    by3ThirdBn += by3AddBEttingPointt.upgradeCurrentPointBy3[i];
                    by3ThirdBn += 11 * by3AddBEttingPointt.upgradeCurrentPointBy3[i];
                    BettingCoin.totalBalance += by3ThirdBn;
                }
            }
        }

        //----------------------------First 2 TO 1 line Number Ratio Selection------------------------------------------

        for (int i = 0; i < bettingScript.upgradeCurrentPOint.Count; i++)
            {
                if (i % 3 == 0)
                {
                    if (i == winnerNum)
                    {
                        playerGetFirstLine2to1 += twoToOne.upgradeCurrentPoint[0];
                        playerGetFirstLine2to1 += 2 * twoToOne.upgradeCurrentPoint[0];
                        BettingCoin.totalBalance += playerGetFirstLine2to1;
                        break;
                    }
                }
            }
       


        //----------------------------Second 2 TO 1 line Number Ratio Selection------------------------------------------

        for (int i = 0; i < bettingScript.upgradeCurrentPOint.Count; i++)
        {
            if (i % 3 == 2)
            {
                if (i == winnerNum)
                {
                    
                    PlayerGetSecondLine2to1 += twoToOne.upgradeCurrentPoint[1];
                    PlayerGetSecondLine2to1 += 2 * twoToOne.upgradeCurrentPoint[1];
                    BettingCoin.totalBalance += PlayerGetSecondLine2to1;
                    break;
                }
            }
        }
       


        //----------------------------Third 2 TO 1 line Number Ratio Selection------------------------------------------



        for (int i = 0; i < bettingScript.upgradeCurrentPOint.Count; i++)
        {
            if (i % 3 == 1)
            {
                if (i == winnerNum)
                {

                    PlayerGetThirdLine2to1 += twoToOne.upgradeCurrentPoint[2];
                    PlayerGetThirdLine2to1  += 2 * twoToOne.upgradeCurrentPoint[2];
                    BettingCoin.totalBalance += PlayerGetThirdLine2to1;
                    break;
                }
            }
        }


        //----------------------------By 12 First ------------------------------------------

        for(int i = 0;i < bettingScript.upgradeCurrentPOint.Count; i++)
        {

            //----------------------------By 12 First ------------------------------------------

            if (i <= 12 && i>0 && by12.upgradeCurrentPoint2[0]>0)
            {
                if(i == winnerNum)
                {
                    by12First += by12.upgradeCurrentPoint2[0];
                    by12First += by12.upgradeCurrentPoint2[0]*2;
                    BettingCoin.totalBalance += by12First;
                }
            }

            //----------------------------By 12 Second ------------------------------------------

            else if( i>12&& i<=24 && by12.upgradeCurrentPoint2[1] > 0)
            {
                if (i == winnerNum)
                {
                    by12Second += by12.upgradeCurrentPoint2[1];
                    by12Second += by12.upgradeCurrentPoint2[1]*2;
                    BettingCoin.totalBalance += by12Second;
                }
            }

            //----------------------------By 12 Third ------------------------------------------

            else if (i > 24 && i <= 36 && by12.upgradeCurrentPoint2[2] > 0)
            {
                if (i == winnerNum)
                {
                    by12Third += by12.upgradeCurrentPoint2[2];
                    by12Third += by12.upgradeCurrentPoint2[2] * 2;
                    BettingCoin.totalBalance += by12Third;
                }
            }
        }

        

        for (int i = 0; i < bettingScript.upgradeCurrentPOint.Count; i++)
        {
            //----------------------------By 18 First ------------------------------------------

            if ( i <= 18&& i>0 && by18.upgradeCurrentPoint3[0] > 0)
            {
                if(i == winnerNum)
                {
                    by18First += by18.upgradeCurrentPoint3[0];
                    by18First += by18.upgradeCurrentPoint3[0] * 1;
                    BettingCoin.totalBalance += by18First;
                }
            }
            //----------------------------By 18 Second ------------------------------------------

            else if(i>18&& i<=36&& by18.upgradeCurrentPoint3[1] > 0)
            {
                if (i == winnerNum)
                {
                    by18Second += by18.upgradeCurrentPoint3[1];
                    by18Second += by18.upgradeCurrentPoint3[1] * 1;
                    BettingCoin.totalBalance += by18Second;
                }
            }
        }

        //----------------------------Even And Odd Numbers------------------------------------------

        for(int i = 0;i < bettingScript.upgradeCurrentPOint.Count; i++)
        {
            //----------------------------Even Number ------------------------------------------

            if(i%2==0 && evenandOdd.upgradeCurrentPoint4[0]>0)
            {
                if (i == winnerNum)
                {
                    evenNumber +=evenandOdd.upgradeCurrentPoint4[0];
                    evenNumber += evenandOdd.upgradeCurrentPoint4[0] * 1;
                    BettingCoin.totalBalance += evenNumber;
                }
            }

            //----------------------------Odd Number ------------------------------------------

            else if (i%2==1 && evenandOdd.upgradeCurrentPoint4[1] > 0)
            {
                if (i == winnerNum)
                {
                    oddNumber += evenandOdd.upgradeCurrentPoint4[1];
                    oddNumber += evenandOdd.upgradeCurrentPoint4[1] * 1;
                    BettingCoin.totalBalance += oddNumber;


                }
            }
        }

        //----------------------------Black and Red Numbers------------------------------------------

        for (int i = 0; i < bettingScript.upgradeCurrentPOint.Count; i++)
        {
            //---------------------------- Red Numbers------------------------------------------

            if (blackAndRed.upgradeCurrentPoint5[1] > 0)
            {
                if (i <= 9 && i > 0 && (i % 2) == 1&& winnerNum==i)
                {
                    redresult += blackAndRed.upgradeCurrentPoint5[1];
                    redresult += blackAndRed.upgradeCurrentPoint5[1] * 1;
                    BettingCoin.totalBalance += redresult;
                }
                else if (i <= 18 && i >= 12 && (i % 2) == 0 && winnerNum == i)
                {
                    redresult += blackAndRed.upgradeCurrentPoint5[1];

                    redresult += blackAndRed.upgradeCurrentPoint5[1] * 1;
                    BettingCoin.totalBalance += redresult;
                }
                else if (i <= 27 && i >= 19 && (i % 2) == 1 && winnerNum == i)
                {
                    redresult += blackAndRed.upgradeCurrentPoint5[1];

                    redresult += blackAndRed.upgradeCurrentPoint5[1] * 1;
                    BettingCoin.totalBalance += redresult;
                }
                else if ((i % 2) == 0 && i <= 36 && i >= 30 && winnerNum == i)
                {
                    redresult += blackAndRed.upgradeCurrentPoint5[1];

                    redresult += blackAndRed.upgradeCurrentPoint5[1] * 1;
                    BettingCoin.totalBalance += redresult;
                }
            }

            //---------------------------- Black Numbers------------------------------------------

            if (blackAndRed.upgradeCurrentPoint5[0] > 0)
            {
                if(i <= 10 && i > 0 && (i % 2) == 0 && winnerNum == i)
                {
                    blackresult += blackAndRed.upgradeCurrentPoint5[0];

                    blackresult += blackAndRed.upgradeCurrentPoint5[0] * 1;
                    BettingCoin.totalBalance += blackresult;
                }
                else if(i <= 18 && i >= 11 && (i % 2) == 1 && winnerNum == i)
                {
                    blackresult += blackAndRed.upgradeCurrentPoint5[0];

                    blackresult += blackAndRed.upgradeCurrentPoint5[0] * 1;
                    BettingCoin.totalBalance += blackresult;
                }
                else if (19 <= i && i <= 28 && (i % 2) == 0 && winnerNum == i)
                {
                    blackresult += blackAndRed.upgradeCurrentPoint5[0];

                    blackresult += blackAndRed.upgradeCurrentPoint5[0] * 1;
                    BettingCoin.totalBalance += blackresult;
                }
                else if((i%2) == 1&& i >=29&& i <= 35 && winnerNum == i)
                {
                    blackresult += blackAndRed.upgradeCurrentPoint5[0];

                    blackresult += blackAndRed.upgradeCurrentPoint5[0] * 1;
                    BettingCoin.totalBalance += blackresult;
                }
            }
        }
        //---------------------------- Center4 Numbers------------------------------------------


        int rows = 12; // 12 rows
        int cols = 3;  // 3 columns

        for (int i = 1; i <= (rows - 1) * cols; i++) // Avoid last row
        {
            if (i % cols != 0) // Ensure it's not the last column (3, 6, 9...)
            {
                

                List<int> sequence = new List<int>
            {
                i, i + 1,  // Top row numbers
                i + cols, i + cols + 1 // Bottom row numbers
            };
                if (winnerNum == i || winnerNum == i + 1 || winnerNum == i + cols || winnerNum == i + cols + 1)
                {
                    if (center4Selection.upgradeCurrentPoint6[k] > 0)
                    {
                        center4 += center4Selection.upgradeCurrentPoint6[k];
                        center4 += center4Selection.upgradeCurrentPoint6[k] * 8;
                        BettingCoin.totalBalance += center4;
                    }

                }


                //Debug.Log($"({sequence[0]},{sequence[1]},{sequence[2]},{sequence[3]})");
                k++;
                
            }
        }
        k = 0;


        //---------------------------- Center2 Numbers------------------------------------------

        //---------------------------- Center2 First Line------------------------------------------



       for (int i = 0; i<bettingScript.upgradeCurrentPOint.Count; i+=3)
       {
           // Debug.Log(i);
            
            for (int n = 0; n <= 33; n ++) // Generate pairs dynamically
            {
              if (winnerNum == i || winnerNum == i + 3) // Check if it's part of any pair
              {

                if (0 < TwoSide.upgradeCurrentPoint7[k])
                {
                   center2SecondLine += TwoSide.upgradeCurrentPoint7[k];
                   center2SecondLine += TwoSide.upgradeCurrentPoint7[k]*17; // Add value to total
                   BettingCoin.totalBalance += center2SecondLine;
                   break;
                }
                 //break;
              }
            }
            k++;
       }
        k = 0;
        //---------------------------- Center2 Second Line------------------------------------------
        t = 26;
        for (int i = 2; i < bettingScript.upgradeCurrentPOint.Count; i += 3)
        {
            //Debug.Log(i+" i");
            //Debug.Log(t + " t");


            for (int n = 0; n <= 33; n++) // Generate pairs dynamically
            {
                if (winnerNum == i || winnerNum == i + 3) // Check if it's part of any pair
                {
                    if (0 < TwoSide.upgradeCurrentPoint7[t])
                    {
                       // Debug.Log("Winning number is in the pattern: (" + i + "," + (i + 3) + ")");
                        center2 += TwoSide.upgradeCurrentPoint7[t];
                        center2 += TwoSide.upgradeCurrentPoint7[t] * 17; // Add value to total
                        BettingCoin.totalBalance += center2;
                        //Debug.Log("Updated Winning Amount: " + center2);
                        break;
                    }
                    //break;
                }
            }
            t++;
        }
        t = 0;

        //-----------------------------Center 2 Third Line-----------------------------------------
        q = 49;
        for (int i = 0; i < bettingScript.upgradeCurrentPOint.Count; i += 3)
        {
            Debug.Log(i + " i");
            Debug.Log(q + " q");

            if (q == 61)
            {
                break;
            }
            for (int n = 0; n <= 33; n++) // Generate pairs dynamically
            {
                if(i == 0)
                {
                    Debug.Log(" the pattern: (" + i + "," + (i + 3) + ")");

                    if (winnerNum == i || winnerNum == i + 1) // Check if it's part of any pair
                    {
                        if (0 < TwoSide.upgradeCurrentPoint7[q])
                        {
                            Debug.Log("Winning number is in the pattern: (" + i + "," + (i + 1) + ")");
                            center2ThirdLine += TwoSide.upgradeCurrentPoint7[q];
                            center2ThirdLine += TwoSide.upgradeCurrentPoint7[q] * 17; // Add value to total
                            BettingCoin.totalBalance += center2ThirdLine;
                                    Debug.Log("Updated Winning Amount: " + center2ThirdLine);
                            break;
                        }
                    }
                    i = -2;
                }
                else if (i >= 1)
                {
                    Debug.Log(" pattern: (" + i + "," + (i + 3) + ")");

                    if (winnerNum == i || winnerNum == i + 3) // Check if it's part of any pair
                    {
                        if (0 < TwoSide.upgradeCurrentPoint7[q])
                        {
                            Debug.Log("Winning number is in the pattern: (" + i + "," + (i + 3) + ")");
                            center2ThirdLine += TwoSide.upgradeCurrentPoint7[q];
                            center2ThirdLine += TwoSide.upgradeCurrentPoint7[q] * 17; // Add value to total
                            BettingCoin.totalBalance += center2ThirdLine;
                                    Debug.Log("Updated Winning Amount: " + center2ThirdLine);
                            break;
                        }
                    } 
                }
            }
            q++;
        }
        q = 0;

        //-----------------------------Center 2 First Line Down-----------------------------------------
        Check1 = 12;

        for (int i = 2; i < bettingScript.upgradeCurrentPOint.Count; i += 3)
        {
           // Debug.Log(i + " i");
           // Debug.Log(Check1 + " Check1");


            for (int n = 0; n <= 33; n++) // Generate pairs dynamically
            {
                if (winnerNum == i || winnerNum == i + 1) // Check if it's part of any pair
                {
                    if (0 < TwoSide.upgradeCurrentPoint7[Check1])
                    {
                        //Debug.Log("Winning number is in the pattern: (" + i + "," + (i + 1) + ")");
                        centerFirstDownLine += TwoSide.upgradeCurrentPoint7[Check1];
                        centerFirstDownLine += TwoSide.upgradeCurrentPoint7[Check1] * 17; // Add value to total
                        BettingCoin.totalBalance += centerFirstDownLine;
                        //Debug.Log("Updated Winning Amount: " + centerFirstDownLine);
                        break;
                    }
                }
            }
            Check1++;
        }
        Check1 = 0;

        //-----------------------------Center 2 Last Line Down-----------------------------------------

        Check2 = 37;

        for (int i = 1; i < bettingScript.upgradeCurrentPOint.Count; i += 3)
        {
           /* Debug.Log(i + " i");
            Debug.Log(Check2 + " Check2");*/


            for (int n = 0; n <= 33; n++) // Generate pairs dynamically
            {
                if (winnerNum == i || winnerNum == i + 1) // Check if it's part of any pair
                {
                    if (0 < TwoSide.upgradeCurrentPoint7[Check2])
                    {
                        //Debug.Log("Winning number is in the pattern: (" + i + "," + (i + 1) + ")");
                        centerLastDownLine += TwoSide.upgradeCurrentPoint7[Check2];
                        centerLastDownLine += TwoSide.upgradeCurrentPoint7[Check2] * 17; // Add value to total
                        BettingCoin.totalBalance += centerLastDownLine;
                        //Debug.Log("Updated Winning Amount: " + centerLastDownLine);
                        break;
                    }
                }
            }
            Check2++;
        }
        Check2 = 0;

        //-----------------------------------------------------------------------------------------------------



        //-----------------------------Double Column-----------------------------------------

        for (int i = 0; i < DobleSelection.No.Count; i++)
        {
            for (int j = (i *3 )-2; (i+1)*3>=j; j++)
            {
                
                if (i == 0)
                {
                    if(winnerNum==0||winnerNum==1|| winnerNum ==2|| winnerNum ==3|| winnerNum == 37 && DoubleColumn.upgradeCurrentPoint8[i]>0)
                    {
                        Debug.Log("Winner Number is " + i + "th position And That Number Id " + j);

                        doublecoumnValue += DoubleColumn.upgradeCurrentPoint8[i];
                        doublecoumnValue += DoubleColumn.upgradeCurrentPoint8[i] * 5;
                        BettingCoin.totalBalance += doublecoumnValue;
                        break;

                    }
                }
                else
                {
                  
                    if (winnerNum == j&& DoubleColumn.upgradeCurrentPoint8[i] >0)
                    {
                        Debug.Log("Winner Number is "+ i + "th position And That Number Id "+ j);

                        doublecoumnValue += DoubleColumn.upgradeCurrentPoint8[i];
                        doublecoumnValue += DoubleColumn.upgradeCurrentPoint8[i] * 5;
                        BettingCoin.totalBalance += doublecoumnValue;
                        break;

                    }
                }


            }

        }


        //-----------------------------Single Column-----------------------------------------

        for(int i = 0; i < SingleColmnSelection.No.Count; i++)
        {
            for (int j = (i*3)+1; j <= (i + 1) * 3; j++)
            {

                if (SingleColumn.upgradeCurrentPoint9[i] > 0&& winnerNum==j)
                {
                    Debug.Log("Winner Number is " + i + "th position And That Number Id " + j);

                    singlecoumnValue += SingleColumn.upgradeCurrentPoint9[i];
                    singlecoumnValue += SingleColumn.upgradeCurrentPoint9[i] * 11;
                    BettingCoin.totalBalance += singlecoumnValue;
                    break;

                }
            }
        }


        //------------------------- Adding vslues in to  Repeatinglist---------------------------------

        //-------------------------Two Side ---------------------------------

       
        for (int i = 0;i < TwoSide.upgradeCurrentPoint7.Count; i++)
        { 
            repeatValuesss[i] = TwoSide.upgradeCurrentPoint7[i];
            isChekingRepeat += repeatValuesss[i];
        }
        /*for(int i =0; i < by2.Count; i++)
        {
            //by2[i].reduceChips.Chips = by2[i].twoSideBeckup;
            by2[i].twoSideBeckup = by2[i].reduceChips.Chips;
        }*/


        //-------------------------4 Side ---------------------------------

        for (int i = 0; i < center4Selection.upgradeCurrentPoint6.Count; i++)
        {
            repeatValuesss4Side[i] = center4Selection.upgradeCurrentPoint6[i];
            isChekingRepeat += repeatValuesss4Side[i];
        }

        //-------------------------Black And Red ---------------------------------

        for (int i = 0; i<blackAndRed.upgradeCurrentPoint5.Count; i++)
        {
            repeatvaluesssBlackAndWight[i] = blackAndRed.upgradeCurrentPoint5[i];
            isChekingRepeat += repeatvaluesssBlackAndWight[i];
        }

        //-------------------------Odd And Even ---------------------------------

        for (int i = 0;i<evenandOdd.upgradeCurrentPoint4.Count; i++)
        {
            repeatvaluesssEvenandOdd[i] = evenandOdd.upgradeCurrentPoint4[i];
            isChekingRepeat += repeatvaluesssEvenandOdd[i];
        }

        //-------------------------By18 ---------------------------------

        for (int i = 0;i<by18.upgradeCurrentPoint3.Count; i++)
        {
            repeatvaluesssBy18[i] = by18.upgradeCurrentPoint3[i];
            isChekingRepeat += repeatvaluesssBy18[i];
        }

        //-------------------------By12 ---------------------------------

        for (int i = 0; i < by12.upgradeCurrentPoint2.Count; i++)
        {
            repeatvaluesssBy12[i] = by12.upgradeCurrentPoint2[i];
            isChekingRepeat += repeatvaluesssBy12[i];
        }

        //-------------------------2to1 ---------------------------------

        for (int i = 0; i < twoToOne.upgradeCurrentPoint.Count; i++)
        {
            repeatvaluesss2to1[i] = twoToOne.upgradeCurrentPoint[i];
            isChekingRepeat += repeatvaluesss2to1[i];
        }

        //--------------------------By3-------------------------------------

        for (int i =0; i<by3AddBEttingPointt.upgradeCurrentPointBy3.Count; i++)
        {
            repeatValueBy3[i] = by3AddBEttingPointt.upgradeCurrentPointBy3[i];
            isChekingRepeat += repeatValueBy3[i];
        }

        //-------------------------0 to 37 ---------------------------------

        for (int i = 0; i < bettingScript.upgradeCurrentPOint.Count; i++)
        {
            repeatvaluesss0to37[i] = bettingScript.upgradeCurrentPOint[i];
            isChekingRepeat += repeatvaluesss0to37[i];
        }

        //-------------------------Single value---------------------------------

        for (int i = 0;i < SingleColumn.upgradeCurrentPoint9.Count; i++)
        {
            repeatvaluesSimgleColumns[i]=SingleColumn.upgradeCurrentPoint9[i];
            isChekingRepeat += repeatvaluesSimgleColumns[i];
        }

        //-------------------------Doble value---------------------------------

        for (int i = 0; i < DoubleColumn.upgradeCurrentPoint8.Count; i++)
        {
            repeatvaluesDoubleColumns[i] = DoubleColumn.upgradeCurrentPoint8[i];
            isChekingRepeat += repeatvaluesDoubleColumns[i];

        }

        //----------------------------Total Value Setting------------------------------------------
        toatalWinningAmount += playerGetFirstLine2to1;
        toatalWinningAmount += playerGet;
        toatalWinningAmount += PlayerGetSecondLine2to1;
        toatalWinningAmount += PlayerGetThirdLine2to1;
        toatalWinningAmount += by12First;
        toatalWinningAmount += by12Second;
        toatalWinningAmount += by12Third;
        toatalWinningAmount += by18First;
        toatalWinningAmount += by18Second;
        toatalWinningAmount += evenNumber;
        toatalWinningAmount += oddNumber;
        toatalWinningAmount += blackresult;
        toatalWinningAmount += redresult;//redValue
        toatalWinningAmount += center4;//Center4 
        toatalWinningAmount += center2SecondLine;//
        toatalWinningAmount += center2;
        toatalWinningAmount += center2ThirdLine;
        toatalWinningAmount += centerFirstDownLine;
        toatalWinningAmount += centerLastDownLine;
        toatalWinningAmount += doublecoumnValue;
        toatalWinningAmount += singlecoumnValue;
        toatalWinningAmount += by3FirstBn;
        toatalWinningAmount += by3SecondBn;
        toatalWinningAmount += by3ThirdBn;

        Debug.Log("Total Winning Amount  " + toatalWinningAmount);
        totalWinningAmountText.text = toatalWinningAmount.ToString();

      
    }
   public void RepeatValues()
   {
      
   }
    public void RepeatValuesAddButton()
    {
       

            audioManager.SoundPlayingg(audioManager.repeatAudio);

            int chechValue = 0;

            //-------------------------By2-------------------------------

            if (timer > 5 && checkingRepeating == true)
            {
                ClearAllMembers();
                for (int j = 0; j < repeatValuesss.Count; j++)
                {
                    chechValue += repeatValuesss[j];
                }
                if (chechValue <= BettingCoin.totalBalance)
                {
                    for (int i = 0; i < TwoSide.upgradeCurrentPoint7.Count; i++)
                    {
                        TwoSide.upgradeCurrentPoint7[i] = repeatValuesss[i];
                        BettingCoin.totalBalance -= repeatValuesss[i];
                        TwoSide.translate2Side += repeatValuesss[i];
                        if (TwoSide.upgradeCurrentPoint7[i] > 0)
                        {
                            TwoSide.TwosideChips[i].SetActive(true);
                        }
                    }
                }
                //-------------------------By4-------------------------------

                for (int j = 0; j < repeatValuesss4Side.Count; j++)
                {
                    chechValue += repeatValuesss4Side[j];
                }
                if (chechValue <= BettingCoin.totalBalance)
                {
                    for (int i = 0; i < center4Selection.upgradeCurrentPoint6.Count; i++)
                    {
                        center4Selection.upgradeCurrentPoint6[i] = repeatValuesss4Side[i];
                        checkingRepeating = false;
                        BettingCoin.totalBalance -= repeatValuesss4Side[i];
                        center4Selection.transferValueCenterpoint += repeatValuesss4Side[i];
                        if (center4Selection.upgradeCurrentPoint6[i] > 0)
                        {
                            center4Selection.centerPointImage[i].SetActive(true);
                        }
                    }
                }
                //-------------------------ByBlackAndRed-------------------------------

                for (int j = 0; j < repeatvaluesssBlackAndWight.Count; j++)
                {
                    chechValue += repeatvaluesssBlackAndWight[j];
                }
                if (chechValue <= BettingCoin.totalBalance)
                {
                    for (int i = 0; i < blackAndRed.upgradeCurrentPoint5.Count; i++)
                    {
                        blackAndRed.upgradeCurrentPoint5[i] = repeatvaluesssBlackAndWight[i];
                        checkingRepeating = false;
                        BettingCoin.totalBalance -= repeatvaluesssBlackAndWight[i];
                        blackAndRed.transferValueRedAndBlack += repeatvaluesssBlackAndWight[i];
                        if (blackAndRed.upgradeCurrentPoint5[i] > 0)
                        {
                            blackAndRed.RedAndBlackImage[i].SetActive(true);
                        }
                    }
                }
                //-------------------------ByEvenAndOdd-------------------------------

                for (int j = 0; j < repeatvaluesssEvenandOdd.Count; j++)
                {
                    chechValue += repeatvaluesssEvenandOdd[j];
                }
                if (chechValue <= BettingCoin.totalBalance)
                {
                    for (int i = 0; i < evenandOdd.upgradeCurrentPoint4.Count; i++)
                    {
                        evenandOdd.upgradeCurrentPoint4[i] = repeatvaluesssEvenandOdd[i];
                        checkingRepeating = false;
                        BettingCoin.totalBalance -= repeatvaluesssEvenandOdd[i];
                        evenandOdd.transferValueEvenOrOdd += repeatvaluesssEvenandOdd[i];
                        if (evenandOdd.upgradeCurrentPoint4[i] > 0)
                        {
                            evenandOdd.evenAndOddImage[i].SetActive(true);
                        }
                    }
                }
                //-------------------------By18-------------------------------

                for (int j = 0; j < repeatvaluesssBy18.Count; j++)
                {
                    chechValue += repeatvaluesssBy18[j];
                }
                if (chechValue <= BettingCoin.totalBalance)
                {
                    for (int i = 0; i < by18.upgradeCurrentPoint3.Count; i++)
                    {
                        by18.upgradeCurrentPoint3[i] = repeatvaluesssBy18[i];
                        checkingRepeating = false;
                        BettingCoin.totalBalance -= repeatvaluesssBy18[i];
                        by18.transferValue1to18 += repeatvaluesssBy18[i];
                        if (by18.upgradeCurrentPoint3[i] > 0)
                        {
                            by18.by18[i].SetActive(true);
                        }
                    }
                }
                //-------------------------By12-------------------------------

                for (int j = 0; j < repeatvaluesssBy12.Count; j++)
                {
                    chechValue += repeatvaluesssBy12[j];
                }
                if (chechValue <= BettingCoin.totalBalance)
                {
                    for (int i = 0; i < by12.upgradeCurrentPoint2.Count; i++)
                    {
                        by12.upgradeCurrentPoint2[i] = repeatvaluesssBy12[i];
                        checkingRepeating = false;
                        BettingCoin.totalBalance -= repeatvaluesssBy12[i];
                        by12.transferValueBy12 += repeatvaluesssBy12[i];
                        if (by12.upgradeCurrentPoint2[i] > 0)
                        {
                            by12.ByTwelve[i].SetActive(true);
                        }
                    }
                }
                //-------------------------By2to1-------------------------------

                for (int j = 0; j < repeatvaluesss2to1.Count; j++)
                {
                    chechValue += repeatvaluesss2to1[j];
                }
                if (chechValue <= BettingCoin.totalBalance)
                {
                    for (int i = 0; i < twoToOne.upgradeCurrentPoint.Count; i++)
                    {
                        twoToOne.upgradeCurrentPoint[i] = repeatvaluesss2to1[i];
                        checkingRepeating = false;
                        BettingCoin.totalBalance -= repeatvaluesss2to1[i];
                        twoToOne.transferValue2to1 += repeatvaluesss2to1[i];
                        if (twoToOne.upgradeCurrentPoint[i] > 0)
                        {
                            twoToOne.twoToOneImage[i].SetActive(true);
                        }
                    }
                }

                //------------------------------By3----------------------------

                for (int j = 0; j < repeatValueBy3.Count; j++)
                {
                    chechValue += repeatValueBy3[j];
                }
                if (chechValue <= BettingCoin.totalBalance)
                {
                    for (int i = 0; i < by3AddBEttingPointt.upgradeCurrentPointBy3.Count; i++)
                    {
                        by3AddBEttingPointt.upgradeCurrentPointBy3[i] = repeatValueBy3[i];
                        checkingRepeating = false;
                        BettingCoin.totalBalance -= repeatValueBy3[i];
                        by3AddBEttingPointt.transferValueBy3 += repeatValueBy3[i];
                        if (by3AddBEttingPointt.upgradeCurrentPointBy3[i] > 0)
                        {
                            by3AddBEttingPointt.by3Image[i].SetActive(true);
                        }
                    }
                }

                //-------------------------By0to36-------------------------------

                for (int j = 0; j < repeatvaluesss0to37.Count; j++)
                {
                    chechValue += repeatvaluesss0to37[j];
                }
                if (chechValue <= BettingCoin.totalBalance)
                {
                    for (int i = 0; i < bettingScript.upgradeCurrentPOint.Count; i++)
                    {
                        bettingScript.upgradeCurrentPOint[i] = repeatvaluesss0to37[i];
                        checkingRepeating = false;
                        BettingCoin.totalBalance -= repeatvaluesss0to37[i];
                        bettingScript.transferValue0to36 += repeatvaluesss0to37[i];
                        if (bettingScript.upgradeCurrentPOint[i] > 0)
                        {
                            bettingScript.ZeroTo36Image[i].SetActive(true);
                        }
                    }
                }
                //-------------------------By3-------------------------------

                for (int j = 0; j < repeatvaluesSimgleColumns.Count; j++)
                {
                    chechValue += repeatvaluesSimgleColumns[j];
                }
                if (chechValue <= BettingCoin.totalBalance)
                {
                    for (int i = 0; i < SingleColumn.upgradeCurrentPoint9.Count; i++)
                    {
                        SingleColumn.upgradeCurrentPoint9[i] = repeatvaluesSimgleColumns[i];
                        checkingRepeating = false;
                        BettingCoin.totalBalance -= repeatvaluesSimgleColumns[i];
                        SingleColumn.transferBettingSingleColmn += repeatvaluesSimgleColumns[i];
                        if (SingleColumn.upgradeCurrentPoint9[i] > 0)
                        {
                            SingleColumn.singleColumnChips[i].SetActive(true);
                        }
                    }
                }
                //-------------------------By6-------------------------------

                for (int j = 0; j < repeatvaluesDoubleColumns.Count; j++)
                {
                    chechValue += repeatvaluesDoubleColumns[j];
                }
                if (chechValue <= BettingCoin.totalBalance)
                {
                    for (int i = 0; i < DoubleColumn.upgradeCurrentPoint8.Count; i++)
                    {
                        DoubleColumn.upgradeCurrentPoint8[i] = repeatvaluesDoubleColumns[i];
                        checkingRepeating = false;
                        BettingCoin.totalBalance -= repeatvaluesDoubleColumns[i];
                        DoubleColumn.transferDoubleColumnsValue += repeatvaluesDoubleColumns[i];
                        if (DoubleColumn.upgradeCurrentPoint8[i] > 0)
                        {
                            DoubleColumn.bySixChips[i].SetActive(true);
                        }
                    }
                }
                //isChekingRepeat = chechValue;
            }
        
        else
        {
            Debug.Log("There is no value in repeat vallue");
        }
    }
    public void ClearAllMembers()//Each match last clear the all list for next round.
    {
        //ResetReduceChips();
        for(int i = 0;TwoSide.upgradeCurrentPoint7.Count > i; i++)
        {
            TwoSide.translate2Side = 0;
            TwoSide.upgradeCurrentPoint7[i] = 0;
            TwoSide.TwosideChips[i].SetActive(false);
        }
        
        for(int i =0; center4Selection.upgradeCurrentPoint6.Count > i; i++)
        {
            center4Selection.transferValueCenterpoint = 0;
            center4Selection.upgradeCurrentPoint6[i] = 0;
            center4Selection.centerPointImage[i].SetActive(false);
        }
        for (int i = 0; blackAndRed.upgradeCurrentPoint5.Count > i; i++)
        {
            blackAndRed.transferValueRedAndBlack = 0;
            blackAndRed.upgradeCurrentPoint5[i] = 0;
            blackAndRed.RedAndBlackImage[i].SetActive(false);
        }
        for(int i =0; evenandOdd.upgradeCurrentPoint4.Count > i; i++)
        {
            evenandOdd.transferValueEvenOrOdd = 0;
            evenandOdd.upgradeCurrentPoint4[i] = 0;
            evenandOdd.evenAndOddImage[i].SetActive(false);
        }
        for (int i =0; by18.upgradeCurrentPoint3.Count > i; i++)
        {
            by18.transferValue1to18 = 0;
            by18.upgradeCurrentPoint3[i] = 0;
            by18.by18[i].SetActive(false);
        }
        for(int i = 0; by12.upgradeCurrentPoint2.Count > i; i++)
        {
            by12.transferValueBy12 = 0;
            by12.upgradeCurrentPoint2[i] = 0;
            by12.ByTwelve[i].SetActive(false);
        }
        for(int i = 0; i < twoToOne.upgradeCurrentPoint.Count; i++)
        {
            twoToOne.transferValue2to1 = 0;
            twoToOne.upgradeCurrentPoint[i] = 0;
            twoToOne.twoToOneImage[i].SetActive(false);
        }
        for( int i = 0;bettingScript.upgradeCurrentPOint.Count > i; i++)
        {
            bettingScript.transferValue0to36 = 0;
            bettingScript.upgradeCurrentPOint[i] = 0;
            bettingScript.ZeroTo36Image [i].SetActive(false);
        }
        for(int i =0; i<DoubleColumn.upgradeCurrentPoint8.Count; i++)
        {
            DoubleColumn.transferDoubleColumnsValue = 0;
            DoubleColumn.upgradeCurrentPoint8[i] = 0;
            DoubleColumn.bySixChips[i].SetActive(false);
        }
        for(int i = 0; i<SingleColumn.upgradeCurrentPoint9.Count; i++)
        {
            SingleColumn.transferBettingSingleColmn = 0;
            SingleColumn.upgradeCurrentPoint9[i] = 0;
            SingleColumn.singleColumnChips[i].SetActive(false);
        }
        for (int i = 0; i <by3AddBEttingPointt.upgradeCurrentPointBy3.Count ; i++)
        {
            by3AddBEttingPointt.transferValueBy3 = 0;
            by3AddBEttingPointt.upgradeCurrentPointBy3[i] = 0;
            by3AddBEttingPointt.by3Image[i].SetActive(false);
        }
    }
    public void ActiveNumbers()
    {
        panelForButtondeactive.SetActive(false);
    }
    public void DeactiveNumbersAfterFive()
    {
        //panelForButtondeactive.SetActive(true);
        noMoreBets.SetActive(true);
        StartCoroutine(DatePickerOn());
        //info.CloseImage();
       /* info.panelInfo.SetActive(false);
        info.wheel.SetActive(true);
        info.wheelStand.SetActive(true);*/
        if (isSoundPlayOneTime == true)
        {
            audioManager.SoundPlayingg(audioManager.noMoreBets);
            noMoreBets.SetActive(true) ;
            isSoundPlayOneTime = false;
        }

    }
    public void DatePickerFunction()
    {
       /* DatePicker.Hide();
        DatePicker1.Hide();*/
    }
    public IEnumerator DatePickerOn()
    {
        yield return new WaitForSeconds(0f);
        DatePicker.Hide();
        DatePicker1.Hide();
        DatePicker2.Hide();
        yield return new WaitForSeconds (1.5f);
        panelForButtondeactive.SetActive(true);
        info.panelInfo.SetActive(false);
        info.wheel.SetActive(true);
        info.wheelStand.SetActive(true);
        info.coinHighLights.SetActive(true);
    }
   /* public void DeactiveNumberAfterSeven()
    {
        StartCoroutine(DatePickerOn());
    }*/
    public void RestoreChipsFromBackup()
    {
        ResetReduceChips();
        
        for(int i = 0;i<by2.Count;i++)
        {
            by2[i].reduceChips.Chips.AddRange(by2[i].twoSideBeckup);

            by2[i].checking = false;

            if (TwoSide.upgradeCurrentPoint7[i] > 0)
            {
                TwoSide.TwosideChips[i].SetActive(true);
            }
        }
    }
    public void ResetReduceChips()
    {
        for (int i = 0; backValues.Count > i; i++)
        {
/*            Debug.Log(backValues[i]);
                backValues[i].reduceChips.Chips.Clear();*/
           
        }
        for(int i=0; centerPoint.Count > i; i++)
        {
            centerPoint[i].reduceChips.Chips.Clear();
        }
        for(int i=0; by2.Count > i; i++)
        {
            by2[i].reduceChips.Chips.Clear();
        }
        for (int i = 0;by6backvalues.Count > i; i++)
        {
            by6backvalues[i].reduceChips.Chips.Clear();
        }
        for (int i = 0; by3backValues.Count > i; i++)
        {
            by3backValues[i].reduceChips.Chips.Clear();
        }
        for (int i = 0; TwoToOnebackValues.Count > i; i++)
        {
            TwoToOnebackValues[i].reduceChips.Chips.Clear();
        }
        for (int i = 0; by12backValues.Count > i; i++)
        {
            by12backValues[i].reduceChips.Chips.Clear();
        }
        for (int i = 0;by18backValues .Count > i; i++)
        {
            by18backValues[i].reduceChips.Chips.Clear();
        }
        for (int i = 0; oddAndEvenbackValues.Count > i; i++)
        {
            oddAndEvenbackValues[i].reduceChips.Chips.Clear();
        }
        for (int i = 0; BandRbackValues.Count > i; i++)
        {
           BandRbackValues[i].reduceChips.Chips.Clear();
        }
        for(int i = 0;by3BackValueReducePoints.Count > i; i++)
        {
            by3BackValueReducePoints[i].reduceChips.Chips.Clear();
        }
    }
   /* public void AnimationWorking()
    {
        for (int i = 0;i<WheelAnimation.Count;i++)
        {
            if (winnerNum == i)
            {
                WheelAnimation[i].SetActive(true);

            }
        }
    }*/
    public void DesableAnimation()
    {/*
        for (int i = 0; i < WheelAnimation.Count; i++)
        {
           
            {
                WheelAnimation[i].SetActive(false);
                

            }
        }*/
    }
    public void PlayStartinganimation()
    {
        animatorpivote.StopPlayback();
        Debug.Log(winnerNum + "Wninner num starting");
        innerBall.SetActive(false);
        Debug.Log(innerBall + "false");
        if (winnerNum == 0)
        {
            animatorpivote.Play("OutGoing0", -1, 0f);
            animator.Play("0ThrowTheMiddle");
            animCount++;
        }
        if (winnerNum == 1)
        {
            animatorpivote.Play("OutGoing1", -1, 0f);
            animator.Play("1ThrowTheMiddle");
            animCount++;
        }
        if (winnerNum == 2)
        {
            animatorpivote.Play("OutGoing2", -1, 0f);
            animator.Play("2ThrowTheMiddle");
            animCount++;
        }
        if (winnerNum == 3)
        {
            animatorpivote.Play("OutGoing3", -1, 0f);
            animator.Play("3ThrowTheMiddle");
            animCount++;
        }
        if (winnerNum == 4)
        {
            animatorpivote.Play("OutGoing4", -1, 0f);
            animator.Play("4ThrowTheMiddle");
            animCount++;
        }
        if (winnerNum == 5)
        {
            animatorpivote.Play("OutGoing5", -1, 0f);
            animator.Play("5ThrowTheMiddle");
            animCount++;
        }
        if (winnerNum == 6)
        {
            animatorpivote.Play("OutGoing6", -1, 0f);
            animator.Play("6ThrowTheMiddle");
            animCount++;
        }
        if (winnerNum == 7)
        {
            animatorpivote.Play("OutGoing7", -1, 0f);
            animator.Play("7ThrowTheMiddle");
            animCount++;
        }
        if (winnerNum == 8)
        {
            animatorpivote.Play("OutGoing8", -1, 0f);
            animator.Play("8ThrowTheMiddle");
            animCount++;
        }
        if (winnerNum == 9)
        {
            animatorpivote.Play("OutGoing9", -1, 0f);
            animator.Play("9ThrowTheMiddle");
            animCount++;
        }
        else if (winnerNum == 10)
        {
            animatorpivote.Play("OutGoing10", -1, 0f);
            animator.Play("10ThrowTheMiddle");
        }
        else if (winnerNum == 11)
        {
            animatorpivote.Play("OutGoing11", -1, 0f);
            animator.Play("11ThrowTheMiddle");
        }
        else if (winnerNum == 12)
        {
            animatorpivote.Play("OutGoing12", -1, 0f);
            animator.Play("12ThrowTheMiddle");
        }
        else if (winnerNum == 13)
        {
            animatorpivote.Play("OutGoing13", -1, 0f);
            animator.Play("13ThrowTheMiddle");
        }
        else if (winnerNum == 14)
        {
            animatorpivote.Play("OutGoing14", -1, 0f);
            animator.Play("14ThrowTheMiddle");
        }
        else if (winnerNum == 15)
        {
            animatorpivote.Play("OutGoing15", -1, 0f);
            animator.Play("15ThrowTheMiddle");
        }
        else if (winnerNum == 16)
        {
            animatorpivote.Play("OutGoing16", -1, 0f);
            animator.Play("16ThrowTheMiddle");
        }
        else if (winnerNum == 17)
        {
            animatorpivote.Play("OutGoing17", -1, 0f);
            animator.Play("17ThrowTheMiddle");
        }
        else if (winnerNum == 18)
        {
            animatorpivote.Play("OutGoing18", -1, 0f);
            animator.Play("18ThrowTheMiddle");
        }
        else if (winnerNum == 19)
        {
            animatorpivote.Play("OutGoing19", -1, 0f);
            animator.Play("19ThrowTheMiddle");
        }
        else if (winnerNum == 20)
        {
            animatorpivote.Play("OutGoing20", -1, 0f);
            animator.Play("20ThrowTheMiddle");
        }
        else if (winnerNum == 21)
        {
            animatorpivote.Play("OutGoing21", -1, 0f);
            animator.Play("21ThrowTheMiddle");
        }
        else if (winnerNum == 22)
        {
            animatorpivote.Play("OutGoing22", -1, 0f);
            animator.Play("22ThrowTheMiddle");
        }
        else if (winnerNum == 23)
        {
            animatorpivote.Play("OutGoing23", -1, 0f);
            animator.Play("23ThrowTheMiddle");
        }
        else if (winnerNum == 24)
        {
            animatorpivote.Play("OutGoing24", -1, 0f);
            animator.Play("24ThrowTheMiddle");
        }
        else if (winnerNum == 25)
        {
            animatorpivote.Play("OutGoing25", -1, 0f);
            animator.Play("25ThrowTheMiddle");
        }
        else if (winnerNum == 26)
        {
            animatorpivote.Play("OutGoing26", -1, 0f);
            animator.Play("26ThrowTheMiddle");
        }
        else if (winnerNum == 27)
        {
            animatorpivote.Play("OutGoing27", -1, 0f);
            animator.Play("27ThrowTheMiddle");
        }
        else if (winnerNum == 28)
        {
            animatorpivote.Play("OutGoing28", -1, 0f);
            animator.Play("28ThrowTheMiddle");
        }
        else if (winnerNum == 29)
        {
            animatorpivote.Play("OutGoing29", -1, 0f);
            animator.Play("29ThrowTheMiddle");
        }
        else if (winnerNum == 30)
        {
            animatorpivote.Play("OutGoing30", -1, 0f);
            animator.Play("30ThrowTheMiddle");
        }
        else if (winnerNum == 31)
        {
            animatorpivote.Play("OutGoing31", -1, 0f);
            animator.Play("31ThrowTheMiddle");
        }
        else if (winnerNum == 32)
        {
            animatorpivote.Play("OutGoing32", -1, 0f);
            animator.Play("32ThrowTheMiddle");
        }
        else if (winnerNum == 33)
        {
            animatorpivote.Play("OutGoing33", -1, 0f);
            animator.Play("33ThrowTheMiddle");
        }
        else if (winnerNum == 34)
        {
            animatorpivote.Play("OutGoing34", -1, 0f);
            animator.Play("34ThrowTheMiddle");
        }
        else if (winnerNum == 35)
        {
            animatorpivote.Play("OutGoing35", -1, 0f);
            animator.Play("35ThrowTheMiddle");
        }
        else if (winnerNum == 36)
        {
            animatorpivote.Play("OutGoing36", -1, 0f);
            animator.Play("36ThrowTheMiddle");
        }
        else if (winnerNum == 37)
        {
            Debug.Log("Working Animation");
            animatorpivote.Play("OutGoing00", -1, 0f);
            animator.Play("00ThrowTheMiddle");
            Debug.Log("Animation Worked");
        }
        //animatorpivote.StopPlayback();
    }

    public void PlayAnimation()
    {
        //outerBall.transform.position= Vector3.Lerp(outerBall.transform.position,innerBall.transform.position,2f*Time.deltaTime);
        // Stop all animations first
        animator.StopPlayback();
        isChecking = false;
        Debug.Log(winnerNum + "winnernum");
        innerBall.SetActive(true);
        //animatorpivote.enabled = false;
        outerBall.SetActive(false);

        // Play the selected animation
        if (winnerNum == 0)
        {
            animator.Play("Starting0");
            Debug.Log("Wheel 0");
            //audioManager.SoundPlayingg(audioManager.winNum[0]);


        }
        else if (winnerNum == 1)
        {
            animator.Play("Starting1");
            Debug.Log("Wheel 1");
            audioManager.SoundPlayingg(audioManager.reDSound);

        }
        else if (winnerNum == 2)
        {
            animator.Play("Starting2");
            Debug.Log("Wheel 2");
            audioManager.SoundPlayingg(audioManager.blackSound);

        }
        else if (winnerNum == 3)
        {
            animator.Play("Starting3");
            Debug.Log("Wheel 3");
            audioManager.SoundPlayingg(audioManager.reDSound);


        }
        else if (winnerNum == 4)
        {
            animator.Play("Starting4");
            Debug.Log("Wheel 4");
            audioManager.SoundPlayingg(audioManager.blackSound);


        }
        else if (winnerNum == 5)
        {
            animator.Play("Starting5");
            Debug.Log("Wheel 5");
            audioManager.SoundPlayingg(audioManager.reDSound);


        }
        else if (winnerNum == 6)
        {
            animator.Play("Starting6");
            Debug.Log("Wheel 6");
            audioManager.SoundPlayingg(audioManager.blackSound);


        }
        else if (winnerNum == 7)
        {
            animator.Play("Starting7");
            Debug.Log("Wheel 7");
            audioManager.SoundPlayingg(audioManager.reDSound);


        }
        if (winnerNum == 8)
        {
            animator.Play("Starting8");
            Debug.Log("Wheel 8");
            audioManager.SoundPlayingg(audioManager.blackSound);

        }

        else if (winnerNum == 9)
        {
            animator.Play("Starting9");
            Debug.Log("Wheel 9");
            audioManager.SoundPlayingg(audioManager.reDSound);

        }
        else if (winnerNum == 10)
        {
            animator.Play("Starting10");
            Debug.Log("Wheel 10");
            audioManager.SoundPlayingg(audioManager.blackSound);


        }
        else if (winnerNum == 11)
        {
            animator.Play("Starting11");
            Debug.Log("Wheel 11");
            audioManager.SoundPlayingg(audioManager.blackSound);

        }
        else if (winnerNum == 12)
        {
            animator.Play("Starting12");
            Debug.Log("Wheel 12");
            audioManager.SoundPlayingg(audioManager.reDSound);

        }
        else if (winnerNum == 13)
        {
            animator.Play("Starting13");
            Debug.Log("Wheel 13");
            audioManager.SoundPlayingg(audioManager.blackSound);

        }
        else if (winnerNum == 14)
        {
            animator.Play("Starting14");
            Debug.Log("Wheel 14");
            audioManager.SoundPlayingg(audioManager.reDSound);

        }
        else if (winnerNum == 15)
        {
            animator.Play("Starting15");
            Debug.Log("Wheel 15");
            audioManager.SoundPlayingg(audioManager.blackSound);

        }
        else if (winnerNum == 16)
        {
            animator.Play("Starting16");
            Debug.Log("Wheel 16");
            audioManager.SoundPlayingg(audioManager.reDSound);

        }
        else if (winnerNum == 17)
        {
            animator.Play("Starting17");
            Debug.Log("Wheel 17");
            audioManager.SoundPlayingg(audioManager.blackSound);

        }
        else if (winnerNum == 18)
        {
            animator.Play("Starting18");
            Debug.Log("Wheel 18");
            audioManager.SoundPlayingg(audioManager.reDSound);

        }
        else if (winnerNum == 19)
        {
            animator.Play("Starting19");
            Debug.Log("Wheel 19");
            audioManager.SoundPlayingg(audioManager.reDSound);


        }
        else if (winnerNum == 20)
        {
            animator.Play("Starting20");
            Debug.Log("Wheel 20");
            audioManager.SoundPlayingg(audioManager.blackSound);

        }
        else if (winnerNum == 21)
        {
            animator.Play("Starting21");
            Debug.Log("Wheel 21");
            audioManager.SoundPlayingg(audioManager.reDSound);

        }
        else if (winnerNum == 22)
        {
            animator.Play("Starting22");
            Debug.Log("Wheel 22");
            audioManager.SoundPlayingg(audioManager.blackSound);

        }
        else if (winnerNum == 23)
        {
            animator.Play("Starting23");
            Debug.Log("Wheel 23");
            audioManager.SoundPlayingg(audioManager.reDSound);

        }
        else if (winnerNum == 24)
        {
            animator.Play("Starting24");
            Debug.Log("Wheel 24");
            audioManager.SoundPlayingg(audioManager.blackSound);

        }
        else if (winnerNum == 25)
        {
            animator.Play("Starting25");

            Debug.Log("Wheel 25");
            audioManager.SoundPlayingg(audioManager.reDSound);
            //audioManager.SoundPlayingg(audioManager.blackSound);

        }
        else if (winnerNum == 26)
        {
            animator.Play("Starting26");
            audioManager.SoundPlayingg(audioManager.blackSound);

            Debug.Log("Wheel 26");
        }
        else if (winnerNum == 27)
        {
            animator.Play("Starting27");
            Debug.Log("Wheel 27");
            audioManager.SoundPlayingg(audioManager.reDSound);

        }
        else if (winnerNum == 28)
        {
            animator.Play("Starting28");
            Debug.Log("Wheel 28");
            audioManager.SoundPlayingg(audioManager.blackSound);

        }
        else if (winnerNum == 29)
        {
            animator.Play("Starting29");
            Debug.Log("Wheel 29");
            audioManager.SoundPlayingg(audioManager.blackSound);

        }
        else if (winnerNum == 30)
        {
            animator.Play("Starting30");
            audioManager.SoundPlayingg(audioManager.reDSound);

            Debug.Log("Wheel 30");
        }
        else if (winnerNum == 31)
        {
            Debug.Log("Wheel 31");
            animator.Play("Starting31");
            audioManager.SoundPlayingg(audioManager.blackSound);

        }
        else if (winnerNum == 32)
        {
            animator.Play("Starting32");
            Debug.Log("Wheel 32");
            audioManager.SoundPlayingg(audioManager.reDSound);

        }
        else if (winnerNum == 33)
        {
            animator.Play("Starting33");
            Debug.Log("Wheel 33");
            audioManager.SoundPlayingg(audioManager.blackSound);

        }
        else if (winnerNum == 34)
        {
            animator.Play("Starting34");
            Debug.Log("Wheel 34");
            audioManager.SoundPlayingg(audioManager.reDSound);

        }
        else if (winnerNum == 35)
        {
            animator.Play("Starting35");
            Debug.Log("Wheel 35");
            audioManager.SoundPlayingg(audioManager.blackSound);


        }
        else if (winnerNum == 36)
        {
            animator.Play("Starting36");
            Debug.Log("Wheel 36");
            audioManager.SoundPlayingg(audioManager.reDSound);

        }
        else if (winnerNum == 37)
        {
            animator.Play("Starting00");
            Debug.Log("Wheel 37");
            // audioManager.SoundPlayingg(audioManager.blackSound);
            //audioManager.SoundPlayingg(audioManager.winNum[37]);



        }
        StartCoroutine(PlayWinnerNumAudio(winnerNum));

    }
    public IEnumerator PlayWinnerNumAudio(int winnerNum)
    {
        yield return new WaitForSeconds(1f);
        audioManager.SoundPlayingg(audioManager.winNum[winnerNum]);

    }
    public void ClearBnDesable()
    {
      
        clearBy37 = bettingScript.upgradeCurrentPOint.Any(value => value != 0);
        clearBy2 = TwoSide.upgradeCurrentPoint7.Any(value => value != 0);
        clearBy3 = SingleColumn.upgradeCurrentPoint9.Any(value => value != 0);
        clearBy4 = center4Selection.upgradeCurrentPoint6.Any(value => value != 0);
        clearBy6 = DoubleColumn.upgradeCurrentPoint8.Any(value => value != 0);
        clearBy12 = by12.upgradeCurrentPoint2.Any(value => value != 0);
        clearBy18 = by18.upgradeCurrentPoint3.Any(value => value != 0);
        clearBlackAndWight =blackAndRed.upgradeCurrentPoint5.Any(value => value != 0);
        clearEvenandOdd = evenandOdd.upgradeCurrentPoint4.Any(value => value != 0);
        clear2to1 = twoToOne.upgradeCurrentPoint.Any(value => value != 0);
        clearBy3By3 = by3AddBEttingPointt.upgradeCurrentPointBy3.Any(value => value != 0);
        

        if (clearBy37 == true || clearBy2==true || clearBy3 == true || clearBy4 == true || clearBy6 == true || clearBy12 == true || clearBy18 == true || clearBlackAndWight == true || clearEvenandOdd == true || clear2to1 == true|| clearBy3By3==true)
        {
            Debug.Log("The upgrade curentpoint is not null");
            clearButton.SetActive(true);
            doubleButton.SetActive(true);
        }
        else
        {
            clearButton.SetActive(false);
            doubleButton.SetActive(false);
            Debug.Log("That list is empty");
        }
        /*if (isChekingRepeat == 0)
        {
            repeatButton.SetActive(false);
        }*/
    }


    //--------------------------History Starting Value-------------------
    private void InitializeHistory()
    {
        for (int i = 0; i < 10; i++)
        {
            int randomHistoryNum = Random.Range(0, 3);

            if (randomHistoryNum == 0)
            {
                redHistoryList.Add("<color=red>null</color>");
                yellowHistoryList.Add(" ");
                greenHistoryList.Add(" ");

                yellowHistoryText.text = string.Join("\n", yellowHistoryList);
                greenHistoryText.text = string.Join("\n", greenHistoryList);
            }
            else if(randomHistoryNum == 1)
            {
                yellowHistoryList.Add("<color=yellow>null</color>");
                greenHistoryList.Add(" ");
                redHistoryList.Add(" ");


                redHistoryText.text = string.Join("\n", redHistoryList);
                greenHistoryText.text = string.Join("\n", greenHistoryList);
            }
            else
            {
                greenHistoryList.Add("<color=green>null</color>");
                yellowHistoryList.Add(" ");
                redHistoryList.Add(" ");


                redHistoryText.text = string.Join("\n", redHistoryList);
                yellowHistoryText.text = string.Join("\n", yellowHistoryList);
            }
            // Update UI to show initial empty history
           
        }

       
    }


}
