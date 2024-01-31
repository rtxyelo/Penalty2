using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameBehaviour : MonoBehaviour
{

    [SerializeField] private GameObject[] _objToHide;
    [SerializeField] private GameObject _winTable;
    [SerializeField] private TMP_Text _recordText;
    [SerializeField] private TMP_Text _recordTextShadow;
    [SerializeField] private GameObject _loseTable;
    [SerializeField] private GameObject _backBtn;
    [SerializeField] private Image _bar;
    [SerializeField] private TMP_Text _gameRecordText;

    private string _currentLevelKey = "Level";
    private string _currentRecordKey = "Record";

    [SerializeField] private int _secondLvlRecord = 50;
    [SerializeField] private int _thirdLvlRecord = 100;
    [SerializeField] private int _fourthLvlRecord = 300;
    [SerializeField] private int _fifthLvlRecord = 500;

    private int _currentGameRecord = 0;
    private TMP_Text _gameLevelText;

    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey(_currentLevelKey))
        {
            PlayerPrefs.SetInt(_currentLevelKey, 1);
        }
        if (!PlayerPrefs.HasKey(_currentRecordKey))
        {
            PlayerPrefs.SetInt(_currentRecordKey, 0);
        }

        _bar.fillAmount = 0.0f;

        _gameLevelText = _objToHide[5].GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        int _currLvl = PlayerPrefs.GetInt(_currentLevelKey, 1);
        if (_currLvl == 5)
        {
            _objToHide[3].SetActive(false);
        }

        _gameLevelText.text = "Level " + PlayerPrefs.GetInt(_currentLevelKey, 1);
    }

    public void PunchResult(int _tNum, int _gkPos)
    {
        foreach (GameObject obj in _objToHide)
        {
            obj.SetActive(false);
        }
        _backBtn.SetActive(true);

        Debug.Log("BallPos " + _tNum);
        Debug.Log("GoalKeaperPos " + _gkPos);

        // Win
        if (_tNum != _gkPos)
        {
            _winTable.SetActive(true);
            if (_tNum == 3 || _tNum == 6)
            {
                _currentGameRecord += 30;
                _recordText.text = "30";
                _recordTextShadow.text = "30";
                _gameRecordText.text = "Score \n" + _currentGameRecord.ToString();
            }
            else if (_tNum == 1 || _tNum == 2 || _tNum == 7 || _tNum == 8)
            {
                _currentGameRecord += 20;
                _recordText.text = "20";
                _recordTextShadow.text = "20";
                _gameRecordText.text = "Score \n" + _currentGameRecord.ToString();
            }
            else
            {
                _currentGameRecord += 10;
                _recordText.text = "10";
                _recordTextShadow.text = "10";
                _gameRecordText.text = "Score \n" + _currentGameRecord.ToString();
            }
            CheckNewRecordAndLevel(_currentGameRecord);
            UpdateProgressBar(_currentGameRecord);

        }
        // Lose
        else
        {
            _loseTable.SetActive(true);
            _currentGameRecord = 0;
        }
    }

    private void UpdateProgressBar(int _currentGameRec)
    {
        // _bar.fillAmount = _currentGameRecord / 100;
        
        // Check new level
        int _currLvl = PlayerPrefs.GetInt(_currentLevelKey, 1);

        if (_currLvl == 1)
        {
            _bar.fillAmount = (float)_currentGameRecord / _secondLvlRecord;
            Debug.Log("Bar amount " + _bar.fillAmount);
        }
        else if (_currLvl == 2)
        {
            _bar.fillAmount = (float)_currentGameRecord / _thirdLvlRecord;
            Debug.Log("Bar amount " + _bar.fillAmount);
        }
        else if (_currLvl == 3)
        {
            _bar.fillAmount = (float)_currentGameRecord / _fourthLvlRecord;
            Debug.Log("Bar amount " + _bar.fillAmount);
        }
        else if (_currLvl == 4)
        {
            _bar.fillAmount = (float)_currentGameRecord / _fifthLvlRecord;
            Debug.Log("Bar amount " + _bar.fillAmount);
        }
    }

    private void CheckNewRecordAndLevel(int _record)
    {
        Debug.Log("CURRREC======= " + _record);
        // Check new record
        if (_record >= PlayerPrefs.GetInt(_currentRecordKey, 0))
        {
            PlayerPrefs.SetInt(_currentRecordKey, _record);
            _gameRecordText.text = "NEW RECORD \n" + _currentGameRecord.ToString();
            Debug.Log("NEW RECORD");
        }
        Debug.Log("Current Record " + PlayerPrefs.GetInt(_currentRecordKey, -1));

        // Check new level
        int _currLvl = PlayerPrefs.GetInt(_currentLevelKey, 1);
        
        if (PlayerPrefs.GetInt(_currentRecordKey, 0) >= _secondLvlRecord && _currLvl == 1)
        {
            PlayerPrefs.SetInt(_currentLevelKey, _currLvl + 1);
            Debug.Log("NEW LEVEL 2");
        }

        else if (PlayerPrefs.GetInt(_currentRecordKey, 0) >= _thirdLvlRecord && _currLvl == 2)
        {
            PlayerPrefs.SetInt(_currentLevelKey, _currLvl + 1);
            Debug.Log("NEW LEVEL 3");
        }

        else if (PlayerPrefs.GetInt(_currentRecordKey, 0) >= _fourthLvlRecord && _currLvl == 3)
        {
            PlayerPrefs.SetInt(_currentLevelKey, _currLvl + 1);
            Debug.Log("NEW LEVEL 4");
        }

        else if (PlayerPrefs.GetInt(_currentRecordKey, 0) >= _fifthLvlRecord && _currLvl == 4)
        {
            PlayerPrefs.SetInt(_currentLevelKey, _currLvl + 1);
            Debug.Log("NEW LEVEL 5");
        }

        Debug.Log("Current Level " + PlayerPrefs.GetInt(_currentLevelKey, -1));

    }

    public void ContinueGameplay()
    {
        foreach (GameObject obj in _objToHide)
        {
            obj.SetActive(true);
        }
            _winTable.SetActive(false);
            _loseTable.SetActive(false);    
    }
}
