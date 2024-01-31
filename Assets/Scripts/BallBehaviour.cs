using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    [SerializeField] GameObject _gbObj;
    [SerializeField] GameObject _gkeepObj;
    GameBehaviour _gb;
    GoalKeaperBehaviour _gkeep;
    Animator _animator;
    int _targetNum;
    
    // Start is called before the first frame update
    void Start()
    {
        _gb = _gbObj.GetComponent<GameBehaviour>();
        _gkeep = _gkeepObj.GetComponent<GoalKeaperBehaviour>();
        _animator = GetComponent<Animator>();
        _animator.Play("BallIlde");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetTargetNum(int _tNum)
    {
        _targetNum = _tNum;
        _animator.Play("BallTarget" + _targetNum);
    }

    public void StartGame()
    {
        int _gkPosNum = _gkeep.GetGoalKeaperPosition();
        // GameBehaviour _gb = new GameBehaviour();

        // Debug.Log("STARTGAMEDEBUG: ");
        // Debug.Log("_targetNum: " + _targetNum);
        // Debug.Log("_gkPosNum: " + _gkPosNum);

        _gb.PunchResult(_targetNum, _gkPosNum);
    }
}
