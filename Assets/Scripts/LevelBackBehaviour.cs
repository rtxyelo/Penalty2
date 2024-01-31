using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBackBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject _backGroundsList;
    private string _currentBackGroundKey = "BackGround";

    void Start()
    {
        if (!PlayerPrefs.HasKey(_currentBackGroundKey))
        {
            PlayerPrefs.SetInt(_currentBackGroundKey, 1);
            _backGroundsList.transform.GetChild(0).gameObject.SetActive(true);
        }
        else
        {
            int _currntBack = PlayerPrefs.GetInt(_currentBackGroundKey, 1);
            _backGroundsList.transform.GetChild(_currntBack - 1).gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
