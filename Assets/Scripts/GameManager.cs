using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    //UI Placeholder
    [Header("UI In game Holder")]
    [SerializeField] private TextMeshProUGUI clockTxt;
    [SerializeField] private GameObject resultsTab;
    [SerializeField] private TextMeshProUGUI detailsTabEntry;


    //Game Parameters;
    private float maxTime;
    private float elapseInGameTime;


    bool isCompleted;
    


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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
