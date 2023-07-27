using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    //UI Placeholder
    [Header("UI In game Holder")]
    [SerializeField] private TextMeshProUGUI clockTxt;
    [SerializeField] private GameObject WinnerTab;
    [SerializeField] private GameObject OnLoserTab;


    //Game Parameters;
    private float maxTime = 120.0f;
    private float elapseInGameTime = 0.0f;


    bool isCompleted = false;
    
    


    //Singleton Pattern
    public static GameManager Instance { get; private set; }
    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        isCompleted = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (!isCompleted)
        {
            elapseInGameTime += Time.deltaTime;
        }

        else
        {
            WinnerTab.SetActive(true);
        }


        if (elapseInGameTime > maxTime)
        {
            YouLose();
        }

        UpdateTime();
    }

    public void YouWin()
    {
        isCompleted = true;
    }

    public void YouLose()
    {
        //Open another trigger
        OnLoserTab.SetActive(true);
    }

    private void UpdateTime()
    {
        clockTxt.text = $"{(int)(maxTime - elapseInGameTime)} s";
    }
}
