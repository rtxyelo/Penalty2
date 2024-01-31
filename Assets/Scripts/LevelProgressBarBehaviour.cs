using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelProgressBarBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject _lvlList;
    private string _currentLevelKey = "Level";

    void Start()
    {
        if (!PlayerPrefs.HasKey(_currentLevelKey))
        {
            PlayerPrefs.SetInt(_currentLevelKey, 1);
            _lvlList.transform.GetChild(0).gameObject.SetActive(true);
        }
        else
        {
            int _currntLvl = PlayerPrefs.GetInt(_currentLevelKey, 1);
            _lvlList.transform.GetChild(_currntLvl - 1).gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
