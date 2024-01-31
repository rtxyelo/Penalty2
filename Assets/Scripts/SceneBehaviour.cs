using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneBehaviour : MonoBehaviour
{
    private string _currentLevelKey = "Level";
    private string _currentBackGroundKey = "BackGround";

    public void LoadMainMenuScene()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadGamePlayScene(int _backLvl)
    {
        int _currLvl = PlayerPrefs.GetInt(_currentLevelKey, 1);
        if (_currLvl - 1 >= _backLvl)
        {
            PlayerPrefs.SetInt(_currentBackGroundKey, _backLvl + 1);
            SceneManager.LoadScene(1);
        }
    }
}
