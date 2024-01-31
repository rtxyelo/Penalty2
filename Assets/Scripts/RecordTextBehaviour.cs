using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RecordTextBehaviour : MonoBehaviour
{
    [SerializeField] private TMP_Text _recordText;
    private string _currentRecordKey = "Record";

    void Start()
    {
        if (!PlayerPrefs.HasKey(_currentRecordKey))
        {
            PlayerPrefs.SetInt(_currentRecordKey, 0);
        }
        else
        {
            int _currntRec = PlayerPrefs.GetInt(_currentRecordKey, 0);
            _recordText.text = "RECORD: " + _currntRec.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        int _currntRec = PlayerPrefs.GetInt(_currentRecordKey, 0);
        _recordText.text = "RECORD: " + _currntRec.ToString();
    }
}
