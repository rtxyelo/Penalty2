using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugScript : MonoBehaviour
{
    private string _currentLevelKey = "Level";
    private string _currentBackGroundKey = "BackGround";
    private string _currentRecordKey = "Record";

    [SerializeField] private int _currentLevel = 1;
    [SerializeField] private int _currentBackGround = 1;
    [SerializeField] private int _currentRecord = 0;
    [SerializeField] private bool _debug = false;
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey(_currentLevelKey))
        {
            PlayerPrefs.SetInt(_currentLevelKey, 1);
        }
        if (!PlayerPrefs.HasKey(_currentBackGroundKey))
        {
            PlayerPrefs.SetInt(_currentBackGroundKey, 1);
        }
        if (!PlayerPrefs.HasKey(_currentRecordKey))
        {
            PlayerPrefs.SetInt(_currentRecordKey, 0);
        }


        // DEBUG
        if (_debug)
        {
            PlayerPrefs.SetInt(_currentLevelKey, _currentLevel);
            PlayerPrefs.SetInt(_currentBackGroundKey, _currentBackGround);
            PlayerPrefs.SetInt(_currentRecordKey, _currentRecord);
        }
        
        Debug.Log("Current Level " + PlayerPrefs.GetInt(_currentLevelKey, -1));
        Debug.Log("Current Record " + PlayerPrefs.GetInt(_currentRecordKey, -1));
        Debug.Log("Current BackGround " + PlayerPrefs.GetInt(_currentBackGroundKey, -1));


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
