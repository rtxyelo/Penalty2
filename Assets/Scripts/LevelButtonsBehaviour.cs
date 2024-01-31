using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class LevelButtonsBehaviour : MonoBehaviour
{
    [SerializeField] private Image[] _lvlImgList;
    [SerializeField] private Sprite[] _lvlSpritesList;
    private string _currentLevelKey = "Level";

    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey(_currentLevelKey))
        {
            PlayerPrefs.SetInt(_currentLevelKey, 1);
        }
        switch (PlayerPrefs.GetInt(_currentLevelKey, 1))
        {
            case 2:
            {
                _lvlImgList[0].sprite = _lvlSpritesList[0];
                break;
            }
            case 3:
            {
                _lvlImgList[0].sprite = _lvlSpritesList[0];
                _lvlImgList[1].sprite = _lvlSpritesList[1];
                break;
            }
            case 4:
            {
                _lvlImgList[0].sprite = _lvlSpritesList[0];
                _lvlImgList[1].sprite = _lvlSpritesList[1];
                _lvlImgList[2].sprite = _lvlSpritesList[2];
                break;
            }
            case 5:
            {
                _lvlImgList[0].sprite = _lvlSpritesList[0];
                _lvlImgList[1].sprite = _lvlSpritesList[1];
                _lvlImgList[2].sprite = _lvlSpritesList[2];
                _lvlImgList[3].sprite = _lvlSpritesList[3];
                break;
            }
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
